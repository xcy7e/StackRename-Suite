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
            this.textBox_RulePrepend_Prepend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_RulePrepend_Prepend
            // 
            this.textBox_RulePrepend_Prepend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RulePrepend_Prepend.Location = new System.Drawing.Point(0, 3);
            this.textBox_RulePrepend_Prepend.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RulePrepend_Prepend.MaxLength = 250;
            this.textBox_RulePrepend_Prepend.Name = "textBox_RulePrepend_Prepend";
            this.textBox_RulePrepend_Prepend.Size = new System.Drawing.Size(234, 25);
            this.textBox_RulePrepend_Prepend.TabIndex = 4;
            // 
            // RulePrepend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox_RulePrepend_Prepend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(200, 32);
            this.Name = "RulePrepend";
            this.Size = new System.Drawing.Size(234, 32);
            this.SizeChanged += new System.EventHandler(this.RulePrepend_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.TextBox textBox_RulePrepend_Prepend;
    }
}
