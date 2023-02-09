namespace KeeTrayTOTP
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.TabControlSettings = new System.Windows.Forms.TabControl();
            this.TabPageContextMenus = new System.Windows.Forms.TabPage();
            this.GroupBoxTrayMenu = new System.Windows.Forms.GroupBox();
            this.CheckBoxEnableLegacyTrayMenuProvider = new System.Windows.Forms.CheckBox();
            this.CheckBoxTrimTrayText = new System.Windows.Forms.CheckBox();
            this.CheckBoxShowTOTPEntriesTrayMenu = new System.Windows.Forms.CheckBox();
            this.LabelDescriptionTrayMenu = new System.Windows.Forms.Label();
            this.GroupBoxEntryMenu = new System.Windows.Forms.GroupBox();
            this.CheckBoxShowSetupTOTPEntryMenu = new System.Windows.Forms.CheckBox();
            this.CheckBoxShowCopyTOTPEntryMenu = new System.Windows.Forms.CheckBox();
            this.LabelDescriptionEntryMenu = new System.Windows.Forms.Label();
            this.TabPageEntryList = new System.Windows.Forms.TabPage();
            this.GroupBoxTOTPColumn = new System.Windows.Forms.GroupBox();
            this.CheckBoxTOTPColumnClipboard = new System.Windows.Forms.CheckBox();
            this.LabelDescriptionTOTPColumnTimer = new System.Windows.Forms.Label();
            this.CheckBoxTOTPColumnTimer = new System.Windows.Forms.CheckBox();
            this.TabPageAutoType = new System.Windows.Forms.TabPage();
            this.CheckBoxAutoType = new System.Windows.Forms.CheckBox();
            this.GroupBoxAutoType = new System.Windows.Forms.GroupBox();
            this.TextBoxAutoTypeFieldName = new System.Windows.Forms.TextBox();
            this.CheckBoxAutoTypeFieldRename = new System.Windows.Forms.CheckBox();
            this.CheckBoxAutoTypeFieldName = new System.Windows.Forms.CheckBox();
            this.LabelDescriptionAutoType = new System.Windows.Forms.Label();
            this.TabPageSync = new System.Windows.Forms.TabPage();
            this.GroupBoxTimeCorrectonList = new System.Windows.Forms.GroupBox();
            this.ToolStripTimeCorrectionList = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonAddTimeCorrection = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonPropertiesTimeCorrection = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRemoveTimeCorrection = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonRefreshTimeCorrection = new System.Windows.Forms.ToolStripButton();
            this.ListViewTimeCorrectionList = new System.Windows.Forms.ListView();
            this.ColumnTimeCorrection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTimeSpan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageListTimeCorrectionList = new System.Windows.Forms.ImageList(this.components);
            this.CheckBoxTimeCorrection = new System.Windows.Forms.CheckBox();
            this.GroupBoxTimeCorrection = new System.Windows.Forms.GroupBox();
            this.LabelTimeCorrectionMinutes = new System.Windows.Forms.Label();
            this.LabelTimeCorrectionInterval = new System.Windows.Forms.Label();
            this.NumericTimeCorrectionInterval = new System.Windows.Forms.NumericUpDown();
            this.LabelTimeCorrection = new System.Windows.Forms.Label();
            this.TabPageStorage = new System.Windows.Forms.TabPage();
            this.GroupBoxTOTPSettings = new System.Windows.Forms.GroupBox();
            this.LabelTOTPSettingsStringName = new System.Windows.Forms.Label();
            this.ComboBoxTOTPSettingsStringName = new System.Windows.Forms.ComboBox();
            this.LabelDescriptionTOTPSettings = new System.Windows.Forms.Label();
            this.GroupBoxTOTPSeed = new System.Windows.Forms.GroupBox();
            this.LabelTOTPSeedStringName = new System.Windows.Forms.Label();
            this.ComboBoxTOTPSeedStringName = new System.Windows.Forms.ComboBox();
            this.LabelDescriptionTOTPSeed = new System.Windows.Forms.Label();
            this.LabelRestartRequired = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.HelpProviderSettings = new System.Windows.Forms.HelpProvider();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.WorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.WorkerSave = new System.ComponentModel.BackgroundWorker();
            this.ErrorProviderSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.WorkerReset = new System.ComponentModel.BackgroundWorker();
            this.TabControlSettings.SuspendLayout();
            this.TabPageContextMenus.SuspendLayout();
            this.GroupBoxTrayMenu.SuspendLayout();
            this.GroupBoxEntryMenu.SuspendLayout();
            this.TabPageEntryList.SuspendLayout();
            this.GroupBoxTOTPColumn.SuspendLayout();
            this.TabPageAutoType.SuspendLayout();
            this.GroupBoxAutoType.SuspendLayout();
            this.TabPageSync.SuspendLayout();
            this.GroupBoxTimeCorrectonList.SuspendLayout();
            this.ToolStripTimeCorrectionList.SuspendLayout();
            this.GroupBoxTimeCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTimeCorrectionInterval)).BeginInit();
            this.TabPageStorage.SuspendLayout();
            this.GroupBoxTOTPSettings.SuspendLayout();
            this.GroupBoxTOTPSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderSettings)).BeginInit();
            this.SuspendLayout();
            //
            // TabControlSettings
            //
            this.TabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlSettings.Controls.Add(this.TabPageContextMenus);
            this.TabControlSettings.Controls.Add(this.TabPageEntryList);
            this.TabControlSettings.Controls.Add(this.TabPageAutoType);
            this.TabControlSettings.Controls.Add(this.TabPageSync);
            this.TabControlSettings.Controls.Add(this.TabPageStorage);
            this.TabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedIndex = 0;
            this.TabControlSettings.Size = new System.Drawing.Size(362, 341);
            this.TabControlSettings.TabIndex = 0;
            this.TabControlSettings.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlSettings_Selected);
            //
            // TabPageContextMenus
            //
            this.TabPageContextMenus.Controls.Add(this.GroupBoxTrayMenu);
            this.TabPageContextMenus.Controls.Add(this.GroupBoxEntryMenu);
            this.TabPageContextMenus.Location = new System.Drawing.Point(4, 22);
            this.TabPageContextMenus.Name = "TabPageContextMenus";
            this.TabPageContextMenus.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageContextMenus.Size = new System.Drawing.Size(354, 315);
            this.TabPageContextMenus.TabIndex = 0;
            this.TabPageContextMenus.Text = "上下文菜单";
            this.TabPageContextMenus.UseVisualStyleBackColor = true;
            //
            // GroupBoxTrayMenu
            //
            this.GroupBoxTrayMenu.Controls.Add(this.LabelRestartRequired);
            this.GroupBoxTrayMenu.Controls.Add(this.CheckBoxEnableLegacyTrayMenuProvider);
            this.GroupBoxTrayMenu.Controls.Add(this.CheckBoxTrimTrayText);
            this.GroupBoxTrayMenu.Controls.Add(this.CheckBoxShowTOTPEntriesTrayMenu);
            this.GroupBoxTrayMenu.Controls.Add(this.LabelDescriptionTrayMenu);
            this.GroupBoxTrayMenu.Location = new System.Drawing.Point(10, 143);
            this.GroupBoxTrayMenu.Name = "GroupBoxTrayMenu";
            this.GroupBoxTrayMenu.Size = new System.Drawing.Size(335, 160);
            this.GroupBoxTrayMenu.TabIndex = 1;
            this.GroupBoxTrayMenu.TabStop = false;
            this.GroupBoxTrayMenu.Text = "托盘菜单";
            //
            // CheckBoxEnableLegacyTrayMenuProvider
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxEnableLegacyTrayMenuProvider, "Enable the old behavior for providing tray menu items. (All keepass entries will " +
        "be available in the root tray menu. This is not recommended!)");
            this.CheckBoxEnableLegacyTrayMenuProvider.Location = new System.Drawing.Point(19, 125);
            this.CheckBoxEnableLegacyTrayMenuProvider.Name = "CheckBoxEnableLegacyTrayMenuProvider";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxEnableLegacyTrayMenuProvider, true);
            this.CheckBoxEnableLegacyTrayMenuProvider.Size = new System.Drawing.Size(300, 31);
            this.CheckBoxEnableLegacyTrayMenuProvider.TabIndex = 3;
            this.CheckBoxEnableLegacyTrayMenuProvider.Text = "启用旧版托盘上下文菜单（需要重启 KeePass，不建议！）";
            this.CheckBoxEnableLegacyTrayMenuProvider.UseVisualStyleBackColor = true;
            this.CheckBoxEnableLegacyTrayMenuProvider.CheckedChanged += new System.EventHandler(this.CalculateRefreshNoticeVisibility);
            //
            // CheckBoxTrimTrayText
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxTrimTrayText, "Control the visibility of the menu items that appear in the tray menu. This also " +
        "deactivate the search for entries that contain seeds.");
            this.CheckBoxTrimTrayText.Location = new System.Drawing.Point(19, 93);
            this.CheckBoxTrimTrayText.Name = "CheckBoxTrimTrayText";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxTrimTrayText, true);
            this.CheckBoxTrimTrayText.Size = new System.Drawing.Size(300, 31);
            this.CheckBoxTrimTrayText.TabIndex = 2;
            this.CheckBoxTrimTrayText.Text = "如果条目的标题加上用户名超过 25 个字符，则隐藏用户名";
            this.CheckBoxTrimTrayText.UseVisualStyleBackColor = true;
            //
            // CheckBoxShowTOTPEntriesTrayMenu
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxShowTOTPEntriesTrayMenu, "Control the visibility of the menu items that appear in the tray menu. This also " +
        "deactivate the search for entries that contain seeds.");
            this.CheckBoxShowTOTPEntriesTrayMenu.Location = new System.Drawing.Point(19, 70);
            this.CheckBoxShowTOTPEntriesTrayMenu.Name = "CheckBoxShowTOTPEntriesTrayMenu";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxShowTOTPEntriesTrayMenu, true);
            this.CheckBoxShowTOTPEntriesTrayMenu.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxShowTOTPEntriesTrayMenu.TabIndex = 1;
            this.CheckBoxShowTOTPEntriesTrayMenu.Text = "显示启用 TOTP 的条目";
            this.CheckBoxShowTOTPEntriesTrayMenu.UseVisualStyleBackColor = true;
            this.CheckBoxShowTOTPEntriesTrayMenu.CheckedChanged += new System.EventHandler(this.CalculateRefreshNoticeVisibility);
            //
            // LabelDescriptionTrayMenu
            //
            this.LabelDescriptionTrayMenu.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionTrayMenu.Name = "LabelDescriptionTrayMenu";
            this.LabelDescriptionTrayMenu.Size = new System.Drawing.Size(303, 38);
            this.LabelDescriptionTrayMenu.TabIndex = 0;
            this.LabelDescriptionTrayMenu.Text = "鼠标右键单击 KeePass 托盘图标时，在上下文菜单中显示 TOTP 插件选项";
            //
            // GroupBoxEntryMenu
            //
            this.GroupBoxEntryMenu.Controls.Add(this.CheckBoxShowSetupTOTPEntryMenu);
            this.GroupBoxEntryMenu.Controls.Add(this.CheckBoxShowCopyTOTPEntryMenu);
            this.GroupBoxEntryMenu.Controls.Add(this.LabelDescriptionEntryMenu);
            this.GroupBoxEntryMenu.Location = new System.Drawing.Point(10, 10);
            this.GroupBoxEntryMenu.Name = "GroupBoxEntryMenu";
            this.GroupBoxEntryMenu.Size = new System.Drawing.Size(335, 125);
            this.GroupBoxEntryMenu.TabIndex = 0;
            this.GroupBoxEntryMenu.TabStop = false;
            this.GroupBoxEntryMenu.Text = "条目菜单";
            //
            // CheckBoxShowSetupTOTPEntryMenu
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxShowSetupTOTPEntryMenu, "控制 \'配置 TOTP\' 选项在上下文菜单中是否显示" +
        "nu \"Selected Entries\".");
            this.CheckBoxShowSetupTOTPEntryMenu.Location = new System.Drawing.Point(19, 95);
            this.CheckBoxShowSetupTOTPEntryMenu.Name = "CheckBoxShowSetupTOTPEntryMenu";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxShowSetupTOTPEntryMenu, true);
            this.CheckBoxShowSetupTOTPEntryMenu.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxShowSetupTOTPEntryMenu.TabIndex = 2;
            this.CheckBoxShowSetupTOTPEntryMenu.Text = "显示 \'配置 TOTP\' 选项";
            this.CheckBoxShowSetupTOTPEntryMenu.UseVisualStyleBackColor = true;
            //
            // CheckBoxShowCopyTOTPEntryMenu
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxShowCopyTOTPEntryMenu, "控制 \'复制 TOTP\' 选项在上下文菜单中是否显示");
            this.CheckBoxShowCopyTOTPEntryMenu.Location = new System.Drawing.Point(19, 70);
            this.CheckBoxShowCopyTOTPEntryMenu.Name = "CheckBoxShowCopyTOTPEntryMenu";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxShowCopyTOTPEntryMenu, true);
            this.CheckBoxShowCopyTOTPEntryMenu.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxShowCopyTOTPEntryMenu.TabIndex = 1;
            this.CheckBoxShowCopyTOTPEntryMenu.Text = "显示 \'复制 TOTP\' 选项";
            this.CheckBoxShowCopyTOTPEntryMenu.UseVisualStyleBackColor = true;
            //
            // LabelDescriptionEntryMenu
            //
            this.LabelDescriptionEntryMenu.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionEntryMenu.Name = "LabelDescriptionEntryMenu";
            this.LabelDescriptionEntryMenu.Size = new System.Drawing.Size(303, 38);
            this.LabelDescriptionEntryMenu.TabIndex = 0;
            this.LabelDescriptionEntryMenu.Text = "鼠标右键单击条目或条目列表区域时，在上下文菜单中显示 TOTP 插件选项";
            //
            // TabPageEntryList
            //
            this.TabPageEntryList.Controls.Add(this.GroupBoxTOTPColumn);
            this.TabPageEntryList.Location = new System.Drawing.Point(4, 22);
            this.TabPageEntryList.Name = "TabPageEntryList";
            this.TabPageEntryList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEntryList.Size = new System.Drawing.Size(354, 315);
            this.TabPageEntryList.TabIndex = 3;
            this.TabPageEntryList.Text = "条目列表";
            this.TabPageEntryList.UseVisualStyleBackColor = true;
            //
            // GroupBoxTOTPColumn
            //
            this.GroupBoxTOTPColumn.Controls.Add(this.CheckBoxTOTPColumnClipboard);
            this.GroupBoxTOTPColumn.Controls.Add(this.LabelDescriptionTOTPColumnTimer);
            this.GroupBoxTOTPColumn.Controls.Add(this.CheckBoxTOTPColumnTimer);
            this.GroupBoxTOTPColumn.Location = new System.Drawing.Point(10, 10);
            this.GroupBoxTOTPColumn.Name = "GroupBoxTOTPColumn";
            this.GroupBoxTOTPColumn.Size = new System.Drawing.Size(335, 125);
            this.GroupBoxTOTPColumn.TabIndex = 0;
            this.GroupBoxTOTPColumn.TabStop = false;
            this.GroupBoxTOTPColumn.Text = "Custom Column TOTP";
            //
            // CheckBoxTOTPColumnClipboard
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxTOTPColumnClipboard, "控制左键双击 TOTP 列时是否将当前的 TOTP 令牌复制到剪切板。");
            this.CheckBoxTOTPColumnClipboard.Location = new System.Drawing.Point(19, 70);
            this.CheckBoxTOTPColumnClipboard.Name = "CheckBoxTOTPColumnClipboard";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxTOTPColumnClipboard, true);
            this.CheckBoxTOTPColumnClipboard.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxTOTPColumnClipboard.TabIndex = 1;
            this.CheckBoxTOTPColumnClipboard.Text = "启用 TOTP 复制功能（左键双击 TOTP 列）";
            this.CheckBoxTOTPColumnClipboard.UseVisualStyleBackColor = true;
            //
            // LabelDescriptionTOTPColumnTimer
            //
            this.LabelDescriptionTOTPColumnTimer.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionTOTPColumnTimer.Name = "LabelDescriptionTOTPColumnTimer";
            this.LabelDescriptionTOTPColumnTimer.Size = new System.Drawing.Size(303, 38);
            this.LabelDescriptionTOTPColumnTimer.TabIndex = 0;
            this.LabelDescriptionTOTPColumnTimer.Text = "在使用列菜单（视图）时，TOTP 列显示当前的 TOTP 令牌";
            //
            // CheckBoxTOTPColumnTimer
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxTOTPColumnTimer, "控制 TOTP 倒计时的可见性");
            this.CheckBoxTOTPColumnTimer.Location = new System.Drawing.Point(19, 95);
            this.CheckBoxTOTPColumnTimer.Name = "CheckBoxTOTPColumnTimer";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxTOTPColumnTimer, true);
            this.CheckBoxTOTPColumnTimer.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxTOTPColumnTimer.TabIndex = 2;
            this.CheckBoxTOTPColumnTimer.Text = "在 TOTP 列中的右侧显示倒计时";
            this.CheckBoxTOTPColumnTimer.UseVisualStyleBackColor = true;
            //
            // TabPageAutoType
            //
            this.TabPageAutoType.Controls.Add(this.CheckBoxAutoType);
            this.TabPageAutoType.Controls.Add(this.GroupBoxAutoType);
            this.TabPageAutoType.Location = new System.Drawing.Point(4, 22);
            this.TabPageAutoType.Name = "TabPageAutoType";
            this.TabPageAutoType.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAutoType.Size = new System.Drawing.Size(354, 315);
            this.TabPageAutoType.TabIndex = 4;
            this.TabPageAutoType.Text = "自动输入";
            this.TabPageAutoType.UseVisualStyleBackColor = true;
            //
            // CheckBoxAutoType
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxAutoType, resources.GetString("CheckBoxAutoType.HelpString"));
            this.CheckBoxAutoType.Location = new System.Drawing.Point(29, 20);
            this.CheckBoxAutoType.Name = "CheckBoxAutoType";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxAutoType, true);
            this.CheckBoxAutoType.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxAutoType.TabIndex = 0;
            this.CheckBoxAutoType.Text = "启用 TOTP 令牌自动输入功能";
            this.CheckBoxAutoType.UseVisualStyleBackColor = true;
            this.CheckBoxAutoType.CheckedChanged += new System.EventHandler(this.CheckBoxAutoType_CheckedChanged);
            //
            // GroupBoxAutoType
            //
            this.GroupBoxAutoType.Controls.Add(this.TextBoxAutoTypeFieldName);
            this.GroupBoxAutoType.Controls.Add(this.CheckBoxAutoTypeFieldRename);
            this.GroupBoxAutoType.Controls.Add(this.CheckBoxAutoTypeFieldName);
            this.GroupBoxAutoType.Controls.Add(this.LabelDescriptionAutoType);
            this.GroupBoxAutoType.Enabled = false;
            this.GroupBoxAutoType.Location = new System.Drawing.Point(10, 45);
            this.GroupBoxAutoType.Name = "GroupBoxAutoType";
            this.GroupBoxAutoType.Size = new System.Drawing.Size(335, 120);
            this.GroupBoxAutoType.TabIndex = 1;
            this.GroupBoxAutoType.TabStop = false;
            this.GroupBoxAutoType.Text = "自动输入功能";
            //
            // TextBoxAutoTypeFieldName
            //
            this.TextBoxAutoTypeFieldName.Enabled = false;
            this.HelpProviderSettings.SetHelpString(this.TextBoxAutoTypeFieldName, "自定义自动输入中 TOTP 对应的变量名。");
            this.TextBoxAutoTypeFieldName.Location = new System.Drawing.Point(130, 64);
            this.TextBoxAutoTypeFieldName.Name = "TextBoxAutoTypeFieldName";
            this.HelpProviderSettings.SetShowHelp(this.TextBoxAutoTypeFieldName, true);
            this.TextBoxAutoTypeFieldName.Size = new System.Drawing.Size(173, 21);
            this.TextBoxAutoTypeFieldName.TabIndex = 2;
            this.TextBoxAutoTypeFieldName.Tag = "";
            //
            // CheckBoxAutoTypeFieldRename
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxAutoTypeFieldRename, "如果选中，则会将对所有的旧变量名进行更新");
            this.CheckBoxAutoTypeFieldRename.Location = new System.Drawing.Point(30, 90);
            this.CheckBoxAutoTypeFieldRename.Name = "CheckBoxAutoTypeFieldRename";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxAutoTypeFieldRename, true);
            this.CheckBoxAutoTypeFieldRename.Size = new System.Drawing.Size(273, 17);
            this.CheckBoxAutoTypeFieldRename.TabIndex = 3;
            this.CheckBoxAutoTypeFieldRename.Text = "替换已存在的引用（推荐）";
            this.CheckBoxAutoTypeFieldRename.UseVisualStyleBackColor = true;
            this.CheckBoxAutoTypeFieldRename.CheckedChanged += new System.EventHandler(this.CheckBoxAutoTypeFieldRename_CheckedChanged);
            //
            // CheckBoxAutoTypeFieldName
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxAutoTypeFieldName, "自定义 TOTP 令牌在自动输入的变量名。");
            this.CheckBoxAutoTypeFieldName.Location = new System.Drawing.Point(30, 66);
            this.CheckBoxAutoTypeFieldName.Name = "CheckBoxAutoTypeFieldName";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxAutoTypeFieldName, true);
            this.CheckBoxAutoTypeFieldName.Size = new System.Drawing.Size(100, 17);
            this.CheckBoxAutoTypeFieldName.TabIndex = 1;
            this.CheckBoxAutoTypeFieldName.Text = "自定义变量名：";
            this.CheckBoxAutoTypeFieldName.UseVisualStyleBackColor = true;
            this.CheckBoxAutoTypeFieldName.CheckedChanged += new System.EventHandler(this.CheckBoxAutoTypeFieldName_CheckedChanged);
            //
            // LabelDescriptionAutoType
            //
            this.LabelDescriptionAutoType.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionAutoType.Name = "LabelDescriptionAutoType";
            this.LabelDescriptionAutoType.Size = new System.Drawing.Size(303, 38);
            this.LabelDescriptionAutoType.TabIndex = 0;
            this.LabelDescriptionAutoType.Text = "自动输入功能通过模拟键盘按键将信息（如：密码）直接写入表单中。";
            //
            // TabPageSync
            //
            this.TabPageSync.Controls.Add(this.GroupBoxTimeCorrectonList);
            this.TabPageSync.Controls.Add(this.CheckBoxTimeCorrection);
            this.TabPageSync.Controls.Add(this.GroupBoxTimeCorrection);
            this.TabPageSync.Location = new System.Drawing.Point(4, 22);
            this.TabPageSync.Name = "TabPageSync";
            this.TabPageSync.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSync.Size = new System.Drawing.Size(354, 315);
            this.TabPageSync.TabIndex = 5;
            this.TabPageSync.Tag = "";
            this.TabPageSync.Text = "时间校正";
            this.TabPageSync.UseVisualStyleBackColor = true;
            //
            // GroupBoxTimeCorrectonList
            //
            this.GroupBoxTimeCorrectonList.Controls.Add(this.ToolStripTimeCorrectionList);
            this.GroupBoxTimeCorrectonList.Controls.Add(this.ListViewTimeCorrectionList);
            this.GroupBoxTimeCorrectonList.Enabled = false;
            this.GroupBoxTimeCorrectonList.Location = new System.Drawing.Point(10, 153);
            this.GroupBoxTimeCorrectonList.Name = "GroupBoxTimeCorrectonList";
            this.GroupBoxTimeCorrectonList.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.GroupBoxTimeCorrectonList.Size = new System.Drawing.Size(334, 144);
            this.GroupBoxTimeCorrectonList.TabIndex = 2;
            this.GroupBoxTimeCorrectonList.TabStop = false;
            this.GroupBoxTimeCorrectonList.Text = "时间校正列表";
            //
            // ToolStripTimeCorrectionList
            //
            this.ToolStripTimeCorrectionList.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolStripTimeCorrectionList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTimeCorrectionList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonAddTimeCorrection,
            this.ToolStripButtonPropertiesTimeCorrection,
            this.ToolStripButtonRemoveTimeCorrection,
            this.ToolStripSeparator1,
            this.ToolStripButtonRefreshTimeCorrection});
            this.ToolStripTimeCorrectionList.Location = new System.Drawing.Point(303, 19);
            this.ToolStripTimeCorrectionList.Name = "ToolStripTimeCorrectionList";
            this.ToolStripTimeCorrectionList.Size = new System.Drawing.Size(24, 118);
            this.ToolStripTimeCorrectionList.TabIndex = 1;
            this.ToolStripTimeCorrectionList.Text = "toolStrip1";
            //
            // ToolStripButtonAddTimeCorrection
            //
            this.ToolStripButtonAddTimeCorrection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAddTimeCorrection.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonAddTimeCorrection.Image")));
            this.ToolStripButtonAddTimeCorrection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAddTimeCorrection.Margin = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.ToolStripButtonAddTimeCorrection.Name = "ToolStripButtonAddTimeCorrection";
            this.ToolStripButtonAddTimeCorrection.Size = new System.Drawing.Size(21, 20);
            this.ToolStripButtonAddTimeCorrection.Text = "添加";
            this.ToolStripButtonAddTimeCorrection.Click += new System.EventHandler(this.ToolStripButtonAddTimeCorrection_Click);
            //
            // ToolStripButtonPropertiesTimeCorrection
            //
            this.ToolStripButtonPropertiesTimeCorrection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonPropertiesTimeCorrection.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonPropertiesTimeCorrection.Image")));
            this.ToolStripButtonPropertiesTimeCorrection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonPropertiesTimeCorrection.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ToolStripButtonPropertiesTimeCorrection.Name = "ToolStripButtonPropertiesTimeCorrection";
            this.ToolStripButtonPropertiesTimeCorrection.Size = new System.Drawing.Size(21, 20);
            this.ToolStripButtonPropertiesTimeCorrection.Text = "编辑";
            this.ToolStripButtonPropertiesTimeCorrection.Click += new System.EventHandler(this.ToolStripButtonPropertiesTimeCorrection_Click);
            //
            // ToolStripButtonRemoveTimeCorrection
            //
            this.ToolStripButtonRemoveTimeCorrection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRemoveTimeCorrection.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRemoveTimeCorrection.Image")));
            this.ToolStripButtonRemoveTimeCorrection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRemoveTimeCorrection.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ToolStripButtonRemoveTimeCorrection.Name = "ToolStripButtonRemoveTimeCorrection";
            this.ToolStripButtonRemoveTimeCorrection.Size = new System.Drawing.Size(21, 20);
            this.ToolStripButtonRemoveTimeCorrection.Text = "删除";
            this.ToolStripButtonRemoveTimeCorrection.Click += new System.EventHandler(this.ToolStripButtonRemoveTimeCorrection_Click);
            //
            // ToolStripSeparator1
            //
            this.ToolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            //
            // ToolStripButtonRefreshTimeCorrection
            //
            this.ToolStripButtonRefreshTimeCorrection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRefreshTimeCorrection.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRefreshTimeCorrection.Image")));
            this.ToolStripButtonRefreshTimeCorrection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRefreshTimeCorrection.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ToolStripButtonRefreshTimeCorrection.Name = "ToolStripButtonRefreshTimeCorrection";
            this.ToolStripButtonRefreshTimeCorrection.Size = new System.Drawing.Size(21, 20);
            this.ToolStripButtonRefreshTimeCorrection.Text = "刷新时差";
            this.ToolStripButtonRefreshTimeCorrection.Click += new System.EventHandler(this.ToolStripButtonRefreshTimeCorrection_Click);
            //
            // ListViewTimeCorrectionList
            //
            this.ListViewTimeCorrectionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewTimeCorrectionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTimeCorrection,
            this.ColumnTimeSpan});
            this.ListViewTimeCorrectionList.FullRowSelect = true;
            this.HelpProviderSettings.SetHelpString(this.ListViewTimeCorrectionList, "这里列出了校正时差的URL。即使在 TOTP 设置中指定了 URL，也必须在该列表中才会生效。");
            this.ListViewTimeCorrectionList.Location = new System.Drawing.Point(7, 20);
            this.ListViewTimeCorrectionList.MultiSelect = false;
            this.ListViewTimeCorrectionList.Name = "ListViewTimeCorrectionList";
            this.HelpProviderSettings.SetShowHelp(this.ListViewTimeCorrectionList, true);
            this.ListViewTimeCorrectionList.Size = new System.Drawing.Size(293, 116);
            this.ListViewTimeCorrectionList.SmallImageList = this.ImageListTimeCorrectionList;
            this.ListViewTimeCorrectionList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewTimeCorrectionList.TabIndex = 0;
            this.ListViewTimeCorrectionList.UseCompatibleStateImageBehavior = false;
            this.ListViewTimeCorrectionList.View = System.Windows.Forms.View.Details;
            this.ListViewTimeCorrectionList.DoubleClick += new System.EventHandler(this.ListViewTimeCorrectionList_DoubleClick);
            //
            // ColumnTimeCorrection
            //
            this.ColumnTimeCorrection.Text = "时间校正";
            this.ColumnTimeCorrection.Width = 144;
            //
            // ColumnTimeSpan
            //
            this.ColumnTimeSpan.Text = "时差";
            this.ColumnTimeSpan.Width = 120;
            //
            // ImageListTimeCorrectionList
            //
            this.ImageListTimeCorrectionList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListTimeCorrectionList.ImageStream")));
            this.ImageListTimeCorrectionList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListTimeCorrectionList.Images.SetKeyName(0, "accept.png");
            this.ImageListTimeCorrectionList.Images.SetKeyName(1, "error.png");
            this.ImageListTimeCorrectionList.Images.SetKeyName(2, "exclamation.png");
            this.ImageListTimeCorrectionList.Images.SetKeyName(3, "hourglass.png");
            //
            // CheckBoxTimeCorrection
            //
            this.HelpProviderSettings.SetHelpString(this.CheckBoxTimeCorrection, resources.GetString("CheckBoxTimeCorrection.HelpString"));
            this.CheckBoxTimeCorrection.Location = new System.Drawing.Point(29, 20);
            this.CheckBoxTimeCorrection.Name = "CheckBoxTimeCorrection";
            this.HelpProviderSettings.SetShowHelp(this.CheckBoxTimeCorrection, true);
            this.CheckBoxTimeCorrection.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxTimeCorrection.TabIndex = 0;
            this.CheckBoxTimeCorrection.Text = "启用生成 TOTP 的时间校正功能";
            this.CheckBoxTimeCorrection.UseVisualStyleBackColor = true;
            this.CheckBoxTimeCorrection.CheckedChanged += new System.EventHandler(this.CheckBoxTimeCorrection_CheckedChanged);
            //
            // GroupBoxTimeCorrection
            //
            this.GroupBoxTimeCorrection.Controls.Add(this.LabelTimeCorrectionMinutes);
            this.GroupBoxTimeCorrection.Controls.Add(this.LabelTimeCorrectionInterval);
            this.GroupBoxTimeCorrection.Controls.Add(this.NumericTimeCorrectionInterval);
            this.GroupBoxTimeCorrection.Controls.Add(this.LabelTimeCorrection);
            this.GroupBoxTimeCorrection.Enabled = false;
            this.GroupBoxTimeCorrection.Location = new System.Drawing.Point(10, 45);
            this.GroupBoxTimeCorrection.Name = "GroupBoxTimeCorrection";
            this.GroupBoxTimeCorrection.Size = new System.Drawing.Size(335, 100);
            this.GroupBoxTimeCorrection.TabIndex = 1;
            this.GroupBoxTimeCorrection.TabStop = false;
            this.GroupBoxTimeCorrection.Text = "时间校正";
            //
            // LabelTimeCorrectionMinutes
            //
            this.HelpProviderSettings.SetHelpString(this.LabelTimeCorrectionMinutes, "设置时间校正间隔。（打开数据库后立即校正一次，然后每隔指定时间校正一次）");
            this.LabelTimeCorrectionMinutes.Location = new System.Drawing.Point(226, 64);
            this.LabelTimeCorrectionMinutes.Name = "LabelTimeCorrectionMinutes";
            this.HelpProviderSettings.SetShowHelp(this.LabelTimeCorrectionMinutes, true);
            this.LabelTimeCorrectionMinutes.Size = new System.Drawing.Size(78, 21);
            this.LabelTimeCorrectionMinutes.TabIndex = 3;
            this.LabelTimeCorrectionMinutes.Text = "分钟";
            this.LabelTimeCorrectionMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // LabelTimeCorrectionInterval
            //
            this.HelpProviderSettings.SetHelpString(this.LabelTimeCorrectionInterval, "设置时间校正间隔。（打开数据库后立即校正一次，然后每隔指定时间校正一次）");
            this.LabelTimeCorrectionInterval.Location = new System.Drawing.Point(30, 64);
            this.LabelTimeCorrectionInterval.Name = "LabelTimeCorrectionInterval";
            this.HelpProviderSettings.SetShowHelp(this.LabelTimeCorrectionInterval, true);
            this.LabelTimeCorrectionInterval.Size = new System.Drawing.Size(107, 21);
            this.LabelTimeCorrectionInterval.TabIndex = 1;
            this.LabelTimeCorrectionInterval.Text = "校正间隔：";
            this.LabelTimeCorrectionInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // NumericTimeCorrectionInterval
            //
            this.HelpProviderSettings.SetHelpString(this.NumericTimeCorrectionInterval, "设置时间校正间隔。（打开数据库后立即校正一次，然后每隔指定时间校正一次）");
            this.NumericTimeCorrectionInterval.Location = new System.Drawing.Point(143, 64);
            this.NumericTimeCorrectionInterval.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.NumericTimeCorrectionInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericTimeCorrectionInterval.Name = "NumericTimeCorrectionInterval";
            this.HelpProviderSettings.SetShowHelp(this.NumericTimeCorrectionInterval, true);
            this.NumericTimeCorrectionInterval.Size = new System.Drawing.Size(75, 21);
            this.NumericTimeCorrectionInterval.TabIndex = 2;
            this.NumericTimeCorrectionInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            //
            // LabelTimeCorrection
            //
            this.LabelTimeCorrection.Location = new System.Drawing.Point(16, 24);
            this.LabelTimeCorrection.Name = "LabelTimeCorrection";
            this.LabelTimeCorrection.Size = new System.Drawing.Size(303, 38);
            this.LabelTimeCorrection.TabIndex = 0;
            this.LabelTimeCorrection.Text = "时间校正用于确保生成 TOTP 时间和服务器一致";
            //
            // TabPageStorage
            //
            this.TabPageStorage.Controls.Add(this.GroupBoxTOTPSettings);
            this.TabPageStorage.Controls.Add(this.GroupBoxTOTPSeed);
            this.TabPageStorage.Location = new System.Drawing.Point(4, 22);
            this.TabPageStorage.Name = "TabPageStorage";
            this.TabPageStorage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageStorage.Size = new System.Drawing.Size(354, 315);
            this.TabPageStorage.TabIndex = 1;
            this.TabPageStorage.Text = "存储";
            this.TabPageStorage.UseVisualStyleBackColor = true;
            //
            // GroupBoxTOTPSettings
            //
            this.GroupBoxTOTPSettings.Controls.Add(this.LabelTOTPSettingsStringName);
            this.GroupBoxTOTPSettings.Controls.Add(this.ComboBoxTOTPSettingsStringName);
            this.GroupBoxTOTPSettings.Controls.Add(this.LabelDescriptionTOTPSettings);
            this.GroupBoxTOTPSettings.Location = new System.Drawing.Point(10, 128);
            this.GroupBoxTOTPSettings.Name = "GroupBoxTOTPSettings";
            this.GroupBoxTOTPSettings.Size = new System.Drawing.Size(335, 110);
            this.GroupBoxTOTPSettings.TabIndex = 1;
            this.GroupBoxTOTPSettings.TabStop = false;
            this.GroupBoxTOTPSettings.Text = "TOTP 配置";
            //
            // LabelTOTPSettingsStringName
            //
            this.HelpProviderSettings.SetHelpString(this.LabelTOTPSettingsStringName, resources.GetString("LabelTOTPSettingsStringName.HelpString"));
            this.LabelTOTPSettingsStringName.Location = new System.Drawing.Point(27, 74);
            this.LabelTOTPSettingsStringName.Name = "LabelTOTPSettingsStringName";
            this.HelpProviderSettings.SetShowHelp(this.LabelTOTPSettingsStringName, true);
            this.LabelTOTPSettingsStringName.Size = new System.Drawing.Size(93, 21);
            this.LabelTOTPSettingsStringName.TabIndex = 1;
            this.LabelTOTPSettingsStringName.Text = "自定义字段名称：";
            this.LabelTOTPSettingsStringName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ComboBoxTOTPSettingsStringName
            //
            this.ComboBoxTOTPSettingsStringName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBoxTOTPSettingsStringName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTOTPSettingsStringName.FormattingEnabled = true;
            this.HelpProviderSettings.SetHelpString(this.ComboBoxTOTPSettingsStringName, resources.GetString("ComboBoxTOTPSettingsStringName.HelpString"));
            this.ComboBoxTOTPSettingsStringName.Location = new System.Drawing.Point(126, 74);
            this.ComboBoxTOTPSettingsStringName.Name = "ComboBoxTOTPSettingsStringName";
            this.HelpProviderSettings.SetShowHelp(this.ComboBoxTOTPSettingsStringName, true);
            this.ComboBoxTOTPSettingsStringName.Size = new System.Drawing.Size(177, 21);
            this.ComboBoxTOTPSettingsStringName.TabIndex = 2;
            this.ComboBoxTOTPSettingsStringName.Tag = "";
            //
            // LabelDescriptionTOTPSettings
            //
            this.LabelDescriptionTOTPSettings.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionTOTPSettings.Name = "LabelDescriptionTOTPSettings";
            this.LabelDescriptionTOTPSettings.Size = new System.Drawing.Size(303, 48);
            this.LabelDescriptionTOTPSettings.TabIndex = 0;
            this.LabelDescriptionTOTPSettings.Text = "自定义插件在生成 TOTP 时使用的其他参数存储的自定义字段名称。";
            //
            // GroupBoxTOTPSeed
            //
            this.GroupBoxTOTPSeed.Controls.Add(this.LabelTOTPSeedStringName);
            this.GroupBoxTOTPSeed.Controls.Add(this.ComboBoxTOTPSeedStringName);
            this.GroupBoxTOTPSeed.Controls.Add(this.LabelDescriptionTOTPSeed);
            this.GroupBoxTOTPSeed.Location = new System.Drawing.Point(10, 10);
            this.GroupBoxTOTPSeed.Name = "GroupBoxTOTPSeed";
            this.GroupBoxTOTPSeed.Size = new System.Drawing.Size(335, 110);
            this.GroupBoxTOTPSeed.TabIndex = 0;
            this.GroupBoxTOTPSeed.TabStop = false;
            this.GroupBoxTOTPSeed.Text = "TOTP 种子";
            //
            // LabelTOTPSeedStringName
            //
            this.HelpProviderSettings.SetHelpString(this.LabelTOTPSeedStringName, "自定义插件在生成 TOTP 时使用的自定义字段名称，确保字符串仅包含种子。空格将会被自动去除。");
            this.LabelTOTPSeedStringName.Location = new System.Drawing.Point(27, 73);
            this.LabelTOTPSeedStringName.Name = "LabelTOTPSeedStringName";
            this.HelpProviderSettings.SetShowHelp(this.LabelTOTPSeedStringName, true);
            this.LabelTOTPSeedStringName.Size = new System.Drawing.Size(93, 21);
            this.LabelTOTPSeedStringName.TabIndex = 1;
            this.LabelTOTPSeedStringName.Text = "自定义字段名称：";
            this.LabelTOTPSeedStringName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ComboBoxTOTPSeedStringName
            //
            this.ComboBoxTOTPSeedStringName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBoxTOTPSeedStringName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTOTPSeedStringName.FormattingEnabled = true;
            this.HelpProviderSettings.SetHelpString(this.ComboBoxTOTPSeedStringName, "自定义插件在生成 TOTP 时使用的种子存储的自定义字段名称。");
            this.ComboBoxTOTPSeedStringName.Location = new System.Drawing.Point(126, 74);
            this.ComboBoxTOTPSeedStringName.Name = "ComboBoxTOTPSeedStringName";
            this.HelpProviderSettings.SetShowHelp(this.ComboBoxTOTPSeedStringName, true);
            this.ComboBoxTOTPSeedStringName.Size = new System.Drawing.Size(177, 21);
            this.ComboBoxTOTPSeedStringName.TabIndex = 2;
            //
            // LabelDescriptionTOTPSeed
            //
            this.LabelDescriptionTOTPSeed.Location = new System.Drawing.Point(16, 24);
            this.LabelDescriptionTOTPSeed.Name = "LabelDescriptionTOTPSeed";
            this.LabelDescriptionTOTPSeed.Size = new System.Drawing.Size(303, 48);
            this.LabelDescriptionTOTPSeed.TabIndex = 0;
            this.LabelDescriptionTOTPSeed.Text = "种子是用于生成 TOTP 的密钥。它将使用下面指定的名称保存在条目的自定义字段中。";
            // 
            // LabelRestartRequired
            // 
            this.LabelRestartRequired.AutoSize = true;
            this.LabelRestartRequired.ForeColor = System.Drawing.Color.Red;
            this.LabelRestartRequired.Location = new System.Drawing.Point(16, 54);
            this.LabelRestartRequired.Name = "LabelRestartRequired";
            this.LabelRestartRequired.Size = new System.Drawing.Size(268, 13);
            this.LabelRestartRequired.TabIndex = 4;
            this.LabelRestartRequired.Text = "请重启 KeePass 使修改生效。";
            this.LabelRestartRequired.Visible = false;
            // 
            // ButtonOK
            //
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpProviderSettings.SetHelpString(this.ButtonOK, "保存并应用所有的修改，然后关闭窗口");
            this.ButtonOK.Location = new System.Drawing.Point(133, 359);
            this.ButtonOK.Name = "ButtonOK";
            this.HelpProviderSettings.SetShowHelp(this.ButtonOK, true);
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "保存";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            //
            // ButtonCancel
            //
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HelpProviderSettings.SetHelpString(this.ButtonCancel, "取消所有未应用的修改，并关闭窗口。");
            this.ButtonCancel.Location = new System.Drawing.Point(214, 359);
            this.ButtonCancel.Name = "ButtonCancel";
            this.HelpProviderSettings.SetShowHelp(this.ButtonCancel, true);
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            //
            // ButtonApply
            //
            this.ButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpProviderSettings.SetHelpString(this.ButtonApply, "保存并应用所有的修改。");
            this.ButtonApply.Location = new System.Drawing.Point(295, 359);
            this.ButtonApply.Name = "ButtonApply";
            this.HelpProviderSettings.SetShowHelp(this.ButtonApply, true);
            this.ButtonApply.Size = new System.Drawing.Size(75, 23);
            this.ButtonApply.TabIndex = 3;
            this.ButtonApply.Tag = "";
            this.ButtonApply.Text = "应用";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            //
            // ButtonReset
            //
            this.HelpProviderSettings.SetHelpString(this.ButtonReset, "将 Tray TOTP 插件所有的设置还原为默认值。");
            this.ButtonReset.Location = new System.Drawing.Point(16, 359);
            this.ButtonReset.Name = "ButtonReset";
            this.HelpProviderSettings.SetShowHelp(this.ButtonReset, true);
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Tag = "";
            this.ButtonReset.Text = "默认值";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            //
            // WorkerLoad
            //
            this.WorkerLoad.WorkerSupportsCancellation = true;
            this.WorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerLoad_DoWork);
            this.WorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerLoad_RunWorkerCompleted);
            //
            // WorkerSave
            //
            this.WorkerSave.WorkerSupportsCancellation = true;
            this.WorkerSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerSave_DoWork);
            this.WorkerSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerSave_RunWorkerCompleted);
            //
            // ErrorProviderSettings
            //
            this.ErrorProviderSettings.ContainerControl = this;
            //
            // WorkerReset
            //
            this.WorkerReset.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerReset_DoWork);
            this.WorkerReset.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerReset_RunWorkerCompleted);
            //
            // FormSettings
            //
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(386, 390);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TabControlSettings);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "_seetings form_";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.TabControlSettings.ResumeLayout(false);
            this.TabPageContextMenus.ResumeLayout(false);
            this.GroupBoxTrayMenu.ResumeLayout(false);
            this.GroupBoxEntryMenu.ResumeLayout(false);
            this.TabPageEntryList.ResumeLayout(false);
            this.GroupBoxTOTPColumn.ResumeLayout(false);
            this.TabPageAutoType.ResumeLayout(false);
            this.GroupBoxAutoType.ResumeLayout(false);
            this.GroupBoxAutoType.PerformLayout();
            this.TabPageSync.ResumeLayout(false);
            this.GroupBoxTimeCorrectonList.ResumeLayout(false);
            this.GroupBoxTimeCorrectonList.PerformLayout();
            this.ToolStripTimeCorrectionList.ResumeLayout(false);
            this.ToolStripTimeCorrectionList.PerformLayout();
            this.GroupBoxTimeCorrection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTimeCorrectionInterval)).EndInit();
            this.TabPageStorage.ResumeLayout(false);
            this.GroupBoxTOTPSettings.ResumeLayout(false);
            this.GroupBoxTOTPSeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlSettings;
        private System.Windows.Forms.TabPage TabPageContextMenus;
        private System.Windows.Forms.GroupBox GroupBoxTrayMenu;
        private System.Windows.Forms.CheckBox CheckBoxShowTOTPEntriesTrayMenu;
        private System.Windows.Forms.GroupBox GroupBoxEntryMenu;
        private System.Windows.Forms.CheckBox CheckBoxShowCopyTOTPEntryMenu;
        private System.Windows.Forms.TabPage TabPageStorage;
        private System.Windows.Forms.GroupBox GroupBoxTOTPSeed;
        private System.Windows.Forms.Label LabelTOTPSeedStringName;
        private System.Windows.Forms.ComboBox ComboBoxTOTPSeedStringName;
        private System.Windows.Forms.Label LabelDescriptionTOTPSeed;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.TabPage TabPageEntryList;
        private System.Windows.Forms.GroupBox GroupBoxTOTPColumn;
        private System.Windows.Forms.CheckBox CheckBoxTOTPColumnTimer;
        private System.Windows.Forms.Label LabelDescriptionTOTPColumnTimer;
        private System.Windows.Forms.TabPage TabPageAutoType;
        private System.Windows.Forms.CheckBox CheckBoxAutoType;
        private System.Windows.Forms.GroupBox GroupBoxAutoType;
        private System.Windows.Forms.TextBox TextBoxAutoTypeFieldName;
        private System.Windows.Forms.Label LabelDescriptionAutoType;
        private System.Windows.Forms.GroupBox GroupBoxTOTPSettings;
        private System.Windows.Forms.Label LabelTOTPSettingsStringName;
        private System.Windows.Forms.ComboBox ComboBoxTOTPSettingsStringName;
        private System.Windows.Forms.Label LabelDescriptionTOTPSettings;
        private System.Windows.Forms.TabPage TabPageSync;
        private System.Windows.Forms.CheckBox CheckBoxTimeCorrection;
        private System.Windows.Forms.GroupBox GroupBoxTimeCorrection;
        private System.Windows.Forms.Label LabelTimeCorrectionMinutes;
        private System.Windows.Forms.Label LabelTimeCorrectionInterval;
        private System.Windows.Forms.NumericUpDown NumericTimeCorrectionInterval;
        private System.Windows.Forms.Label LabelTimeCorrection;
        private System.Windows.Forms.GroupBox GroupBoxTimeCorrectonList;
        private System.Windows.Forms.ListView ListViewTimeCorrectionList;
        private System.Windows.Forms.ColumnHeader ColumnTimeCorrection;
        private System.Windows.Forms.ColumnHeader ColumnTimeSpan;
        private System.Windows.Forms.ImageList ImageListTimeCorrectionList;
        private System.Windows.Forms.HelpProvider HelpProviderSettings;
        private System.Windows.Forms.Label LabelDescriptionTrayMenu;
        private System.Windows.Forms.Label LabelDescriptionEntryMenu;
        private System.ComponentModel.BackgroundWorker WorkerLoad;
        private System.ComponentModel.BackgroundWorker WorkerSave;
        private System.Windows.Forms.ToolStrip ToolStripTimeCorrectionList;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAddTimeCorrection;
        private System.Windows.Forms.ToolStripButton ToolStripButtonPropertiesTimeCorrection;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRemoveTimeCorrection;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRefreshTimeCorrection;
        private System.Windows.Forms.CheckBox CheckBoxShowSetupTOTPEntryMenu;
        private System.Windows.Forms.ErrorProvider ErrorProviderSettings;
        private System.Windows.Forms.CheckBox CheckBoxAutoTypeFieldName;
        private System.Windows.Forms.CheckBox CheckBoxAutoTypeFieldRename;
        private System.Windows.Forms.CheckBox CheckBoxTOTPColumnClipboard;
        private System.Windows.Forms.Button ButtonReset;
        private System.ComponentModel.BackgroundWorker WorkerReset;
        private System.Windows.Forms.CheckBox CheckBoxTrimTrayText;
        private System.Windows.Forms.CheckBox CheckBoxEnableLegacyTrayMenuProvider;
        private System.Windows.Forms.Label LabelRestartRequired;
    }
}