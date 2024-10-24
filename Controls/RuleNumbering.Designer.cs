namespace SRSuite.Controls
{
    partial class RuleNumbering
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
            this.tableLayoutPanel_RuleNumbering = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPatternHelp = new System.Windows.Forms.PictureBox();
            this.labelNbrPattern = new System.Windows.Forms.Label();
            this.textBoxNbrPattern = new System.Windows.Forms.TextBox();
            this.radioButtonNbrAfter = new System.Windows.Forms.RadioButton();
            this.radioButtonNbrBefore = new System.Windows.Forms.RadioButton();
            this.toolTipPattern = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxNbrType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_RuleNumbering.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatternHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_RuleNumbering
            // 
            this.tableLayoutPanel_RuleNumbering.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_RuleNumbering.ColumnCount = 1;
            this.tableLayoutPanel_RuleNumbering.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_RuleNumbering.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_RuleNumbering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_RuleNumbering.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_RuleNumbering.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_RuleNumbering.Name = "tableLayoutPanel_RuleNumbering";
            this.tableLayoutPanel_RuleNumbering.RowCount = 1;
            this.tableLayoutPanel_RuleNumbering.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RuleNumbering.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RuleNumbering.Size = new System.Drawing.Size(253, 98);
            this.tableLayoutPanel_RuleNumbering.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxNbrType);
            this.panel1.Controls.Add(this.pictureBoxPatternHelp);
            this.panel1.Controls.Add(this.labelNbrPattern);
            this.panel1.Controls.Add(this.textBoxNbrPattern);
            this.panel1.Controls.Add(this.radioButtonNbrAfter);
            this.panel1.Controls.Add(this.radioButtonNbrBefore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 93);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxPatternHelp
            // 
            this.pictureBoxPatternHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBoxPatternHelp.Image = global::SRSuite.Properties.Resources.help;
            this.pictureBoxPatternHelp.Location = new System.Drawing.Point(206, 50);
            this.pictureBoxPatternHelp.Name = "pictureBoxPatternHelp";
            this.pictureBoxPatternHelp.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPatternHelp.TabIndex = 5;
            this.pictureBoxPatternHelp.TabStop = false;
            // 
            // labelNbrPattern
            // 
            this.labelNbrPattern.AutoSize = true;
            this.labelNbrPattern.Location = new System.Drawing.Point(6, 53);
            this.labelNbrPattern.Name = "labelNbrPattern";
            this.labelNbrPattern.Size = new System.Drawing.Size(52, 17);
            this.labelNbrPattern.TabIndex = 4;
            this.labelNbrPattern.Text = "Muster:";
            // 
            // textBoxNbrPattern
            // 
            this.textBoxNbrPattern.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxNbrPattern.Location = new System.Drawing.Point(60, 50);
            this.textBoxNbrPattern.MaxLength = 12;
            this.textBoxNbrPattern.Name = "textBoxNbrPattern";
            this.textBoxNbrPattern.Size = new System.Drawing.Size(137, 25);
            this.textBoxNbrPattern.TabIndex = 4;
            this.textBoxNbrPattern.Text = "%nn";
            this.textBoxNbrPattern.WordWrap = false;
            this.textBoxNbrPattern.TextChanged += new System.EventHandler(this.textBoxNbrPattern_TextChanged);
            this.textBoxNbrPattern.Enter += new System.EventHandler(this.textBoxNbrPattern_Enter);
            // 
            // radioButtonNbrAfter
            // 
            this.radioButtonNbrAfter.AutoSize = true;
            this.radioButtonNbrAfter.Location = new System.Drawing.Point(178, 9);
            this.radioButtonNbrAfter.Name = "radioButtonNbrAfter";
            this.radioButtonNbrAfter.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNbrAfter.TabIndex = 3;
            this.radioButtonNbrAfter.TabStop = true;
            this.radioButtonNbrAfter.Text = "Hinten";
            this.radioButtonNbrAfter.UseVisualStyleBackColor = true;
            this.radioButtonNbrAfter.CheckedChanged += new System.EventHandler(this.radioButtonNbrAfter_CheckedChanged);
            // 
            // radioButtonNbrBefore
            // 
            this.radioButtonNbrBefore.AutoSize = true;
            this.radioButtonNbrBefore.Location = new System.Drawing.Point(112, 9);
            this.radioButtonNbrBefore.Name = "radioButtonNbrBefore";
            this.radioButtonNbrBefore.Size = new System.Drawing.Size(60, 21);
            this.radioButtonNbrBefore.TabIndex = 2;
            this.radioButtonNbrBefore.TabStop = true;
            this.radioButtonNbrBefore.Text = "Vorne";
            this.radioButtonNbrBefore.UseVisualStyleBackColor = true;
            this.radioButtonNbrBefore.CheckedChanged += new System.EventHandler(this.radioButtonNbrBefore_CheckedChanged);
            // 
            // toolTipPattern
            // 
            this.toolTipPattern.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPattern.ToolTipTitle = "Muster";
            // 
            // listBoxNbrType
            // 
            this.listBoxNbrType.FormattingEnabled = true;
            this.listBoxNbrType.Items.AddRange(new object[] {
            "Numerisch",
            "Alphabetisch",
            "Römisch"});
            this.listBoxNbrType.Location = new System.Drawing.Point(7, 8);
            this.listBoxNbrType.Name = "listBoxNbrType";
            this.listBoxNbrType.Size = new System.Drawing.Size(98, 25);
            this.listBoxNbrType.TabIndex = 1;
            // 
            // RuleNumbering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel_RuleNumbering);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "RuleNumbering";
            this.Size = new System.Drawing.Size(253, 98);
            this.tableLayoutPanel_RuleNumbering.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatternHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RuleNumbering;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNbrAfter;
        private System.Windows.Forms.RadioButton radioButtonNbrBefore;
        private System.Windows.Forms.Label labelNbrPattern;
        private System.Windows.Forms.TextBox textBoxNbrPattern;
        private System.Windows.Forms.PictureBox pictureBoxPatternHelp;
        private System.Windows.Forms.ToolTip toolTipPattern;
        private System.Windows.Forms.ComboBox listBoxNbrType;
    }
}
