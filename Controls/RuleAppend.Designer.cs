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
            this.textBox_RuleAppend_Append = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_RuleAppend_Append
            // 
            this.textBox_RuleAppend_Append.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RuleAppend_Append.Location = new System.Drawing.Point(0, 3);
            this.textBox_RuleAppend_Append.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_RuleAppend_Append.MaxLength = 250;
            this.textBox_RuleAppend_Append.Name = "textBox_RuleAppend_Append";
            this.textBox_RuleAppend_Append.Size = new System.Drawing.Size(270, 25);
            this.textBox_RuleAppend_Append.TabIndex = 2;
            // 
            // RuleAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox_RuleAppend_Append);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(200, 32);
            this.Name = "RuleAppend";
            this.Size = new System.Drawing.Size(270, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_RuleAppend_Append;
    }
}
