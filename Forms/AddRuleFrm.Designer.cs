using System.Windows.Forms;

namespace SRSuite.Forms
{
    partial class AddRuleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRuleFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_rtRegRemove = new System.Windows.Forms.Button();
            this.btnImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_rtRegReplace = new System.Windows.Forms.Button();
            this.btn_rtNumbering = new System.Windows.Forms.Button();
            this.btn_rtAppend = new System.Windows.Forms.Button();
            this.btn_rtPrepend = new System.Windows.Forms.Button();
            this.btn_rtReplace = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ruleTypeReplaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruleTypeAppendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeReplaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeAppendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 260);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.Controls.Add(this.btn_rtRegRemove, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_rtRegReplace, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_rtNumbering, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_rtAppend, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_rtPrepend, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_rtReplace, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 260);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_rtRegRemove
            // 
            this.btn_rtRegRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtRegRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtRegRemove.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtRegRemove.ImageKey = "rt_regremove.png";
            this.btn_rtRegRemove.ImageList = this.btnImageList1;
            this.btn_rtRegRemove.Location = new System.Drawing.Point(303, 133);
            this.btn_rtRegRemove.Name = "btn_rtRegRemove";
            this.btn_rtRegRemove.Size = new System.Drawing.Size(150, 124);
            this.btn_rtRegRemove.TabIndex = 7;
            this.btn_rtRegRemove.Text = "Löschen (Rege&x)";
            this.btn_rtRegRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtRegRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtRegRemove.UseVisualStyleBackColor = true;
            this.btn_rtRegRemove.Click += new System.EventHandler(this.btn_rtRegRemove_Click);
            // 
            // btnImageList1
            // 
            this.btnImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnImageList1.ImageStream")));
            this.btnImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.btnImageList1.Images.SetKeyName(0, "rt_append.png");
            this.btnImageList1.Images.SetKeyName(1, "rt_numbering.png");
            this.btnImageList1.Images.SetKeyName(2, "rt_prepend.png");
            this.btnImageList1.Images.SetKeyName(3, "rt_regremove.png");
            this.btnImageList1.Images.SetKeyName(4, "rt_regreplace.png");
            this.btnImageList1.Images.SetKeyName(5, "rt_replace.png");
            // 
            // btn_rtRegReplace
            // 
            this.btn_rtRegReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtRegReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtRegReplace.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtRegReplace.ImageKey = "rt_regreplace.png";
            this.btn_rtRegReplace.ImageList = this.btnImageList1;
            this.btn_rtRegReplace.Location = new System.Drawing.Point(153, 133);
            this.btn_rtRegReplace.Name = "btn_rtRegReplace";
            this.btn_rtRegReplace.Size = new System.Drawing.Size(144, 124);
            this.btn_rtRegReplace.TabIndex = 6;
            this.btn_rtRegReplace.Text = "Ersetzen (&Regex)";
            this.btn_rtRegReplace.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtRegReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtRegReplace.UseVisualStyleBackColor = true;
            this.btn_rtRegReplace.Click += new System.EventHandler(this.btn_rtRegReplace_Click);
            // 
            // btn_rtNumbering
            // 
            this.btn_rtNumbering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtNumbering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtNumbering.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtNumbering.ImageKey = "rt_numbering.png";
            this.btn_rtNumbering.ImageList = this.btnImageList1;
            this.btn_rtNumbering.Location = new System.Drawing.Point(3, 133);
            this.btn_rtNumbering.Name = "btn_rtNumbering";
            this.btn_rtNumbering.Size = new System.Drawing.Size(144, 124);
            this.btn_rtNumbering.TabIndex = 5;
            this.btn_rtNumbering.Text = "&Nummerieren";
            this.btn_rtNumbering.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtNumbering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtNumbering.UseVisualStyleBackColor = true;
            this.btn_rtNumbering.Click += new System.EventHandler(this.btn_rtNumbering_Click);
            // 
            // btn_rtAppend
            // 
            this.btn_rtAppend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtAppend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtAppend.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtAppend.ImageKey = "rt_append.png";
            this.btn_rtAppend.ImageList = this.btnImageList1;
            this.btn_rtAppend.Location = new System.Drawing.Point(303, 3);
            this.btn_rtAppend.Name = "btn_rtAppend";
            this.btn_rtAppend.Size = new System.Drawing.Size(150, 124);
            this.btn_rtAppend.TabIndex = 4;
            this.btn_rtAppend.Text = "&Hinten anfügen";
            this.btn_rtAppend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtAppend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtAppend.UseVisualStyleBackColor = true;
            this.btn_rtAppend.Click += new System.EventHandler(this.btn_rtAppend_Click);
            // 
            // btn_rtPrepend
            // 
            this.btn_rtPrepend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtPrepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtPrepend.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtPrepend.ImageKey = "rt_prepend.png";
            this.btn_rtPrepend.ImageList = this.btnImageList1;
            this.btn_rtPrepend.Location = new System.Drawing.Point(153, 3);
            this.btn_rtPrepend.Name = "btn_rtPrepend";
            this.btn_rtPrepend.Size = new System.Drawing.Size(144, 124);
            this.btn_rtPrepend.TabIndex = 3;
            this.btn_rtPrepend.Text = "&Vorne anfügen";
            this.btn_rtPrepend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtPrepend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtPrepend.UseVisualStyleBackColor = true;
            this.btn_rtPrepend.Click += new System.EventHandler(this.btn_rtPrepend_Click);
            // 
            // btn_rtReplace
            // 
            this.btn_rtReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rtReplace.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtReplace.ImageKey = "rt_replace.png";
            this.btn_rtReplace.ImageList = this.btnImageList1;
            this.btn_rtReplace.Location = new System.Drawing.Point(3, 3);
            this.btn_rtReplace.Name = "btn_rtReplace";
            this.btn_rtReplace.Size = new System.Drawing.Size(144, 124);
            this.btn_rtReplace.TabIndex = 2;
            this.btn_rtReplace.Text = "Suchen && &Ersetzen";
            this.btn_rtReplace.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rtReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rtReplace.UseVisualStyleBackColor = true;
            this.btn_rtReplace.Click += new System.EventHandler(this.btn_rtReplace_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 29);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(371, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancel);
            // 
            // ruleTypeReplaceBindingSource
            // 
            this.ruleTypeReplaceBindingSource.DataSource = typeof(SRSuite.Classes.RuleTypeReplace);
            // 
            // ruleTypeAppendBindingSource
            // 
            this.ruleTypeAppendBindingSource.DataSource = typeof(SRSuite.Classes.RuleTypeAppend);
            // 
            // ruleTypeBindingSource
            // 
            this.ruleTypeBindingSource.DataSource = typeof(SRSuite.Classes.RuleType);
            // 
            // AddRuleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRuleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neue Regel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeReplaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeAppendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource ruleTypeBindingSource;
        private System.Windows.Forms.BindingSource ruleTypeReplaceBindingSource;
        private System.Windows.Forms.BindingSource ruleTypeAppendBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_rtReplace;
        private ImageList btnImageList1;
        private Button btn_rtPrepend;
        private Button btn_rtAppend;
        private Button btn_rtRegRemove;
        private Button btn_rtRegReplace;
        private Button btn_rtNumbering;
    }

}