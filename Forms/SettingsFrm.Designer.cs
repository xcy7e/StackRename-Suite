namespace SRSuite.Forms
{
    partial class SettingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.toolTipExplorerContextMenuSetting = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbInitRuleSearchReplace = new System.Windows.Forms.CheckBox();
            this.cbInitRuleNumbering = new System.Windows.Forms.CheckBox();
            this.cbInitRulePrepend = new System.Windows.Forms.CheckBox();
            this.cbInitRuleAppend = new System.Windows.Forms.CheckBox();
            this.cbInitRuleRegReplace = new System.Windows.Forms.CheckBox();
            this.cbInitRuleRegRemove = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRenameFileExt = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterFoldersVisibleEnabled = new System.Windows.Forms.CheckBox();
            this.cbFilterFilesVisibleEnabled = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFilterElementStateAll = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterElementStateIndividual = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExplorerContextMenuIntegrationEnabled = new System.Windows.Forms.CheckBox();
            this.lblHelpTooltipExplorerContextMenuIntegration = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(523, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveSettings);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(427, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Abbre&chen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.cancel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageView);
            this.tabControl1.Controls.Add(this.tabPageAdvanced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 209);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.flowLayoutPanel4);
            this.tabPageGeneral.Controls.Add(this.flowLayoutPanel5);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(515, 183);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Allgemein";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.flowLayoutPanel2);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(515, 183);
            this.tabPageAdvanced.TabIndex = 1;
            this.tabPageAdvanced.Text = "Erweitert";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // toolTipExplorerContextMenuSetting
            // 
            this.toolTipExplorerContextMenuSetting.AutomaticDelay = 50;
            this.toolTipExplorerContextMenuSetting.AutoPopDelay = 30000;
            this.toolTipExplorerContextMenuSetting.InitialDelay = 50;
            this.toolTipExplorerContextMenuSetting.ReshowDelay = 10;
            this.toolTipExplorerContextMenuSetting.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipExplorerContextMenuSetting.ToolTipTitle = "SRSuite im Kontextmenü anzeigen";
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.flowLayoutPanel3);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(515, 183);
            this.tabPageView.TabIndex = 2;
            this.tabPageView.Text = "Anzeige";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRuleSearchReplace);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRuleNumbering);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRulePrepend);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRuleAppend);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRuleRegReplace);
            this.flowLayoutPanel5.Controls.Add(this.cbInitRuleRegRemove);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(253, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(257, 168);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Initiale Regeln laden";
            // 
            // cbInitRuleSearchReplace
            // 
            this.cbInitRuleSearchReplace.Location = new System.Drawing.Point(3, 27);
            this.cbInitRuleSearchReplace.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRuleSearchReplace.Name = "cbInitRuleSearchReplace";
            this.cbInitRuleSearchReplace.Size = new System.Drawing.Size(240, 17);
            this.cbInitRuleSearchReplace.TabIndex = 2;
            this.cbInitRuleSearchReplace.Text = "Suchen && Ersetzen";
            this.cbInitRuleSearchReplace.UseVisualStyleBackColor = true;
            // 
            // cbInitRuleNumbering
            // 
            this.cbInitRuleNumbering.Location = new System.Drawing.Point(3, 50);
            this.cbInitRuleNumbering.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRuleNumbering.Name = "cbInitRuleNumbering";
            this.cbInitRuleNumbering.Size = new System.Drawing.Size(240, 17);
            this.cbInitRuleNumbering.TabIndex = 3;
            this.cbInitRuleNumbering.Text = "Nummerieren";
            this.cbInitRuleNumbering.UseVisualStyleBackColor = true;
            // 
            // cbInitRulePrepend
            // 
            this.cbInitRulePrepend.Location = new System.Drawing.Point(3, 73);
            this.cbInitRulePrepend.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRulePrepend.Name = "cbInitRulePrepend";
            this.cbInitRulePrepend.Size = new System.Drawing.Size(240, 17);
            this.cbInitRulePrepend.TabIndex = 4;
            this.cbInitRulePrepend.Text = "Vorne anfügen";
            this.cbInitRulePrepend.UseVisualStyleBackColor = true;
            // 
            // cbInitRuleAppend
            // 
            this.cbInitRuleAppend.Location = new System.Drawing.Point(3, 96);
            this.cbInitRuleAppend.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRuleAppend.Name = "cbInitRuleAppend";
            this.cbInitRuleAppend.Size = new System.Drawing.Size(240, 17);
            this.cbInitRuleAppend.TabIndex = 5;
            this.cbInitRuleAppend.Text = "Hinten anfügen";
            this.cbInitRuleAppend.UseVisualStyleBackColor = true;
            // 
            // cbInitRuleRegReplace
            // 
            this.cbInitRuleRegReplace.Location = new System.Drawing.Point(3, 119);
            this.cbInitRuleRegReplace.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRuleRegReplace.Name = "cbInitRuleRegReplace";
            this.cbInitRuleRegReplace.Size = new System.Drawing.Size(240, 17);
            this.cbInitRuleRegReplace.TabIndex = 6;
            this.cbInitRuleRegReplace.Text = "Ersetzen (Regex)";
            this.cbInitRuleRegReplace.UseVisualStyleBackColor = true;
            // 
            // cbInitRuleRegRemove
            // 
            this.cbInitRuleRegRemove.Location = new System.Drawing.Point(3, 142);
            this.cbInitRuleRegRemove.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbInitRuleRegRemove.Name = "cbInitRuleRegRemove";
            this.cbInitRuleRegRemove.Size = new System.Drawing.Size(240, 17);
            this.cbInitRuleRegRemove.TabIndex = 7;
            this.cbInitRuleRegRemove.Text = "Löschen (Regex)";
            this.cbInitRuleRegRemove.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.cbRenameFileExt);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(240, 100);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(237, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Standardeinstellung";
            // 
            // cbRenameFileExt
            // 
            this.cbRenameFileExt.AutoSize = true;
            this.cbRenameFileExt.Location = new System.Drawing.Point(3, 27);
            this.cbRenameFileExt.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbRenameFileExt.Name = "cbRenameFileExt";
            this.cbRenameFileExt.Size = new System.Drawing.Size(164, 17);
            this.cbRenameFileExt.TabIndex = 2;
            this.cbRenameFileExt.Text = "Dateiendungen umbenennen";
            this.cbRenameFileExt.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cbFilterFoldersVisibleEnabled);
            this.flowLayoutPanel3.Controls.Add(this.cbFilterFilesVisibleEnabled);
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonFilterElementStateAll);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonFilterElementStateIndividual);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(243, 114);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(240, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Standardeinstellungen";
            // 
            // cbFilterFoldersVisibleEnabled
            // 
            this.cbFilterFoldersVisibleEnabled.AutoSize = true;
            this.cbFilterFoldersVisibleEnabled.Location = new System.Drawing.Point(3, 27);
            this.cbFilterFoldersVisibleEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbFilterFoldersVisibleEnabled.Name = "cbFilterFoldersVisibleEnabled";
            this.cbFilterFoldersVisibleEnabled.Size = new System.Drawing.Size(104, 17);
            this.cbFilterFoldersVisibleEnabled.TabIndex = 1;
            this.cbFilterFoldersVisibleEnabled.Text = "Ordner anzeigen";
            this.cbFilterFoldersVisibleEnabled.UseVisualStyleBackColor = true;
            // 
            // cbFilterFilesVisibleEnabled
            // 
            this.cbFilterFilesVisibleEnabled.AutoSize = true;
            this.cbFilterFilesVisibleEnabled.Location = new System.Drawing.Point(110, 27);
            this.cbFilterFilesVisibleEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbFilterFilesVisibleEnabled.Name = "cbFilterFilesVisibleEnabled";
            this.cbFilterFilesVisibleEnabled.Size = new System.Drawing.Size(109, 17);
            this.cbFilterFilesVisibleEnabled.TabIndex = 2;
            this.cbFilterFilesVisibleEnabled.Text = "Dateien anzeigen";
            this.cbFilterFilesVisibleEnabled.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 15);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elemente";
            // 
            // radioButtonFilterElementStateAll
            // 
            this.radioButtonFilterElementStateAll.AutoSize = true;
            this.radioButtonFilterElementStateAll.Location = new System.Drawing.Point(3, 89);
            this.radioButtonFilterElementStateAll.Name = "radioButtonFilterElementStateAll";
            this.radioButtonFilterElementStateAll.Size = new System.Drawing.Size(96, 17);
            this.radioButtonFilterElementStateAll.TabIndex = 5;
            this.radioButtonFilterElementStateAll.TabStop = true;
            this.radioButtonFilterElementStateAll.Text = "Alle auswählen";
            this.radioButtonFilterElementStateAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterElementStateIndividual
            // 
            this.radioButtonFilterElementStateIndividual.AutoSize = true;
            this.radioButtonFilterElementStateIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFilterElementStateIndividual.Location = new System.Drawing.Point(105, 89);
            this.radioButtonFilterElementStateIndividual.Name = "radioButtonFilterElementStateIndividual";
            this.radioButtonFilterElementStateIndividual.Size = new System.Drawing.Size(120, 17);
            this.radioButtonFilterElementStateIndividual.TabIndex = 7;
            this.radioButtonFilterElementStateIndividual.TabStop = true;
            this.radioButtonFilterElementStateIndividual.Text = "Individuelle Auswahl";
            this.radioButtonFilterElementStateIndividual.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.cbExplorerContextMenuIntegrationEnabled);
            this.flowLayoutPanel2.Controls.Add(this.lblHelpTooltipExplorerContextMenuIntegration);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(251, 82);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Explorer Integration";
            // 
            // cbExplorerContextMenuIntegrationEnabled
            // 
            this.cbExplorerContextMenuIntegrationEnabled.AutoSize = true;
            this.cbExplorerContextMenuIntegrationEnabled.Location = new System.Drawing.Point(3, 27);
            this.cbExplorerContextMenuIntegrationEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cbExplorerContextMenuIntegrationEnabled.Name = "cbExplorerContextMenuIntegrationEnabled";
            this.cbExplorerContextMenuIntegrationEnabled.Size = new System.Drawing.Size(183, 17);
            this.cbExplorerContextMenuIntegrationEnabled.TabIndex = 1;
            this.cbExplorerContextMenuIntegrationEnabled.Text = "Eintrag im Kontextmenü anzeigen";
            this.cbExplorerContextMenuIntegrationEnabled.UseVisualStyleBackColor = true;
            // 
            // lblHelpTooltipExplorerContextMenuIntegration
            // 
            this.lblHelpTooltipExplorerContextMenuIntegration.AutoSize = true;
            this.lblHelpTooltipExplorerContextMenuIntegration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHelpTooltipExplorerContextMenuIntegration.Location = new System.Drawing.Point(189, 29);
            this.lblHelpTooltipExplorerContextMenuIntegration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lblHelpTooltipExplorerContextMenuIntegration.Name = "lblHelpTooltipExplorerContextMenuIntegration";
            this.lblHelpTooltipExplorerContextMenuIntegration.Size = new System.Drawing.Size(19, 13);
            this.lblHelpTooltipExplorerContextMenuIntegration.TabIndex = 2;
            this.lblHelpTooltipExplorerContextMenuIntegration.Text = "(?)";
            this.toolTipExplorerContextMenuSetting.SetToolTip(this.lblHelpTooltipExplorerContextMenuIntegration, resources.GetString("lblHelpTooltipExplorerContextMenuIntegration.ToolTip"));
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageAdvanced.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.ToolTip toolTipExplorerContextMenuSetting;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbRenameFileExt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbInitRuleSearchReplace;
        private System.Windows.Forms.CheckBox cbInitRuleNumbering;
        private System.Windows.Forms.CheckBox cbInitRulePrepend;
        private System.Windows.Forms.CheckBox cbInitRuleAppend;
        private System.Windows.Forms.CheckBox cbInitRuleRegReplace;
        private System.Windows.Forms.CheckBox cbInitRuleRegRemove;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFilterFoldersVisibleEnabled;
        private System.Windows.Forms.CheckBox cbFilterFilesVisibleEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonFilterElementStateAll;
        private System.Windows.Forms.RadioButton radioButtonFilterElementStateIndividual;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbExplorerContextMenuIntegrationEnabled;
        private System.Windows.Forms.Label lblHelpTooltipExplorerContextMenuIntegration;
    }
}