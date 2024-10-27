namespace SRSuite.Controls
{
    partial class RuleCtrl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_RuleWrapper = new System.Windows.Forms.GroupBox();
            this.panelRuleControl = new System.Windows.Forms.Panel();
            this.contextMenu_RuleCtrl_settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRuleEnabledState = new System.Windows.Forms.CheckBox();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.btn_RuleCtrl_settings = new System.Windows.Forms.PictureBox();
            this.fancyCheckboxRuleEnabled = new System.Windows.Forms.PictureBox();
            this.btn_RuleCtrl_remove = new System.Windows.Forms.PictureBox();
            this.groupBox_RuleWrapper.SuspendLayout();
            this.contextMenu_RuleCtrl_settings.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RuleCtrl_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fancyCheckboxRuleEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RuleCtrl_remove)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_RuleWrapper
            // 
            this.groupBox_RuleWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_RuleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_RuleWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_RuleWrapper.Controls.Add(this.panelRuleControl);
            this.groupBox_RuleWrapper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_RuleWrapper.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_RuleWrapper.Location = new System.Drawing.Point(4, 6);
            this.groupBox_RuleWrapper.MinimumSize = new System.Drawing.Size(180, 65);
            this.groupBox_RuleWrapper.Name = "groupBox_RuleWrapper";
            this.groupBox_RuleWrapper.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.groupBox_RuleWrapper.Size = new System.Drawing.Size(258, 121);
            this.groupBox_RuleWrapper.TabIndex = 0;
            this.groupBox_RuleWrapper.TabStop = false;
            this.groupBox_RuleWrapper.Text = "Regel";
            // 
            // panelRuleControl
            // 
            this.panelRuleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRuleControl.BackColor = System.Drawing.Color.Transparent;
            this.panelRuleControl.Location = new System.Drawing.Point(7, 20);
            this.panelRuleControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelRuleControl.Name = "panelRuleControl";
            this.panelRuleControl.Size = new System.Drawing.Size(242, 83);
            this.panelRuleControl.TabIndex = 4;
            // 
            // contextMenu_RuleCtrl_settings
            // 
            this.contextMenu_RuleCtrl_settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenu_RuleCtrl_settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivierenToolStripMenuItem,
            this.aktivierenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.contextMenu_RuleCtrl_settings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenu_RuleCtrl_settings.Name = "contextMenu_RuleCtrl_settings";
            this.contextMenu_RuleCtrl_settings.ShowItemToolTips = false;
            this.contextMenu_RuleCtrl_settings.Size = new System.Drawing.Size(140, 70);
            // 
            // deaktivierenToolStripMenuItem
            // 
            this.deaktivierenToolStripMenuItem.Name = "deaktivierenToolStripMenuItem";
            this.deaktivierenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deaktivierenToolStripMenuItem.Text = "&Deaktivieren";
            this.deaktivierenToolStripMenuItem.Click += new System.EventHandler(this.deaktivierenToolStripMenuItem_Click);
            // 
            // aktivierenToolStripMenuItem
            // 
            this.aktivierenToolStripMenuItem.Name = "aktivierenToolStripMenuItem";
            this.aktivierenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aktivierenToolStripMenuItem.Text = "&Aktivieren";
            this.aktivierenToolStripMenuItem.Visible = false;
            this.aktivierenToolStripMenuItem.Click += new System.EventHandler(this.aktivierenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.löschenToolStripMenuItem.Text = "&Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // cbRuleEnabledState
            // 
            this.cbRuleEnabledState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRuleEnabledState.AutoSize = true;
            this.cbRuleEnabledState.Checked = true;
            this.cbRuleEnabledState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRuleEnabledState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRuleEnabledState.Location = new System.Drawing.Point(34, 7);
            this.cbRuleEnabledState.Name = "cbRuleEnabledState";
            this.cbRuleEnabledState.Size = new System.Drawing.Size(12, 11);
            this.cbRuleEnabledState.TabIndex = 3;
            this.cbRuleEnabledState.UseVisualStyleBackColor = true;
            this.cbRuleEnabledState.Visible = false;
            // 
            // panelActionBar
            // 
            this.panelActionBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelActionBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionBar.Controls.Add(this.btn_RuleCtrl_settings);
            this.panelActionBar.Controls.Add(this.fancyCheckboxRuleEnabled);
            this.panelActionBar.Controls.Add(this.btn_RuleCtrl_remove);
            this.panelActionBar.Controls.Add(this.cbRuleEnabledState);
            this.panelActionBar.Location = new System.Drawing.Point(165, 0);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(84, 27);
            this.panelActionBar.TabIndex = 5;
            // 
            // btn_RuleCtrl_settings
            // 
            this.btn_RuleCtrl_settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_RuleCtrl_settings.BackgroundImage = global::SRSuite.Properties.Resources.wrench_wrench_2;
            this.btn_RuleCtrl_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RuleCtrl_settings.ContextMenuStrip = this.contextMenu_RuleCtrl_settings;
            this.btn_RuleCtrl_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RuleCtrl_settings.Location = new System.Drawing.Point(4, 3);
            this.btn_RuleCtrl_settings.Name = "btn_RuleCtrl_settings";
            this.btn_RuleCtrl_settings.Padding = new System.Windows.Forms.Padding(2);
            this.btn_RuleCtrl_settings.Size = new System.Drawing.Size(22, 20);
            this.btn_RuleCtrl_settings.TabIndex = 1;
            this.btn_RuleCtrl_settings.TabStop = false;
            this.btn_RuleCtrl_settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_RuleCtrl_settings_MouseClick);
            // 
            // fancyCheckboxRuleEnabled
            // 
            this.fancyCheckboxRuleEnabled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fancyCheckboxRuleEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fancyCheckboxRuleEnabled.Image = global::SRSuite.Properties.Resources.checkbox_checked;
            this.fancyCheckboxRuleEnabled.Location = new System.Drawing.Point(30, 3);
            this.fancyCheckboxRuleEnabled.Name = "fancyCheckboxRuleEnabled";
            this.fancyCheckboxRuleEnabled.Size = new System.Drawing.Size(22, 20);
            this.fancyCheckboxRuleEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fancyCheckboxRuleEnabled.TabIndex = 2;
            this.fancyCheckboxRuleEnabled.TabStop = false;
            this.fancyCheckboxRuleEnabled.Click += new System.EventHandler(this.fancyCheckboxRuleEnabled_Click);
            this.fancyCheckboxRuleEnabled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fancyCheckboxRuleEnabled_MouseDown);
            this.fancyCheckboxRuleEnabled.MouseEnter += new System.EventHandler(this.fancyCheckboxRuleEnabled_MouseEnter);
            this.fancyCheckboxRuleEnabled.MouseLeave += new System.EventHandler(this.fancyCheckboxRuleEnabled_MouseLeave);
            this.fancyCheckboxRuleEnabled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fancyCheckboxRuleEnabled_MouseUp);
            // 
            // btn_RuleCtrl_remove
            // 
            this.btn_RuleCtrl_remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_RuleCtrl_remove.BackgroundImage = global::SRSuite.Properties.Resources.error_error_sign_sign;
            this.btn_RuleCtrl_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RuleCtrl_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RuleCtrl_remove.Location = new System.Drawing.Point(56, 3);
            this.btn_RuleCtrl_remove.Name = "btn_RuleCtrl_remove";
            this.btn_RuleCtrl_remove.Padding = new System.Windows.Forms.Padding(2);
            this.btn_RuleCtrl_remove.Size = new System.Drawing.Size(22, 20);
            this.btn_RuleCtrl_remove.TabIndex = 0;
            this.btn_RuleCtrl_remove.TabStop = false;
            this.btn_RuleCtrl_remove.Click += new System.EventHandler(this.btn_RuleCtrl_remove_Click);
            // 
            // RuleCtrl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.groupBox_RuleWrapper);
            this.MinimumSize = new System.Drawing.Size(270, 65);
            this.Name = "RuleCtrl";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(270, 131);
            this.groupBox_RuleWrapper.ResumeLayout(false);
            this.contextMenu_RuleCtrl_settings.ResumeLayout(false);
            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RuleCtrl_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fancyCheckboxRuleEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RuleCtrl_remove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_RuleWrapper;
        public System.Windows.Forms.PictureBox btn_RuleCtrl_remove;
        public System.Windows.Forms.PictureBox btn_RuleCtrl_settings;
        public System.Windows.Forms.ContextMenuStrip contextMenu_RuleCtrl_settings;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aktivierenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deaktivierenToolStripMenuItem;
        private System.Windows.Forms.PictureBox fancyCheckboxRuleEnabled;
        private System.Windows.Forms.CheckBox cbRuleEnabledState;
        private System.Windows.Forms.Panel panelRuleControl;
        private System.Windows.Forms.Panel panelActionBar;
    }
}
