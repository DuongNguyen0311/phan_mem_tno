namespace phan_mem_TN
{
    partial class FrmThi
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
            this.btnNopBai = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblMonThi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTraLoi = new System.Windows.Forms.Panel();
            this.grbCau2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grbCau1 = new System.Windows.Forms.GroupBox();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.pnlDeBai = new System.Windows.Forms.Panel();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.rtbDeBai = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTraLoi.SuspendLayout();
            this.grbCau2.SuspendLayout();
            this.grbCau1.SuspendLayout();
            this.pnlDeBai.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNopBai
            // 
            this.btnNopBai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.Color.Red;
            this.btnNopBai.Location = new System.Drawing.Point(889, 22);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(115, 54);
            this.btnNopBai.TabIndex = 0;
            this.btnNopBai.Text = "Nộp Bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblThoiGian);
            this.pnlHeader.Controls.Add(this.lblMonThi);
            this.pnlHeader.Controls.Add(this.lblHoTen);
            this.pnlHeader.Controls.Add(this.lblMaSV);
            this.pnlHeader.Controls.Add(this.btnNopBai);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1026, 103);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lblThoiGian.Location = new System.Drawing.Point(427, 51);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(227, 25);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "Thời gian còn lại: 60p";
            // 
            // lblMonThi
            // 
            this.lblMonThi.AutoSize = true;
            this.lblMonThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonThi.Location = new System.Drawing.Point(427, 8);
            this.lblMonThi.Name = "lblMonThi";
            this.lblMonThi.Size = new System.Drawing.Size(286, 25);
            this.lblMonThi.TabIndex = 3;
            this.lblMonThi.Text = "Môn thi: Tin học đại cương";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(30, 51);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(274, 25);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và Tên: Nguyễn Văn A";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(30, 8);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(189, 25);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã SV: 11232234";
            this.lblMaSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlMain.Controls.Add(this.pnlTraLoi);
            this.pnlMain.Controls.Add(this.pnlDeBai);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 103);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1026, 492);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlTraLoi
            // 
            this.pnlTraLoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlTraLoi.Controls.Add(this.grbCau2);
            this.pnlTraLoi.Controls.Add(this.grbCau1);
            this.pnlTraLoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTraLoi.Location = new System.Drawing.Point(728, 0);
            this.pnlTraLoi.Name = "pnlTraLoi";
            this.pnlTraLoi.Size = new System.Drawing.Size(298, 492);
            this.pnlTraLoi.TabIndex = 1;
            // 
            // grbCau2
            // 
            this.grbCau2.Controls.Add(this.radioButton1);
            this.grbCau2.Controls.Add(this.radioButton2);
            this.grbCau2.Controls.Add(this.radioButton3);
            this.grbCau2.Controls.Add(this.radioButton4);
            this.grbCau2.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCau2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCau2.Location = new System.Drawing.Point(0, 61);
            this.grbCau2.Name = "grbCau2";
            this.grbCau2.Size = new System.Drawing.Size(298, 61);
            this.grbCau2.TabIndex = 1;
            this.grbCau2.TabStop = false;
            this.grbCau2.Text = "Câu 2:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(207, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 30);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "D";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 30);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(84, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 30);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 30);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // grbCau1
            // 
            this.grbCau1.Controls.Add(this.rdoD);
            this.grbCau1.Controls.Add(this.rdoC);
            this.grbCau1.Controls.Add(this.rdoB);
            this.grbCau1.Controls.Add(this.rdoA);
            this.grbCau1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCau1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCau1.Location = new System.Drawing.Point(0, 0);
            this.grbCau1.Name = "grbCau1";
            this.grbCau1.Size = new System.Drawing.Size(298, 61);
            this.grbCau1.TabIndex = 0;
            this.grbCau1.TabStop = false;
            this.grbCau1.Text = "Câu 1:";
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(207, 22);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(49, 30);
            this.rdoD.TabIndex = 3;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(143, 22);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(48, 30);
            this.rdoC.TabIndex = 2;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(84, 22);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(47, 30);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(17, 21);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(49, 30);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // pnlDeBai
            // 
            this.pnlDeBai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeBai.Controls.Add(this.lblCauHoi);
            this.pnlDeBai.Controls.Add(this.rtbDeBai);
            this.pnlDeBai.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDeBai.Location = new System.Drawing.Point(0, 0);
            this.pnlDeBai.Name = "pnlDeBai";
            this.pnlDeBai.Size = new System.Drawing.Size(728, 492);
            this.pnlDeBai.TabIndex = 0;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(11, 19);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(555, 22);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Chỗ group box 2 chưa sửa và tìm hiểu lại xem làm thế nào để tự động";
            this.lblCauHoi.Click += new System.EventHandler(this.lblCauHoi_Click);
            // 
            // rtbDeBai
            // 
            this.rtbDeBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDeBai.Location = new System.Drawing.Point(0, 0);
            this.rtbDeBai.Name = "rtbDeBai";
            this.rtbDeBai.ReadOnly = true;
            this.rtbDeBai.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDeBai.Size = new System.Drawing.Size(726, 490);
            this.rtbDeBai.TabIndex = 0;
            this.rtbDeBai.Text = "";
            this.rtbDeBai.TextChanged += new System.EventHandler(this.rtbDeBai_TextChanged);
            // 
            // FrmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 595);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmThi";
            this.Text = "FrmThi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTraLoi.ResumeLayout(false);
            this.grbCau2.ResumeLayout(false);
            this.grbCau2.PerformLayout();
            this.grbCau1.ResumeLayout(false);
            this.grbCau1.PerformLayout();
            this.pnlDeBai.ResumeLayout(false);
            this.pnlDeBai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblMonThi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlDeBai;
        private System.Windows.Forms.RichTextBox rtbDeBai;
        private System.Windows.Forms.Panel pnlTraLoi;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.GroupBox grbCau1;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.GroupBox grbCau2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}