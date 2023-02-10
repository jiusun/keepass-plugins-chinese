using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RDCAutoTypeAndTCATO
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            float v = (float)RDCAutoTypeAndTCATOExt.cur_ver / 100;
            //label2.Text = "Ver. " + v.ToString();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            label2.Text = "Plugin ver. " + fvi.FileVersion + "   (" + v.ToString() + ")";
            try
            {
                string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location.ToString());
                fvi = FileVersionInfo.GetVersionInfo(dir + "\\ClasicType.exe");
                label3.Text = "CT ver. " + fvi.FileVersion;
            }
            catch (Exception)
            {
                label3.Text = "CT not found";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KeePass.Util.WinUtil.OpenUrl("http://plugins.pj.int.pl/RDC/", null);
            this.Close();
        }

     }
}
