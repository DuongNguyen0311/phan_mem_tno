namespace phan_mem_TN
{
    partial class KetQua
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comLopHP = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.grdKetQua = new System.Windows.Forms.DataGridView();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn học:";
            // 
            // comMonHoc
            // 
            this.comMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMonHoc.FormattingEnabled = true;
            this.comMonHoc.Location = new System.Drawing.Point(155, 9);
            this.comMonHoc.Name = "comMonHoc";
            this.comMonHoc.Size = new System.Drawing.Size(318, 28);
            this.comMonHoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp học phần:";
            // 
            // comLopHP
            // 
            this.comLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comLopHP.FormattingEnabled = true;
            this.comLopHP.Location = new System.Drawing.Point(155, 53);
            this.comLopHP.Name = "comLopHP";
            this.comLopHP.Size = new System.Drawing.Size(318, 28);
            this.comLopHP.TabIndex = 4;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(511, 26);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(47, 37);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // grdKetQua
            // 
            this.grdKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKetQua.Location = new System.Drawing.Point(-1, 113);
            this.grdKetQua.Name = "grdKetQua";
            this.grdKetQua.RowHeadersWidth = 51;
            this.grdKetQua.RowTemplate.Height = 24;
            this.grdKetQua.Size = new System.Drawing.Size(1151, 387);
            this.grdKetQua.TabIndex = 6;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(1018, 515);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(121, 50);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = false;
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 586);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.grdKetQua);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.comLopHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KetQua";
            this.Text = "KetQua";
            this.Load += new System.EventHandler(this.KetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comLopHP;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView grdKetQua;
        private System.Windows.Forms.Button btnXuat;
    }
}