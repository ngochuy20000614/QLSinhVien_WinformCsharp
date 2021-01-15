
namespace QLSinhVien
{
    partial class ThemSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTG_sinhvien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_timkiemsinhvien = new System.Windows.Forms.TextBox();
            this.bt_timkiemsinhvien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTG_sinhvien);
            this.groupBox1.Location = new System.Drawing.Point(18, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng sinh viên";
            // 
            // DTG_sinhvien
            // 
            this.DTG_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.gioiTinh,
            this.namSinh,
            this.maLop,
            this.diaChi});
            this.DTG_sinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_sinhvien.Location = new System.Drawing.Point(3, 16);
            this.DTG_sinhvien.Name = "DTG_sinhvien";
            this.DTG_sinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_sinhvien.Size = new System.Drawing.Size(643, 418);
            this.DTG_sinhvien.TabIndex = 0;
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.Name = "maSV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ và tên";
            this.hoTen.Name = "hoTen";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // namSinh
            // 
            this.namSinh.DataPropertyName = "namSinh";
            this.namSinh.HeaderText = "Ngày sinh";
            this.namSinh.Name = "namSinh";
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "maLop";
            this.maLop.HeaderText = "Lớp";
            this.maLop.Name = "maLop";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // tb_timkiemsinhvien
            // 
            this.tb_timkiemsinhvien.Location = new System.Drawing.Point(102, 41);
            this.tb_timkiemsinhvien.Name = "tb_timkiemsinhvien";
            this.tb_timkiemsinhvien.Size = new System.Drawing.Size(547, 20);
            this.tb_timkiemsinhvien.TabIndex = 2;
            // 
            // bt_timkiemsinhvien
            // 
            this.bt_timkiemsinhvien.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_timkiemsinhvien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_timkiemsinhvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_timkiemsinhvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_timkiemsinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiemsinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiemsinhvien.Location = new System.Drawing.Point(556, 80);
            this.bt_timkiemsinhvien.Name = "bt_timkiemsinhvien";
            this.bt_timkiemsinhvien.Size = new System.Drawing.Size(93, 35);
            this.bt_timkiemsinhvien.TabIndex = 3;
            this.bt_timkiemsinhvien.Text = "Search";
            this.bt_timkiemsinhvien.UseVisualStyleBackColor = false;
            this.bt_timkiemsinhvien.Click += new System.EventHandler(this.bt_timkiemsinhvien_Click);
            // 
            // ThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 528);
            this.Controls.Add(this.bt_timkiemsinhvien);
            this.Controls.Add(this.tb_timkiemsinhvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemSinhVien";
            this.Text = "ThemSinhVien";
            this.Load += new System.EventHandler(this.ThemSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DTG_sinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_timkiemsinhvien;
        private System.Windows.Forms.Button bt_timkiemsinhvien;
    }
}