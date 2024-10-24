namespace SRSuite.Controls
{
    partial class RulePrepend
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
            this.tableLayoutPanel_RulePrepend = new System.Windows.Forms.TableLayoutPanel();
            this.label_RulePrepend_Prepend = new System.Windows.Forms.Label();
            this.textBox_RulePrepend_Prepend = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_RulePrepend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_RulePrepend
            // 
            this.tableLayoutPanel_RulePrepend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_RulePrepend.ColumnCount = 1;
            this.tableLayoutPanel_RulePrepend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_RulePrepend.Controls.Add(this.label_RulePrepend_Prepend, 0, 0);
            this.tableLayoutPanel_RulePrepend.Controls.Add(this.textBox_RulePrepend_Prepend, 0, 1);
            this.tableLayoutPanel_RulePrepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_RulePrepend.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_RulePrepend.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_RulePrepend.Name = "tableLayoutPanel_RulePrepend";
            this.tableLayoutPanel_RulePrepend.RowCount = 2;
            this.tableLayoutPanel_RulePrepend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RulePrepend.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RulePrepend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RulePrepend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_RulePrepend.Size = new System.Drawing.Size(270, 64);
            this.tableLayoutPanel_RulePrepend.TabIndex = 0;
            // 
            // label_RulePrepend_Prepend
            // 
            this.label_RulePrepend_Prepend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_RulePrepend_Prepend.Location = new System.Drawing.Point(4, 0);
            this.label_RulePrepend_Prepend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RulePrepend_Prepend.Name = "label_RulePrepend_Prepend";
            this.label_RulePrepend_Prepend.Size = new System.Drawing.Size(262, 20);
            this.label_RulePrepend_Prepend.TabIndex = 0;
            this.label_RulePrepend_Prepend.Text = "Vorne anfügen";
            // 
            // textBox_RulePrepend_Prepend
            // 
            this.textBox_RulePrepend_Prepend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RulePrepend_Prepend.Location = new System.Drawing.Point(4, 24);
            this.textBox_RulePrepend_Prepend.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RulePrepend_Prepend.Name = "textBox_RulePrepend_Prepend";
            this.textBox_RulePrepend_Prepend.Size = new System.Drawing.Size(262, 25);
            this.textBox_RulePrepend_Prepend.TabIndex = 1;
            this.textBox_RulePrepend_Prepend.TextChanged += new System.EventHandler(this.textBox_RulePrepend_Prepend_TextChanged);
            this.textBox_RulePrepend_Prepend.Enter += new System.EventHandler(this.textBox_RulePrepend_Prepend_Enter);
            this.textBox_RulePrepend_Prepend.Leave += new System.EventHandler(this.applyRule);
            // 
            // RulePrepend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel_RulePrepend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "RulePrepend";
            this.Size = new System.Drawing.Size(270, 64);
            this.tableLayoutPanel_RulePrepend.ResumeLayout(false);
            this.tableLayoutPanel_RulePrepend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RulePrepend;
        public System.Windows.Forms.Label label_RulePrepend_Prepend;
        public System.Windows.Forms.TextBox textBox_RulePrepend_Prepend;
    }
}
