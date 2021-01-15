using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace QLSinhVien
{
    public partial class frmHocPhan : Form
    {

        private ConnectDB db = new ConnectDB();
        SqlConnection conn = null;

        public frmHocPhan()
        {
            InitializeComponent();
        }

        private void txtSoTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoTC.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ nhập số !!!");
                txtSoTC.Text = txtSoTC.Text.Remove(txtSoTC.Text.Length - 1);
            }
        }
        private void LoadHocPhan()
        {
            // Thực hiện truy vấn
            string select = "SELECT maHP 'Mã học phần', tenHP 'Tên học phần', soTC 'Tín chỉ' FROM HocPhan";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "HOCPHAN");

            // Đưa ra DataGridView
            dtgHP.DataSource = ds;
            dtgHP.DataMember = "HOCPHAN";
            cmd.Dispose();
        }

        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            conn = db.Connected();
            if (conn.State == ConnectionState.Open) ;
            LoadHocPhan();

        }

        private void dtgHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgHP.CurrentRow.Index != -1)
                {
                    txtMaHP.Text = dtgHP.CurrentRow.Cells[0].Value.ToString();
                    txtTenHP.Text = dtgHP.CurrentRow.Cells[1].Value.ToString();
                    txtSoTC.Text = dtgHP.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá học phần này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "DELETE FROM HocPhan WHERE maHP = '" + txtMaHP.Text + "' ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa học phần thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                LoadHocPhan();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string select1 = "SELECT maHP, tenHP FROM HocPhan WHERE maHP = '"+ txtMaHP +"'";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (txtMaHP.Text == "")
            {
                MessageBox.Show("Mã học phần không được để trống", "Thông báo!");
                txtMaHP.Focus();
            }
            else if (txtTenHP.Text == "")
            {
                MessageBox.Show("Tên học phần không được để trống", "Thông báo!");
                txtTenHP.Focus();
            }
            else if (txtSoTC.Text == "")
            {
                MessageBox.Show("Số tín chỉ không được để trống", "Thông báo!");
                txtSoTC.Focus();
            }
            else if (reader1.Read())
            {
                {
                    MessageBox.Show("Mã môn học hoặc tên bị trùng!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHP.Focus();

                }

                //Download source code tại Sharecode.vn
                //Tra tai nguyen 
                reader1.Dispose();
                cmd1.Dispose();
            }
            else
            {
                try { 
                reader1.Dispose();
                cmd1.Dispose();
                // Thực hiện truy vấn
                string insert = "INSERT  INTO dbo.HocPhan ( maHP, tenHP, soTC ) VALUES  ( '" + txtMaHP.Text + "', N'"+ txtTenHP.Text +"', "+ txtSoTC.Text +")";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới học phần thành công", "Thông báo!");

                // Trả tài nguyên


                cmd.Dispose();
                //Fill du lieu vao Database
                LoadHocPhan();
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi "+ex.Message);
                }
            }
            reader1.Dispose();
            cmd1.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                try
                {
                    string update = "UPDATE HocPhan SET tenHP  = '" + txtTenHP.Text + "', soTC = '" + txtSoTC.Text + "' WHERE maHP = '" + txtSoTC.Text + "'";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật học phần thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Load lai du lieu
                    LoadHocPhan();
                    // Trả tài nguyên
                    cmd.Dispose();
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }

        }

        private void dtgHP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtgHP.Columns[0].Width = 110;
            dtgHP.Columns[1].Width = 250;
            dtgHP.Columns[2].Width = 100;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
