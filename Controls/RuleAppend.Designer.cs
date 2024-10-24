namespace SRSuite.Controls
{
    partial class RuleAppend
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
            this.tableLayoutPanel_RuleAppend = new System.Windows.Forms.TableLayoutPanel();
            this.label_RuleAppend_Append = new System.Windows.Forms.Label();
            this.textBox_RuleAppend_Append = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_RuleAppend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_RuleAppend
            // 
            this.tableLayoutPanel_RuleAppend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_RuleAppend.ColumnCount = 1;
            this.tableLayoutPanel_RuleAppend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_RuleAppend.Controls.Add(this.label_RuleAppend_Append, 0, 0);
            this.tableLayoutPanel_RuleAppend.Controls.Add(this.textBox_RuleAppend_Append, 0, 1);
            this.tableLayoutPanel_RuleAppend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_RuleAppend.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_RuleAppend.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_RuleAppend.Name = "tableLayoutPanel_RuleAppend";
            this.tableLayoutPanel_RuleAppend.RowCount = 2;
            this.tableLayoutPanel_RuleAppend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RuleAppend.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RuleAppend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RuleAppend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RuleAppend.Size = new System.Drawing.Size(270, 64);
            this.tableLayoutPanel_RuleAppend.TabIndex = 0;
            // 
            // label_RuleAppend_Append
            // 
            this.label_RuleAppend_Append.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_RuleAppend_Append.Location = new System.Drawing.Point(4, 0);
            this.label_RuleAppend_Append.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RuleAppend_Append.Name = "label_RuleAppend_Append";
            this.label_RuleAppend_Append.Size = new System.Drawing.Size(262, 20);
            this.label_RuleAppend_Append.TabIndex = 0;
            this.label_RuleAppend_Append.Text = "Hinten anfügen";
            // 
            // textBox_RuleAppend_Append
            // 
            this.textBox_RuleAppend_Append.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RuleAppend_Append.Location = new System.Drawing.Point(4, 24);
            this.textBox_RuleAppend_Append.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RuleAppend_Append.Name = "textBox_RuleAppend_Append";
            this.textBox_RuleAppend_Append.Size = new System.Drawing.Size(262, 25);
            this.textBox_RuleAppend_Append.TabIndex = 1;
            this.textBox_RuleAppend_Append.TextChanged += new System.EventHandler(this.textBox_RuleAppend_Append_TextChanged);
            this.textBox_RuleAppend_Append.Enter += new System.EventHandler(this.textBox_RuleAppend_Append_Enter);
            this.textBox_RuleAppend_Append.Leave += new System.EventHandler(this.applyRule);
            // 
            // RuleAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel_RuleAppend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "RuleAppend";
            this.Size = new System.Drawing.Size(270, 64);
            this.tableLayoutPanel_RuleAppend.ResumeLayout(false);
            this.tableLayoutPanel_RuleAppend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RuleAppend;
        public System.Windows.Forms.Label label_RuleAppend_Append;
        public System.Windows.Forms.TextBox textBox_RuleAppend_Append;
    }
}
