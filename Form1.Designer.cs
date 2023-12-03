namespace PDFWatermark
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogPDF = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPdfFiles = new System.Windows.Forms.ListBox();
            this.btOpenfile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPdfFiles);
            this.groupBox1.Controls.Add(this.btMark);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btOpenfile);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作区";
            // 
            // btMark
            // 
            this.btMark.Location = new System.Drawing.Point(8, 216);
            this.btMark.Name = "btMark";
            this.btMark.Size = new System.Drawing.Size(462, 23);
            this.btMark.TabIndex = 5;
            this.btMark.Text = "开始添加水印";
            this.btMark.UseVisualStyleBackColor = true;
            this.btMark.Click += new System.EventHandler(this.btMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择 PDF：";
            // 
            // openFileDialogPDF
            // 
            this.openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf";
            this.openFileDialogPDF.Multiselect = true;
            this.openFileDialogPDF.Title = "请选择需要加水印的PDF文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "测试软件，pdf 添加水印。";
            // 
            // lbPdfFiles
            // 
            this.lbPdfFiles.FormattingEnabled = true;
            this.lbPdfFiles.ItemHeight = 12;
            this.lbPdfFiles.Location = new System.Drawing.Point(8, 42);
            this.lbPdfFiles.Name = "lbPdfFiles";
            this.lbPdfFiles.Size = new System.Drawing.Size(462, 160);
            this.lbPdfFiles.TabIndex = 6;
            // 
            // btOpenfile
            // 
            this.btOpenfile.Location = new System.Drawing.Point(401, 16);
            this.btOpenfile.Name = "btOpenfile";
            this.btOpenfile.Size = new System.Drawing.Size(75, 23);
            this.btOpenfile.TabIndex = 0;
            this.btOpenfile.Text = "选择";
            this.btOpenfile.UseVisualStyleBackColor = true;
            this.btOpenfile.Click += new System.EventHandler(this.btOpenfile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF 添加水印";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPDF;
        private System.Windows.Forms.Button btMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPdfFiles;
        private System.Windows.Forms.Button btOpenfile;
    }
}

