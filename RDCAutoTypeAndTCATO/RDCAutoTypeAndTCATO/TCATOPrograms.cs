using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//bellow copied
using System.Diagnostics;

using KeePass.App;
using KeePass.Native;
using KeePass.Resources;
using KeePass.UI;
using KeePass.Util;

using KeePassLib;
using KeePassLib.Security;
using KeePassLib.Collections;
using KeePassLib.Utility;

namespace RDCAutoTypeAndTCATO
{
    public partial class TCATOPrograms : Form
    {
        //string[] TCACOProgramList = null;
        //string[] CTProgramList = null;
        private PList c = new PList();

        public TCATOPrograms()
        {
            InitializeComponent();
        }

        private void TCATOPrograms_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            comboBox1.Enabled = false;
            //close.Enabled = false;

            FillList();
        }

        private void FillList()
        {/*
            NativeMethods.EnumWindowsProc procEnum = delegate(IntPtr hWnd,
    IntPtr lParam)
            {
                string strName = NativeMethods.GetWindowText(hWnd);
                if ((strName != null) && (strName.Length > 0))
                {
                    if ((NativeMethods.GetWindowStyle(hWnd) &
                        NativeMethods.WS_VISIBLE) != 0)
                    {
                        m_cmbWindow.Items.Add(strName);
                    }
                }

                return true;
            };

            NativeMethods.EnumWindows(procEnum, IntPtr.Zero);
          */
        }

        //public void Passlist(ref string[] TCATOPrograms, ref string[] CTPrograms)
        public void Passlist (PList m_c)
        {
            //TCACOProgramList = TCATOPrograms;
            //CTProgramList = CTPrograms;
            c = m_c;
        }

        public void UpdateList()
        {
            richTextBox1.Text = null;
            foreach (string s in c.TCATOPrograms)
            {
                richTextBox1.Text += s + "\n";
            }

            richTextBox2.Text = null;
            foreach (string s in c.CTPrograms)
            {
                richTextBox2.Text += s + "\n";
            }

            checkBox1.Checked = c.UseClipboad;
            switch (c.IE_CT)
            {
                case "true":
                    checkBox2.CheckState = CheckState.Checked;
                    break;
                case "false":
                    checkBox2.CheckState = CheckState.Unchecked;
                    break;
                case "undefined":
                    checkBox2.CheckState = CheckState.Indeterminate;
                    break;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            char[] nl = new char[1];
            nl[0] = '\n';

            c.TCATOPrograms = richTextBox1.Text.Split(nl, StringSplitOptions.RemoveEmptyEntries);
            c.CTPrograms = richTextBox2.Text.Split(nl, StringSplitOptions.RemoveEmptyEntries);

            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:
                    c.IE_CT = "true";
                    break;
                case CheckState.Unchecked:
                    c.IE_CT = "false";
                    break;
                case CheckState.Indeterminate:
                    c.IE_CT = "undefined";
                    break;
            }

            c.UseClipboad = checkBox1.Checked;

            bool to_short = false;

            foreach (string w in c.TCATOPrograms)
            {
                if (w.Length < 4) to_short = true;
            }
            foreach (string w in c.CTPrograms)
            {
                if (w.Length < 4) to_short = true;
            }
            
            if (to_short) MessageService.ShowInfo("Some of the filenames are shorter then 4 characters.\n"
                + "(A file name like .exe might match all programs.)");

            this.Close();
        }
/*
        private void remove_Click(object sender, EventArgs e)
        {
            //Object Array sel = checkedListBox1.CheckedItems;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkedListBox1.Items.Remove(itemChecked);
                //string [] tmp = new string[ProgramList.Length-1];
                //int i=0;
                //ProgramList = tmp;
            }
            UpdateList();
        }   
 */
    }
}
