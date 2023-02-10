using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using KeePass.Plugins;
using KeePass.Util;
using System.Diagnostics;
using System.Windows.Forms;
using KeePassLib.Utility;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Cache;

namespace RDCAutoTypeAndTCATO
{
 /*   public sealed class UserActivityNotifyFilterExtended: IMessageFilter
    {
        internal const int WM_MOUSEMOVE = 0x0200;
        internal const int WM_MOUSEWHEEL = 0x020A;

        public bool PreFilterMessage(ref Message m)
        {
            //if((m.Msg == NativeMethods.WM_KEYDOWN) || (m.Msg == NativeMethods.WM_LBUTTONDOWN) ||
            //    (m.Msg == NativeMethods.WM_RBUTTONDOWN) || (m.Msg == NativeMethods.WM_MBUTTONDOWN) ||
            //    (m.Msg == NativeMethods.WM_MOUSEMOVE) || (m.Msg == NativeMethods.WM_MOUSEWHEEL))
            if ((m.Msg == WM_MOUSEWHEEL) || (m.Msg == WM_MOUSEMOVE))
            {
                
                bool KPfocused = false;
                foreach (Form f in Application.OpenForms)
                {
                    //if (f.Win) KPfocused = true;
                    //KeePass.Program.MainForm.Focused
                }
                if (KPfocused)//(KPfocused)
                    KeePass.Program.NotifyUserActivity();
            }

            return false;
        }
    }
*/

    public sealed class PList
    {
        private string[] m_TCATOPrograms = null;
        private string[] m_CTPrograms = null;
        private bool m_UseClipboard = true;
        private string m_IE_CT = "undefined";
        public string[] TCATOPrograms
        {
            get { return m_TCATOPrograms; }
            set { m_TCATOPrograms = value; }
        }
        public string[] CTPrograms
        {
            get { return m_CTPrograms; }
            set { m_CTPrograms = value; }
        }
        public bool UseClipboad
        {
            get { return m_UseClipboard; }
            set { m_UseClipboard = value; }
        }
        public string IE_CT
        {
            get { return m_IE_CT; }
            set { m_IE_CT = value; }
        }

    }

    public class RDCAutoTypeAndTCATOExt : Plugin
    {
        [DllImport("user32.dll")]
        internal static extern IntPtr GetWindowThreadProcessId
            (IntPtr hwnd, [Out] IntPtr processId);

