using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using KeePassLib;

namespace KeePassHttp
{
    public partial class AccessControlForm : Form
    {
        public AccessControlForm()
        {
            InitializeComponent();
        }

        private void AllowButton_Click(object sender, EventArgs e)
        {
            Allowed = true;
            Close();
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            Denied = true;
            Close();
        }

        public bool Allowed = false;
        public bool Denied = false;

        public bool Remember
        {
            get { return RememberCheck.Checked; }
        }

        public List<PwEntry> Entries
        {
            set
            {
                EntriesBox.SelectionMode = SelectionMode.None;
                Count = value.Count;
                SetLabel();
                foreach (var e in value)
                {
                    if (e == null || e.Strings == null ||
                            e.Strings.Get(PwDefs.TitleField) == null) continue;
                    var title = e.Strings.Get(PwDefs.TitleField).ReadString();
                    if (Plugin == null || Plugin.GetUserPass(e) == null)
                            continue;
                    var username = Plugin.GetUserPass(e)[0];

                    EntriesBox.Items.Add(title + " - " + username);
                }
            }
        }

        public string Host
        {
            set
            {
                _Host = value;
                SetLabel();
            }
        }

        private void SetLabel()
        {
            if (_Host == null)
                return;
            ConfirmTextLabel.Text = String.Format(
                Message,
                _Host,
                Count == 1 ? "" : "\n您需要对上述所有条目进行统一授权，"
            );
        }

        private int Count = 0;
        private const string Message = "{0} 请求访问上述条目的密码。{1}请选择是否允许访问。";
        private string _Host = null;
        internal KeePassHttpExt Plugin = null;
    }
}
