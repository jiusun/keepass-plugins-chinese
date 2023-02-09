using KeePassLib;
using KeePassHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeePassLib.Collections;

namespace KeePassHttp
{
    public partial class OptionsForm : Form
    {
        readonly ConfigOpt _config;
        private bool _restartRequired = false;

        public OptionsForm(ConfigOpt config)
        {
            _config = config;
            InitializeComponent();
        }


        private PwEntry GetConfigEntry(PwDatabase db)
        {
            var kphe = new KeePassHttpExt();
            var root = db.RootGroup;
            var uuid = new PwUuid(kphe.KEEPASSHTTP_UUID);
            var entry = root.FindEntry(uuid, false);
            return entry;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            credNotifyCheckbox.Checked = _config.ReceiveCredentialNotification;
            credMatchingCheckbox.Checked = _config.SpecificMatchingOnly;
            unlockDatabaseCheckbox.Checked = _config.UnlockDatabaseRequest;
            credAllowAccessCheckbox.Checked = _config.AlwaysAllowAccess;
            credAllowUpdatesCheckbox.Checked = _config.AlwaysAllowUpdates;
            credSearchInAllOpenedDatabases.Checked = _config.SearchInAllOpenedDatabases;
            hideExpiredCheckbox.Checked = _config.HideExpired;
            matchSchemesCheckbox.Checked = _config.MatchSchemes;
            returnStringFieldsCheckbox.Checked = _config.ReturnStringFields;
            returnStringFieldsWithKphOnlyCheckBox.Checked = _config.ReturnStringFieldsWithKphOnly;
            SortByUsernameRadioButton.Checked = _config.SortResultByUsername;
            SortByTitleRadioButton.Checked = !_config.SortResultByUsername;
            portNumber.Value = _config.ListenerPort;
            hostName.Text = _config.ListenerHost;

            this.returnStringFieldsCheckbox_CheckedChanged(null, EventArgs.Empty);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _config.ReceiveCredentialNotification = credNotifyCheckbox.Checked;
            _config.SpecificMatchingOnly = credMatchingCheckbox.Checked;
            _config.UnlockDatabaseRequest = unlockDatabaseCheckbox.Checked;
            _config.AlwaysAllowAccess = credAllowAccessCheckbox.Checked;
            _config.AlwaysAllowUpdates = credAllowUpdatesCheckbox.Checked;
            _config.SearchInAllOpenedDatabases = credSearchInAllOpenedDatabases.Checked;
            _config.HideExpired = hideExpiredCheckbox.Checked;
            _config.MatchSchemes = matchSchemesCheckbox.Checked;
            _config.ReturnStringFields = returnStringFieldsCheckbox.Checked;
            _config.ReturnStringFieldsWithKphOnly = returnStringFieldsWithKphOnlyCheckBox.Checked;
            _config.SortResultByUsername = SortByUsernameRadioButton.Checked;
            _config.ListenerPort = (int)portNumber.Value;
            _config.ListenerHost = hostName.Text;
            if (_restartRequired)
            {
                MessageBox.Show(
                    "您已经成功修改了主机名或端口。\n需要重新启动 KeePass 才能生效！\n请立即重启 KeePass！",
                    "需要重新启动 KeePass",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (KeePass.Program.MainForm.DocumentManager.ActiveDatabase.IsOpen)
            {
                PwDatabase db = KeePass.Program.MainForm.DocumentManager.ActiveDatabase;
                var entry = GetConfigEntry(db);
                if (entry != null)
                {
                    List<string> deleteKeys = new List<string>();

                    foreach (var s in entry.Strings)
                    {
                        if (s.Key.IndexOf(KeePassHttpExt.ASSOCIATE_KEY_PREFIX) == 0)
                        {
                            deleteKeys.Add(s.Key);
                        }
                    }


                    if (deleteKeys.Count > 0)
                    {
                        PwObjectList<PwEntry> m_vHistory = entry.History.CloneDeep();
                        entry.History = m_vHistory;
                        entry.CreateBackup(null);

                        foreach (var key in deleteKeys)
                        {
                            entry.Strings.Remove(key);
                        }

                        entry.Touch(true);
                        KeePass.Program.MainForm.UpdateUI(false, null, true, db.RootGroup, true, null, true);
                        MessageBox.Show(
                            String.Format("成功从 KeePassHttp Settings 条目中删除 {0} 个共享密钥", deleteKeys.Count.ToString()),
                            String.Format("成功删除 {0} 个共享密钥", deleteKeys.Count.ToString()),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "在 KeePassHttp Settings 条目中没有找到共享密钥", "没有找到共享密钥",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show("没有在当前数据库中找到 KeePassHttp Settings 条目！", "KeePassHttp Settings 条目不可用！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("当前数据库已锁定，请解锁当前数据库或选择另一个已解锁的数据库。", "数据库已锁定！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removePermissionsButton_Click(object sender, EventArgs e)
        {
            if (KeePass.Program.MainForm.DocumentManager.ActiveDatabase.IsOpen)
            {
                PwDatabase db = KeePass.Program.MainForm.DocumentManager.ActiveDatabase;

                uint counter = 0;
                var entries = db.RootGroup.GetEntries(true);

                if (entries.Count() > 999)
                {
                    MessageBox.Show(
                        String.Format("检测到 {0} 个条目，删除操作需要花费一些时间。\n\n删除完成后我会通知您。", entries.Count().ToString()),
                        String.Format("检测到 {0} 个条目", entries.Count().ToString()),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                foreach (var entry in entries)
                {
                    foreach (var str in entry.Strings)
                    {
                        if (str.Key == KeePassHttpExt.KEEPASSHTTP_NAME)
                        {
                            PwObjectList<PwEntry> m_vHistory = entry.History.CloneDeep();
                            entry.History = m_vHistory;
                            entry.CreateBackup(null);

                            entry.Strings.Remove(str.Key);

                            entry.Touch(true);

                            counter += 1;

                            break;
                        }
                    }
                }

                if (counter > 0)
                {
                    KeePass.Program.MainForm.UpdateUI(false, null, true, db.RootGroup, true, null, true);
                    MessageBox.Show(
                        String.Format("成功删除 {0} 个条目中的权限字段", counter.ToString()),
                        String.Format("成功删除 {0} 个共享密钥", counter.ToString()),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "当前数据没有包含权限字段的条目",
                        "找不到具有权限字段的条目",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show("当前数据库已锁定，请解锁当前数据库或选择另一个已解锁的数据库。", "数据库已锁定！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void portNumber_ValueChanged(object sender, EventArgs e)
        {
            SetRestartRequired();
        }

        private void hostName_TextChanged(object sender, EventArgs e)
        {
            SetRestartRequired();
        }

        private void SetRestartRequired()
        {
            _restartRequired = (_config.ListenerPort != portNumber.Value) || (_config.ListenerHost != hostName.Text);
        }

        private void returnStringFieldsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.returnStringFieldsWithKphOnlyCheckBox.Enabled = this.returnStringFieldsCheckbox.Checked;
        }
    }
}