        [DllImport("User32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        private IPluginHost m_host = null;
        protected string[] TCATOPrograms = null;
        protected string[] CTPrograms = null;
        protected PList c = new PList();

        public const uint cur_ver = 58;
        string defT = "";
        string defC = "mstsc.exe#delim#wfica32.exe#delim#";
        string defIECT = "undefined";
        protected string CTpath = string.Empty;

        string[] delimiter = new String[1];
        private bool RDCFixEnabled = true;
        //private bool UserActivEnabled = true;
        private bool TCATOEnabled = true;
        private ToolStripMenuItem m_tsmiRDCFix;
        //private ToolStripMenuItem m_tsmiUserActivFix;
        private ToolStripMenuItem m_tsmiTCATOEnabled;
        private ToolStripMenuItem m_tsmiTCATOList;
        private ToolStripMenuItem m_tsmiAbout;

        public override bool Initialize(IPluginHost host)
        {
            m_host = host;

            RDCFixEnabled = m_host.CustomConfig.GetBool("RDCFixEnabled", true);
            TCATOEnabled = m_host.CustomConfig.GetBool("TCATOEnabled", true);
            //UserActivEnabled = m_host.CustomConfig.GetBool("UserActivEnabled", true);
            c.UseClipboad = m_host.CustomConfig.GetBool("UseClipboardForUnicodeAtRDC", true);
            long conf_ver = m_host.CustomConfig.GetLong("RDCAutoTypeAndTCATOVer", cur_ver);
            
            delimiter[0] = "#delim#";
            ReadTCATOList();
            ReadCTList();
            ReadIE_CT();

            ToolStripItemCollection tsMenu = m_host.MainWindow.ToolsMenu.DropDownItems;

            // Add a separator at the bottom
            ToolStripSeparator m_tsSeparator = new ToolStripSeparator();
            tsMenu.Add(m_tsSeparator);

            // Add the popup menu item
            ToolStripMenuItem m_tsmiPopup = new ToolStripMenuItem();
            m_tsmiPopup.Text = "RDCAutoTypeAndTCATO";
            tsMenu.Add(m_tsmiPopup);

            // Add menu item 'RDC workaround enabled'
            //ToolStripMenuItem 
            m_tsmiRDCFix = new ToolStripMenuItem();
            m_tsmiRDCFix.Text = "启用 RDC 支持";
            m_tsmiRDCFix.Click += SwitchRDCState;
            m_tsmiPopup.DropDownItems.Add(m_tsmiRDCFix);

            if (RDCFixEnabled)
                m_tsmiRDCFix.Checked = true;
            else
                m_tsmiRDCFix.Checked = false;
            /*
            // Add menu item 'User activity enabled'
            //ToolStripMenuItem 
            m_tsmiUserActivFix = new ToolStripMenuItem();
            m_tsmiUserActivFix.Text = "User activity enabled";
            m_tsmiUserActivFix.Click += SwitchUserActiveState;
            m_tsmiUserActivFix.Checked = true;
            m_tsmiPopup.DropDownItems.Add(m_tsmiUserActivFix);

            /*if (UserActivEnabled)
                m_tsmiUserActivFix.Checked = true;
            else
                m_tsmiUserActivFix.Checked = false;
             */

            // Add menu item 'RDC workaround enabled'
            //ToolStripMenuItem 
            m_tsmiTCATOEnabled = new ToolStripMenuItem();
            m_tsmiTCATOEnabled.Text = "启用 TCATO 支持";
            m_tsmiTCATOEnabled.Click += SwitchTCATOState;
            m_tsmiPopup.DropDownItems.Add(m_tsmiTCATOEnabled);

            if (TCATOEnabled)
                m_tsmiTCATOEnabled.Checked = true;
            else
                m_tsmiTCATOEnabled.Checked = false;

            // Add a separator at the bottom
            //ToolStripSeparator m_tsSeparatorList = new ToolStripSeparator();
            //m_tsmiPopup.Add(m_tsSeparatorList);

            // Add menu item 'Programs List...'
            //ToolStripMenuItem 
            m_tsmiTCATOList = new ToolStripMenuItem();
            m_tsmiTCATOList.Text = "程序列表...";
            m_tsmiTCATOList.Click += RunProgList;
            m_tsmiPopup.DropDownItems.Add(m_tsmiTCATOList);

            // Add menu item 'About...'
            //ToolStripMenuItem 
            m_tsmiAbout = new ToolStripMenuItem();
            m_tsmiAbout.Text = "关于...";
            m_tsmiAbout.Click += RunAbout;
            //m_tsmiAbout.Image = KeePass.Properties.Resources.B16x16_Help;
            m_tsmiPopup.DropDownItems.Add(m_tsmiAbout);

            KeePass.Util.AutoType.FilterSend += FS;
            //KeePass.UI.GlobalWindowManager.WindowAdded += WinAdded;

            /*
            if (UserActivEnabled)
                ActOn();
            */

            if (KeePass.Program.Config.Application.Start.CheckForUpdate)
                CheckForUpdate();

            //Application.AddMessageFilter(new UserActivityNotifyFilterExtended());

            //foreach (Control c in KeePass.Forms.PwEntryForm.ControlCollection)
            //{
            //    if (c.GetType() == TabControl)
            //        ((TabControl)c).Controls.Add(tp);

            //}

            string a = m_host.CustomConfig.GetString("RDCClasicTypePath", "string-aaa");
            string b = m_host.CustomConfig.GetString("RDCClasicTypePath", "different-string-bbb");
            if (a == b) //user has manualy configurated CT location
            {
                CTpath = a;
            }

            return true;
        }

        public override void Terminate()
        {
            if (RDCFixEnabled) KeePass.Util.AutoType.FilterSend -= FS;
            //if (!UserActivEnabled)
            //    ActOff();

            bool conf_clip = m_host.CustomConfig.GetBool("UseClipboardForUnicodeAtRDC", true);
            if (conf_clip != c.UseClipboad)
                m_host.CustomConfig.SetBool("UseClipboardForUnicodeAtRDC", c.UseClipboad);

            bool tl = WriteTCATOList();
            bool cl = WriteCTList();
            bool ie = WriteIE_CT();
            if ( tl || cl || ie)
            {
                m_host.CustomConfig.SetLong("RDCAutoTypeAndTCATOVer", cur_ver);
            }
        }

        private void FS(object sender, AutoTypeEventArgs e)
        {

            //MessageService.ShowInfo(e.Sequence.ToString());
            
            IntPtr hWnd = GetForegroundWindow();
            IntPtr procesid = IntPtr.Zero;
            IntPtr thredid = GetWindowThreadProcessId(hWnd, procesid);

            FileVersionInfo fvi = null;
            fvi = Getfvi(thredid);
            if (fvi == null) return;

            //Form1 f = new Form1();
            
            //f.Show();

            //f.Fill(e);
            //f.AddText(fvi.FileName.ToString());

            DateTime n = DateTime.Now;
            DateTime exp = new DateTime(2011, 01, 1);

            if (n > exp)
            {
                //string exp_m = "RDCAutoTypeAndTCATO test KeePass plugin has expired - please check the KeePass web site for the new version";
                //MessageService.ShowWarning(exp_m);
                //e.Sequence = exp_m;
            }

            bool CT = false;
            bool TCACTO = e.SendObfuscated;

            foreach (string s in c.CTPrograms)
            {
                if (fvi.FileName.ToLowerInvariant().Contains(s.ToLowerInvariant()))
                    CT = true;
            }

            if (c.IE_CT == "true" && fvi.FileName.ToLowerInvariant().Contains("iexplore.exe"))
                CT = true;
            
            bool IE = false;
            if (CT == true && fvi.FileName.ToLowerInvariant().Contains("iexplore.exe"))
                IE = true;

            if (TCACTO == false && TCATOEnabled == true)
            {
                foreach (string s in c.TCATOPrograms)
                {
                    if (fvi.FileName.ToLowerInvariant().Contains(s.ToLowerInvariant()))
                    {
                        TCACTO = true;
                    }
                }
                e.SendObfuscated = TCACTO;
            }

            if (CT && RDCFixEnabled)
            {
                string s = e.Sequence.ToString();
                //s = s.Replace(" ", "{SPACE}");
                s = s.Replace("@", "{AT}");
                //s = s.Replace("+", "{PLUS}");
                //s = s.Replace("%", "{PERCENT}");
                s = s.Replace("{+}", "{PLUS}");
                s = s.Replace("{^}", "{CARET}");
                s = s.Replace("{%}", "{PERCENT}");
                s = s.Replace("{~}", "{TILDE}");
                s = s.Replace("{(}", "{LEFTPAREN}");
                s = s.Replace("{)}", "{RIGHTPAREN}");
                s = s.Replace("{{}", "{LEFTBRACE}");
                s = s.Replace("{}}", "{RIGHTBRACE}");

                //MessageService.ShowInfo("After run: " + s);
                owntype(s,IE);
                //owntype("testowo");
                //owntype("Test123abcd£$!,");
                e.Sequence = String.Empty;
                //f.AddText("tak");
            }

        }

        protected FileVersionInfo Getfvi(IntPtr thredid)
        {
            Process[] processlist = Process.GetProcesses();
            FileVersionInfo fvi = null;

            try
            {
                foreach (Process theprocess in processlist)
                {
                    foreach (ProcessThread thethread in theprocess.Threads)
                    {
                        if (thethread.Id == (int)thredid)
                        {
                            try
                            {
                                fvi = FileVersionInfo.GetVersionInfo(theprocess.MainModule.FileName);
                            }
                            catch (Exception) { continue; };
                        }
                        if (fvi != null) break;
                    }
                    if (fvi != null) break;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return fvi;
        }

        private bool owntype(string s,bool IE)
        {
            string IEseq = "{DELAY 50}1{DELAY 50}{BACKSPACE}";
            if (s == null) return true;
            Process pType = new Process();
            if (IE)
                s = IEseq + s;
            pType.StartInfo.Arguments = s;
            //pType.StartInfo.WorkingDirectory = KeePass.Plugins.PlgxCache.GetCacheDirectory(
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location.ToString());
            string dir_orig = dir;
            if (CTpath != string.Empty)
                dir = CTpath;
            pType.StartInfo.WorkingDirectory = dir;
            pType.StartInfo.FileName = dir + "\\ClasicType.exe";
            pType.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //MessageService.ShowInfo(dir);
            try
            {
                //MessageService.ShowInfo(pType.StartInfo.FileName);
                pType.Start();
            }
            catch (Exception e)
            {
                string w = "ClasicType.exe error - " + e.Message + "\n\nDetails:\n" + e.ToString()
                    + "\n\nCT dir:\n" + dir_orig;
                if (CTpath != string.Empty)
                    s = s + "\nConfig forced path:\n" + dir;
                MessageService.ShowWarning(w);
                return false;
            }
            pType.PriorityClass = ProcessPriorityClass.AboveNormal;
            //pType.Exited += owntype_end;
            while (!pType.HasExited)
                Thread.Sleep(3);
            int ec = pType.ExitCode;
            if (ec > 50)
            {
                if (c.UseClipboad)
                {
                    string a = s.Substring(0, ec - 50 - 1);
                    string b = s.Substring(ec - 50);
                    Thread.Sleep(50);
                    if (a != String.Empty) owntype(a,IE);
                    //pe, m_docMgr.ActiveDatabase
                    KeePass.Util.ClipboardUtil.Clear();
                    KeePass.Util.ClipboardUtil.Copy((s[ec - 50 - 1]).ToString(),
                        false, null, KeePass.Program.MainForm.ActiveDatabase);
                    Thread.Sleep(50);
                    owntype("^v{DELAY 50}", IE);
                    Thread.Sleep(50);
                    KeePass.Util.ClipboardUtil.Clear();
                    if (b != String.Empty) owntype(b,IE);
                }
                else
                {
                    string m = "The string to be typed: " + s + "\nContaint an character that " +
                    "RDCAutoTypeAndTCATO can't type - position in the string: " + (ec - 50).ToString() +
                    " (=\"" + s[ec - 51] + "\")" + "\n\nAborting Typing";
                    MessageService.ShowWarning(m);
                }

            }

            return true;
        }

        private void SwitchRDCState(object sender, EventArgs e)
        {
            if (RDCFixEnabled)
            {
                RDCFixEnabled = false;
                m_tsmiRDCFix.Checked = false;
            }
            else
            {
                RDCFixEnabled = true;
                m_tsmiRDCFix.Checked = true;
            }
            m_host.CustomConfig.SetBool("RDCFixEnabled", RDCFixEnabled);
            return;
        }

/*
        private void SwitchUserActiveState(object sender, EventArgs e)
        {
            if (UserActivEnabled)
            {
                UserActivEnabled = false;
                m_tsmiUserActivFix.Checked = false;
                ActOff();
            }
            else
            {
                UserActivEnabled = true;
                m_tsmiUserActivFix.Checked = true;
                ActOn();
            }
            m_host.CustomConfig.SetBool("UserActivEnabled", UserActivEnabled);
            return;
        }
 */

        private void SwitchTCATOState(object sender, EventArgs e)
        {
            if (TCATOEnabled)
            {
                TCATOEnabled = false;
                m_tsmiTCATOEnabled.Checked = false;
            }
            else
            {
                TCATOEnabled = true;
                m_tsmiTCATOEnabled.Checked = true;
            }
            //RDCFixEnabled = m_host.CustomConfig.GetBool("RDCFixEnabled", true);
            m_host.CustomConfig.SetBool("TCATOEnabled", TCATOEnabled);
            return;
        }

        private void RunAbout(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void RunProgList(object sender, EventArgs e)
        {
            TCATOPrograms p = new TCATOPrograms();
            p.Show();
            //p.Passlist(ref TCATOPrograms,ref CTPrograms);
            p.Passlist(c);
            p.UpdateList();
        }
/*
        private void UserActive(object sender, EventArgs e)
        {
            m_host.MainWindow.NotifyUserActivity();
            return;
        }
 */

        private void ReadTCATOList()
        {
            string slist = m_host.CustomConfig.GetString("TCATOProgramList", defT);
            c.TCATOPrograms = slist.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        }

        private bool WriteTCATOList()
        {
            string savedlist = m_host.CustomConfig.GetString("TCATOProgramList", defT);
            
            string slist = String.Empty;
            foreach (string s in c.TCATOPrograms)
            {
                slist = slist + s + delimiter[0];
            }
            if (savedlist != slist)
            {
                m_host.CustomConfig.SetString("TCATOProgramList", slist);
                return true;
            }
            else return false;
        }

        private void ReadCTList()
        {
            string slist = m_host.CustomConfig.GetString("CTProgramList", defC);
            c.CTPrograms = slist.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        }

        private bool WriteCTList()
        {
            string savedlist = m_host.CustomConfig.GetString("CTProgramList", defC);

            string slist = String.Empty;
            foreach (string s in c.CTPrograms)
            {
                slist = slist + s + delimiter[0];
            }
            if (savedlist != slist)
            {
                m_host.CustomConfig.SetString("CTProgramList", slist);
                return true;
            }
            else return false;
        }

        private void ReadIE_CT()
        {
            string s = m_host.CustomConfig.GetString("RDC_Plugin_IE_CT", defIECT);
            c.IE_CT = s;
        }

        private bool WriteIE_CT()
        {
            string v = c.IE_CT;
            string s = m_host.CustomConfig.GetString("RDC_Plugin_IE_CT", defIECT);
            if (v != defIECT && v != s)
            {
                m_host.CustomConfig.SetString("RDC_Plugin_IE_CT", v);
                return true;
            }
            else
                return false;
        }
/*
        public void ActOn()
        {
            m_host.MainWindow.Activated += UserActive;
        }

        public void ActOff()
        {
            m_host.MainWindow.Activated -= UserActive;
        }
 */

        public void CheckForUpdate()
        {
            Thread th = new Thread(new ThreadStart(DoCheck));
            th.Start();
        }

        protected void DoCheck()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);

                //Uri uri = new Uri("http://bema.one.pl/RDC/latest/?" + cur_ver);

                //webClient.DownloadDataCompleted +=
                //    new DownloadDataCompletedEventHandler(OnDownloadCompleted);

                //webClient.DownloadDataAsync(uri);
                string r = webClient.DownloadString("http://rdc-keepass-plugin.appspot.com/latest_ver?v=" + cur_ver);

                //MessageService.ShowInfo(r + "test");
                string[] r_tab = r.Split(';');
                uint latest;
                uint.TryParse(r_tab[0], out latest);

                //latest check statistics
                if (r_tab.Length > 1 && r_tab[1] != null)
                {
                    try
                    {
                        string s = r_tab[1];
                        Random rand = new Random();
                        s = s.Replace("*random*", rand.Next(1000, 100000).ToString());
                        s = s.Replace("*cur_ver*", cur_ver.ToString());
                        string s_result = webClient.DownloadString(s);
                    }
                    catch { }
                }

                if (latest > RDCAutoTypeAndTCATOExt.cur_ver)
                {
                    MessageService.ShowWarning("RDCAutoTypeAndTCATO 插件有可用的更新，请从 KeePass 官网下载最新版本。");

                }


            }
            catch (NotImplementedException)
            {
                //ReportStatusEx(KLRes.FrameworkNotImplExcp, true);
            }
            catch (Exception) { }
        }

        void WinAdded(object sender, KeePass.UI.GwmWindowEventArgs e)
        {
            KeePass.Forms.PwEntryForm pw = null;
            try
            {
                pw = (KeePass.Forms.PwEntryForm)e.Form;
            }
            catch (System.InvalidCastException)
            {
            }
            catch (Exception)
            { 
            }
            if (pw != null)
            {
                TabPage tp = new TabPage();
                Button b = new Button();
                Button b2 = new Button();
                b.Text = "Button 1";
                b2.Text = "Button 222";
                //b2.Location = new System.Drawing.Point(300, 100);
                tp.Controls.Add(b);
                tp.Controls.Add(b2);
                tp.Text = "Testowa zakładka";
                TabControl tc = null;
                foreach (Control c in pw.Controls)
                {
                    try
                    {
                        tc = (TabControl)c;
                    }
                    catch (Exception) { }
                }
                if (tc!=null)
                {
                    tc.Controls.Add(tp);
                }
                else
                    MessageService.ShowWarning("test");
                //KeePassLib.PwUuid u = new KeePassLib.PwUuid;
            }

        }

        //private static void OnDownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
        //{
        //    try
        //    {
        //        string r = e.Result.ToString();
        //        MessageService.ShowInfo(r + "test");
        //        uint latest;
        //        uint.TryParse(r, out latest);

        //        if (latest > RDCAutoTypeAndTCATOExt.cur_ver)
        //        {
        //            MessageService.ShowWarning("A new version of RDCAutoTypeAndTCATO KeePass Plugin is available. Please download it form the KeePass website.");

        //        }
        //    }
        //    catch { }
        //}

    }
}