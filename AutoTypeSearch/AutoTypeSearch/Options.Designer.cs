using KeePass.UI;

namespace AutoTypeSearch
{
	partial class Options
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.GroupBox searchOptionsGroup;
            System.Windows.Forms.GroupBox searchInGroup;
            System.Windows.Forms.GroupBox actionsGroup;
            System.Windows.Forms.Label alternativeActionLabel;
            System.Windows.Forms.Label defaultActionLabel;
            this.mResolveReferences = new System.Windows.Forms.CheckBox();
            this.mExcludeExpired = new System.Windows.Forms.CheckBox();
            this.mCaseSensitive = new System.Windows.Forms.CheckBox();
            this.mSearchInTags = new System.Windows.Forms.CheckBox();
            this.mSearchInOtherFields = new System.Windows.Forms.CheckBox();
            this.mSearchInNotes = new System.Windows.Forms.CheckBox();
            this.mSearchInUrl = new System.Windows.Forms.CheckBox();
            this.mSearchInUserName = new System.Windows.Forms.CheckBox();
            this.mSearchInTitle = new System.Windows.Forms.CheckBox();
            this.mAlternativeAction = new System.Windows.Forms.ComboBox();
            this.mDefaultAction = new System.Windows.Forms.ComboBox();
            this.mShowHotKeyControl = new KeePass.UI.HotKeyControlEx();
            this.mShowSearchGroup = new System.Windows.Forms.GroupBox();
            this.mShowOnHotKey = new System.Windows.Forms.CheckBox();
            this.mShowOnIPC = new System.Windows.Forms.CheckBox();
            this.mShowOnFailedSearch = new System.Windows.Forms.CheckBox();
            this.mKeepWindowOpen = new System.Windows.Forms.CheckBox();
            searchOptionsGroup = new System.Windows.Forms.GroupBox();
            searchInGroup = new System.Windows.Forms.GroupBox();
            actionsGroup = new System.Windows.Forms.GroupBox();
            alternativeActionLabel = new System.Windows.Forms.Label();
            defaultActionLabel = new System.Windows.Forms.Label();
            searchOptionsGroup.SuspendLayout();
            searchInGroup.SuspendLayout();
            actionsGroup.SuspendLayout();
            this.mShowSearchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchOptionsGroup
            // 
            searchOptionsGroup.Controls.Add(this.mResolveReferences);
            searchOptionsGroup.Controls.Add(this.mExcludeExpired);
            searchOptionsGroup.Controls.Add(this.mCaseSensitive);
            searchOptionsGroup.Location = new System.Drawing.Point(6, 212);
            searchOptionsGroup.Name = "searchOptionsGroup";
            searchOptionsGroup.Size = new System.Drawing.Size(540, 45);
            searchOptionsGroup.TabIndex = 2;
            searchOptionsGroup.TabStop = false;
            searchOptionsGroup.Text = "搜索选项";
            // 
            // mResolveReferences
            // 
            this.mResolveReferences.AutoSize = true;
            this.mResolveReferences.Location = new System.Drawing.Point(251, 20);
            this.mResolveReferences.Name = "mResolveReferences";
            this.mResolveReferences.Size = new System.Drawing.Size(170, 17);
            this.mResolveReferences.TabIndex = 2;
            this.mResolveReferences.Text = "解析字段引用（慢）";
            this.mResolveReferences.UseVisualStyleBackColor = true;
            // 
            // mExcludeExpired
            // 
            this.mExcludeExpired.AutoSize = true;
            this.mExcludeExpired.Location = new System.Drawing.Point(108, 20);
            this.mExcludeExpired.Name = "mExcludeExpired";
            this.mExcludeExpired.Size = new System.Drawing.Size(135, 17);
            this.mExcludeExpired.TabIndex = 1;
            this.mExcludeExpired.Text = "排除过期条目";
            this.mExcludeExpired.UseVisualStyleBackColor = true;
            // 
            // mCaseSensitive
            // 
            this.mCaseSensitive.AutoSize = true;
            this.mCaseSensitive.Location = new System.Drawing.Point(10, 20);
            this.mCaseSensitive.Name = "mCaseSensitive";
            this.mCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.mCaseSensitive.TabIndex = 0;
            this.mCaseSensitive.Text = "区分大小写";
            this.mCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // searchInGroup
            // 
            searchInGroup.Controls.Add(this.mSearchInTags);
            searchInGroup.Controls.Add(this.mSearchInOtherFields);
            searchInGroup.Controls.Add(this.mSearchInNotes);
            searchInGroup.Controls.Add(this.mSearchInUrl);
            searchInGroup.Controls.Add(this.mSearchInUserName);
            searchInGroup.Controls.Add(this.mSearchInTitle);
            searchInGroup.Location = new System.Drawing.Point(6, 159);
            searchInGroup.Name = "searchInGroup";
            searchInGroup.Size = new System.Drawing.Size(540, 47);
            searchInGroup.TabIndex = 1;
            searchInGroup.TabStop = false;
            searchInGroup.Text = "搜索字段";
            // 
            // mSearchInTags
            // 
            this.mSearchInTags.AutoSize = true;
            this.mSearchInTags.Location = new System.Drawing.Point(258, 19);
            this.mSearchInTags.Name = "mSearchInTags";
            this.mSearchInTags.Size = new System.Drawing.Size(50, 17);
            this.mSearchInTags.TabIndex = 4;
            this.mSearchInTags.Text = "标记";
            this.mSearchInTags.UseVisualStyleBackColor = true;
            // 
            // mSearchInOtherFields
            // 
            this.mSearchInOtherFields.AutoSize = true;
            this.mSearchInOtherFields.Location = new System.Drawing.Point(314, 19);
            this.mSearchInOtherFields.Name = "mSearchInOtherFields";
            this.mSearchInOtherFields.Size = new System.Drawing.Size(139, 17);
            this.mSearchInOtherFields.TabIndex = 5;
            this.mSearchInOtherFields.Text = "未受保护的自定义字段";
            this.mSearchInOtherFields.UseVisualStyleBackColor = true;
            // 
            // mSearchInNotes
            // 
            this.mSearchInNotes.AutoSize = true;
            this.mSearchInNotes.Location = new System.Drawing.Point(198, 19);
            this.mSearchInNotes.Name = "mSearchInNotes";
            this.mSearchInNotes.Size = new System.Drawing.Size(54, 17);
            this.mSearchInNotes.TabIndex = 3;
            this.mSearchInNotes.Text = "备注";
            this.mSearchInNotes.UseVisualStyleBackColor = true;
            // 
            // mSearchInUrl
            // 
            this.mSearchInUrl.AutoSize = true;
            this.mSearchInUrl.Location = new System.Drawing.Point(144, 19);
            this.mSearchInUrl.Name = "mSearchInUrl";
            this.mSearchInUrl.Size = new System.Drawing.Size(48, 17);
            this.mSearchInUrl.TabIndex = 2;
            this.mSearchInUrl.Text = "URL";
            this.mSearchInUrl.UseVisualStyleBackColor = true;
            // 
            // mSearchInUserName
            // 
            this.mSearchInUserName.AutoSize = true;
            this.mSearchInUserName.Location = new System.Drawing.Point(61, 19);
            this.mSearchInUserName.Name = "mSearchInUserName";
            this.mSearchInUserName.Size = new System.Drawing.Size(77, 17);
            this.mSearchInUserName.TabIndex = 1;
            this.mSearchInUserName.Text = "用户名";
            this.mSearchInUserName.UseVisualStyleBackColor = true;
            // 
            // mSearchInTitle
            // 
            this.mSearchInTitle.AutoSize = true;
            this.mSearchInTitle.Location = new System.Drawing.Point(9, 19);
            this.mSearchInTitle.Name = "mSearchInTitle";
            this.mSearchInTitle.Size = new System.Drawing.Size(46, 17);
            this.mSearchInTitle.TabIndex = 0;
            this.mSearchInTitle.Text = "标题";
            this.mSearchInTitle.UseVisualStyleBackColor = true;
            // 
            // actionsGroup
            // 
            actionsGroup.Controls.Add(this.mAlternativeAction);
            actionsGroup.Controls.Add(this.mDefaultAction);
            actionsGroup.Controls.Add(alternativeActionLabel);
            actionsGroup.Controls.Add(defaultActionLabel);
            actionsGroup.Location = new System.Drawing.Point(6, 264);
            actionsGroup.Name = "actionsGroup";
            actionsGroup.Size = new System.Drawing.Size(540, 67);
            actionsGroup.TabIndex = 3;
            actionsGroup.TabStop = false;
            actionsGroup.Text = "操作";
            // 
            // mAlternativeAction
            // 
            this.mAlternativeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mAlternativeAction.Location = new System.Drawing.Point(288, 37);
            this.mAlternativeAction.Name = "mAlternativeAction";
            this.mAlternativeAction.Size = new System.Drawing.Size(240, 21);
            this.mAlternativeAction.TabIndex = 3;
            // 
            // mDefaultAction
            // 
            this.mDefaultAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mDefaultAction.Location = new System.Drawing.Point(11, 37);
            this.mDefaultAction.Name = "mDefaultAction";
            this.mDefaultAction.Size = new System.Drawing.Size(240, 21);
            this.mDefaultAction.TabIndex = 1;
            // 
            // alternativeActionLabel
            // 
            alternativeActionLabel.AutoSize = true;
            alternativeActionLabel.Location = new System.Drawing.Point(285, 20);
            alternativeActionLabel.Name = "alternativeActionLabel";
            alternativeActionLabel.Size = new System.Drawing.Size(159, 13);
            alternativeActionLabel.TabIndex = 2;
            alternativeActionLabel.Text = "另一个操作（Shift + Enter）：";
            // 
            // defaultActionLabel
            // 
            defaultActionLabel.AutoSize = true;
            defaultActionLabel.Location = new System.Drawing.Point(8, 20);
            defaultActionLabel.Name = "defaultActionLabel";
            defaultActionLabel.Size = new System.Drawing.Size(110, 13);
            defaultActionLabel.TabIndex = 0;
            defaultActionLabel.Text = "默认操作（Enter）：";
            // 
            // mShowHotKeyControl
            // 
            this.mShowHotKeyControl.Location = new System.Drawing.Point(30, 65);
            this.mShowHotKeyControl.Name = "mShowHotKeyControl";
            this.mShowHotKeyControl.Size = new System.Drawing.Size(123, 20);
            this.mShowHotKeyControl.TabIndex = 2;
            // 
            // mShowSearchGroup
            // 
            this.mShowSearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mShowSearchGroup.Controls.Add(this.mKeepWindowOpen);
            this.mShowSearchGroup.Controls.Add(this.mShowOnHotKey);
            this.mShowSearchGroup.Controls.Add(this.mShowHotKeyControl);
            this.mShowSearchGroup.Controls.Add(this.mShowOnIPC);
            this.mShowSearchGroup.Controls.Add(this.mShowOnFailedSearch);
            this.mShowSearchGroup.Location = new System.Drawing.Point(6, 12);
            this.mShowSearchGroup.Name = "mShowSearchGroup";
            this.mShowSearchGroup.Size = new System.Drawing.Size(540, 141);
            this.mShowSearchGroup.TabIndex = 0;
            this.mShowSearchGroup.TabStop = false;
            this.mShowSearchGroup.Text = "显示搜索框";
            // 
            // mShowOnHotKey
            // 
            this.mShowOnHotKey.AutoSize = true;
            this.mShowOnHotKey.Location = new System.Drawing.Point(10, 44);
            this.mShowOnHotKey.Name = "mShowOnHotKey";
            this.mShowOnHotKey.Size = new System.Drawing.Size(233, 17);
            this.mShowOnHotKey.TabIndex = 1;
            this.mShowOnHotKey.Text = "按下热键时显示搜索框：";
            this.mShowOnHotKey.UseVisualStyleBackColor = true;
            this.mShowOnHotKey.CheckedChanged += new System.EventHandler(this.mShowOnHotKey_CheckedChanged);
            // 
            // mShowOnIPC
            // 
            this.mShowOnIPC.AutoSize = true;
            this.mShowOnIPC.Location = new System.Drawing.Point(10, 93);
            this.mShowOnIPC.Name = "mShowOnIPC";
            this.mShowOnIPC.Size = new System.Drawing.Size(392, 17);
            this.mShowOnIPC.TabIndex = 3;
            this.mShowOnIPC.Text = "将 \"/e1:AutoTypeSearch\" 作为参数传递给 KeePass.exe 时显示";
            this.mShowOnIPC.UseVisualStyleBackColor = true;
            // 
            // mShowOnFailedSearch
            // 
            this.mShowOnFailedSearch.AutoSize = true;
            this.mShowOnFailedSearch.Location = new System.Drawing.Point(10, 21);
            this.mShowOnFailedSearch.Name = "mShowOnFailedSearch";
            this.mShowOnFailedSearch.Size = new System.Drawing.Size(275, 17);
            this.mShowOnFailedSearch.TabIndex = 0;
            this.mShowOnFailedSearch.Text = "全局自动输入未匹配时自动显示搜索框";
            this.mShowOnFailedSearch.UseVisualStyleBackColor = true;
            // 
            // mKeepWindowOpen
            // 
            this.mKeepWindowOpen.AutoSize = true;
            this.mKeepWindowOpen.Location = new System.Drawing.Point(10, 116);
            this.mKeepWindowOpen.Name = "mKeepWindowOpen";
            this.mKeepWindowOpen.Size = new System.Drawing.Size(303, 17);
            this.mKeepWindowOpen.TabIndex = 4;
            this.mKeepWindowOpen.Text = "保持搜索框打开，直到按下 Esc";
            this.mKeepWindowOpen.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(actionsGroup);
            this.Controls.Add(searchInGroup);
            this.Controls.Add(searchOptionsGroup);
            this.Controls.Add(this.mShowSearchGroup);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(551, 336);
            searchOptionsGroup.ResumeLayout(false);
            searchOptionsGroup.PerformLayout();
            searchInGroup.ResumeLayout(false);
            searchInGroup.PerformLayout();
            actionsGroup.ResumeLayout(false);
            actionsGroup.PerformLayout();
            this.mShowSearchGroup.ResumeLayout(false);
            this.mShowSearchGroup.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private KeePass.UI.HotKeyControlEx mShowHotKeyControl;
		private System.Windows.Forms.CheckBox mShowOnHotKey;
		private System.Windows.Forms.CheckBox mShowOnIPC;
		private System.Windows.Forms.CheckBox mShowOnFailedSearch;
		private System.Windows.Forms.CheckBox mCaseSensitive;
		private System.Windows.Forms.CheckBox mSearchInTags;
		private System.Windows.Forms.CheckBox mSearchInOtherFields;
		private System.Windows.Forms.CheckBox mSearchInNotes;
		private System.Windows.Forms.CheckBox mSearchInUrl;
		private System.Windows.Forms.CheckBox mSearchInUserName;
		private System.Windows.Forms.CheckBox mSearchInTitle;
		private System.Windows.Forms.CheckBox mResolveReferences;
		private System.Windows.Forms.CheckBox mExcludeExpired;
		private System.Windows.Forms.ComboBox mAlternativeAction;
		private System.Windows.Forms.ComboBox mDefaultAction;
		private System.Windows.Forms.GroupBox mShowSearchGroup;
        private System.Windows.Forms.CheckBox mKeepWindowOpen;
    }
}
