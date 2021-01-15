
namespace QLSinhVien
{
    partial class Form1
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
            this.DGV_thongtinsinhvien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTCDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTCTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_sotinchitichluy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_themsinhvien = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_diemtrungbinh = new System.Windows.Forms.TextBox();
            this.tb_sotinchi = new System.Windows.Forms.TextBox();
            this.tb_hocki = new System.Windows.Forms.TextBox();
            this.tb_masinhvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBB_theohocki = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xuatxml = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_thongtinsinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_thongtinsinhvien
            // 
            this.DGV_thongtinsinhvien.AllowUserToOrderColumns = true;
            this.DGV_thongtinsinhvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_thongtinsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_thongtinsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.sTCDK,
            this.dTBC,
            this.maHK,
            this.sTCTL});
            this.DGV_thongtinsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_thongtinsinhvien.Location = new System.Drawing.Point(3, 16);
            this.DGV_thongtinsinhvien.Name = "DGV_thongtinsinhvien";
            this.DGV_thongtinsinhvien.RowHeadersVisible = false;
            this.DGV_thongtinsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_thongtinsinhvien.Size = new System.Drawing.Size(532, 353);
            this.DGV_thongtinsinhvien.TabIndex = 0;
            this.DGV_thongtinsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_thongtinsinhvien_CellContentClick);
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.Name = "maSV";
            this.maSV.Width = 110;
            // 
            // sTCDK
            // 
            this.sTCDK.DataPropertyName = "sTCDK";
            this.sTCDK.HeaderText = "Số tín chỉ";
            this.sTCDK.Name = "sTCDK";
            // 
            // dTBC
            // 
            this.dTBC.DataPropertyName = "dTBC";
            this.dTBC.HeaderText = "Điểm trung bình";
            this.dTBC.Name = "dTBC";
            this.dTBC.Width = 110;
            // 
            // maHK
            // 
            this.maHK.DataPropertyName = "maHK";
            this.maHK.HeaderText = "Học kì";
            this.maHK.Name = "maHK";
            // 
            // sTCTL
            // 
            this.sTCTL.DataPropertyName = "sTCTL";
            this.sTCTL.HeaderText = "Tín chỉ tích lũy";
            this.sTCTL.Name = "sTCTL";
            this.sTCTL.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_thongtinsinhvien);
            this.groupBox1.Location = new System.Drawing.Point(372, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_sotinchitichluy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.bt_themsinhvien);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.tb_diemtrungbinh);
            this.groupBox2.Controls.Add(this.tb_sotinchi);
            this.groupBox2.Controls.Add(this.tb_hocki);
            this.groupBox2.Controls.Add(this.tb_masinhvien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 442);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sinh viên";
            // 
            // tb_sotinchitichluy
            // 
            this.tb_sotinchitichluy.Location = new System.Drawing.Point(132, 251);
            this.tb_sotinchitichluy.Name = "tb_sotinchitichluy";
            this.tb_sotinchitichluy.Size = new System.Drawing.Size(100, 21);
            this.tb_sotinchitichluy.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số tín chỉ tích lũy";
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Aquamarine;
            this.bt_them.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.bt_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Location = new System.Drawing.Point(9, 308);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(88, 35);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_themsinhvien
            // 
            this.bt_themsinhvien.BackColor = System.Drawing.Color.Blue;
            this.bt_themsinhvien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_themsinhvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_themsinhvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_themsinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_themsinhvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_themsinhvien.Location = new System.Drawing.Point(9, 27);
            this.bt_themsinhvien.Name = "bt_themsinhvien";
            this.bt_themsinhvien.Size = new System.Drawing.Size(151, 40);
            this.bt_themsinhvien.TabIndex = 6;
            this.bt_themsinhvien.Text = "Danh sách sinh viên";
            this.bt_themsinhvien.UseVisualStyleBackColor = false;
            this.bt_themsinhvien.Click += new System.EventHandler(this.bt_themsinhvien_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_sua.Location = new System.Drawing.Point(127, 308);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(89, 35);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Red;
            this.bt_xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(245, 308);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(89, 35);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_diemtrungbinh
            // 
            this.tb_diemtrungbinh.Location = new System.Drawing.Point(132, 208);
            this.tb_diemtrungbinh.Name = "tb_diemtrungbinh";
            this.tb_diemtrungbinh.Size = new System.Drawing.Size(118, 21);
            this.tb_diemtrungbinh.TabIndex = 1;
            // 
            // tb_sotinchi
            // 
            this.tb_sotinchi.Location = new System.Drawing.Point(132, 168);
            this.tb_sotinchi.Name = "tb_sotinchi";
            this.tb_sotinchi.Size = new System.Drawing.Size(97, 21);
            this.tb_sotinchi.TabIndex = 1;
            // 
            // tb_hocki
            // 
            this.tb_hocki.Location = new System.Drawing.Point(132, 127);
            this.tb_hocki.Name = "tb_hocki";
            this.tb_hocki.Size = new System.Drawing.Size(118, 21);
            this.tb_hocki.TabIndex = 1;
            // 
            // tb_masinhvien
            // 
            this.tb_masinhvien.Location = new System.Drawing.Point(132, 85);
            this.tb_masinhvien.Name = "tb_masinhvien";
            this.tb_masinhvien.Size = new System.Drawing.Size(202, 21);
            this.tb_masinhvien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm trung bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tín chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học kì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // CBB_theohocki
            // 
            this.CBB_theohocki.FormattingEnabled = true;
            this.CBB_theohocki.Location = new System.Drawing.Point(375, 117);
            this.CBB_theohocki.Name = "CBB_theohocki";
            this.CBB_theohocki.Size = new System.Drawing.Size(217, 21);
            this.CBB_theohocki.TabIndex = 3;
            this.CBB_theohocki.SelectedIndexChanged += new System.EventHandler(this.CBB_theohocki_SelectedIndexChanged);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(375, 70);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(319, 20);
            this.tb_timkiem.TabIndex = 4;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_timkiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiem.Location = new System.Drawing.Point(713, 63);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(77, 32);
            this.bt_timkiem.TabIndex = 5;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhập mã sinh viên muốn tìm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Học kì";
            // 
            // xuatxml
            // 
            this.xuatxml.BackColor = System.Drawing.Color.Turquoise;
            this.xuatxml.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.xuatxml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuatxml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuatxml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuatxml.Location = new System.Drawing.Point(713, 115);
            this.xuatxml.Name = "xuatxml";
            this.xuatxml.Size = new System.Drawing.Size(66, 23);
            this.xuatxml.TabIndex = 7;
            this.xuatxml.Text = "Xuất XML";
            this.xuatxml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xuatxml.UseVisualStyleBackColor = false;
            this.xuatxml.Click += new System.EventHandler(this.xuatxml_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(258, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "CẬP NHẬT ĐIỂM SINH VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 505);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.xuatxml);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.CBB_theohocki);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_thongtinsinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_thongtinsinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_diemtrungbinh;
        private System.Windows.Forms.TextBox tb_sotinchi;
        private System.Windows.Forms.TextBox tb_hocki;
        private System.Windows.Forms.TextBox tb_masinhvien;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ComboBox CBB_theohocki;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button xuatxml;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button bt_themsinhvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTCDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTCTL;
        private System.Windows.Forms.TextBox tb_sotinchitichluy;
        private System.Windows.Forms.Label label3;
    }
}

