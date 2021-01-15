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
    public partial class frmLogin : Form
    {
        public String userName;
        public frmLogin()
        {

            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNgayThang.Text = DateTime.Now.ToString("hh:mm:ss   dd-MM-yyyy");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu !", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtUser.Select();

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLDiemSinhVien;Integrated Security=True"); // making connection
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM userLogin WHERE userName = '" + txtUser.Text + "' AND passAccount = '" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    userName = txtUser.Text.ToString();
                    ControlID.TextData = txtUser.Text.ToString();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    con.Close();
                    this.Hide();
                    new frmMain().Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
