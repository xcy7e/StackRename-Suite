namespace SRSuite.Controls
{
    partial class RuleReplace
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
            this.tableLayoutPanel_RuleReplace = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_RuleReplace_Replace = new System.Windows.Forms.TextBox();
            this.label_RuleReplace_Search = new System.Windows.Forms.Label();
            this.label_RuleReplace_Replace = new System.Windows.Forms.Label();
            this.textBox_RuleReplace_Search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_RuleReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_RuleReplace
            // 
            this.tableLayoutPanel_RuleReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_RuleReplace.ColumnCount = 1;
            this.tableLayoutPanel_RuleReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_RuleReplace.Controls.Add(this.textBox_RuleReplace_Replace, 0, 3);
            this.tableLayoutPanel_RuleReplace.Controls.Add(this.label_RuleReplace_Search, 0, 0);
            this.tableLayoutPanel_RuleReplace.Controls.Add(this.label_RuleReplace_Replace, 0, 2);
            this.tableLayoutPanel_RuleReplace.Controls.Add(this.textBox_RuleReplace_Search, 0, 1);
            this.tableLayoutPanel_RuleReplace.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_RuleReplace.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_RuleReplace.Name = "tableLayoutPanel_RuleReplace";
            this.tableLayoutPanel_RuleReplace.RowCount = 4;
            this.tableLayoutPanel_RuleReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RuleReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RuleReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel_RuleReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RuleReplace.Size = new System.Drawing.Size(240, 108);
            this.tableLayoutPanel_RuleReplace.TabIndex = 0;
            // 
            // textBox_RuleReplace_Replace
            // 
            this.textBox_RuleReplace_Replace.Location = new System.Drawing.Point(3, 75);
            this.textBox_RuleReplace_Replace.Name = "textBox_RuleReplace_Replace";
            this.textBox_RuleReplace_Replace.Size = new System.Drawing.Size(237, 25);
            this.textBox_RuleReplace_Replace.TabIndex = 5;
            this.textBox_RuleReplace_Replace.TextChanged += new System.EventHandler(this.textBox_RuleReplace_Replace_TextChanged);
            this.textBox_RuleReplace_Replace.Enter += new System.EventHandler(this.textBox_RuleReplace_Replace_Enter);
            this.textBox_RuleReplace_Replace.Leave += new System.EventHandler(this.applyRule);
            // 
            // label_RuleReplace_Search
            // 
            this.label_RuleReplace_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_RuleReplace_Search.Location = new System.Drawing.Point(4, 0);
            this.label_RuleReplace_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RuleReplace_Search.Name = "label_RuleReplace_Search";
            this.label_RuleReplace_Search.Size = new System.Drawing.Size(262, 20);
            this.label_RuleReplace_Search.TabIndex = 0;
            this.label_RuleReplace_Search.Text = "Suchen";
            // 
            // label_RuleReplace_Replace
            // 
            this.label_RuleReplace_Replace.AutoSize = true;
            this.label_RuleReplace_Replace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_RuleReplace_Replace.Location = new System.Drawing.Point(3, 55);
            this.label_RuleReplace_Replace.Name = "label_RuleReplace_Replace";
            this.label_RuleReplace_Replace.Size = new System.Drawing.Size(264, 17);
            this.label_RuleReplace_Replace.TabIndex = 2;
            this.label_RuleReplace_Replace.Text = "Ersetzen";
            // 
            // textBox_RuleReplace_Search
            // 
            this.textBox_RuleReplace_Search.Location = new System.Drawing.Point(4, 24);
            this.textBox_RuleReplace_Search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RuleReplace_Search.Name = "textBox_RuleReplace_Search";
            this.textBox_RuleReplace_Search.Size = new System.Drawing.Size(236, 25);
            this.textBox_RuleReplace_Search.TabIndex = 1;
            this.textBox_RuleReplace_Search.TextChanged += new System.EventHandler(this.textBox_RuleReplace_Search_TextChanged);
            this.textBox_RuleReplace_Search.Leave += new System.EventHandler(this.applyRule);
            // 
            // RuleReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel_RuleReplace);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.MinimumSize = new System.Drawing.Size(240, 98);
            this.Name = "RuleReplace";
            this.Size = new System.Drawing.Size(242, 112);
            this.tableLayoutPanel_RuleReplace.ResumeLayout(false);
            this.tableLayoutPanel_RuleReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RuleReplace;
        public System.Windows.Forms.Label label_RuleReplace_Search;
        public System.Windows.Forms.TextBox textBox_RuleReplace_Search;
        public System.Windows.Forms.TextBox textBox_RuleReplace_Replace;
        public System.Windows.Forms.Label label_RuleReplace_Replace;
    }
}
