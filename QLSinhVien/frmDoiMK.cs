using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSinhVien
{
    public partial class frmDoiMK : Form
    {
        private ConnectDB db = new ConnectDB();
        SqlConnection conn = null;
        string userName = ControlID.TextData;
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtUserName.Text = userName;
            conn = db.Connected();
            if (conn.State == ConnectionState.Open) ;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if(txtOldPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo");
                txtOldPass.Focus();
            }else if(txtNewPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo");
                txtNewPass.Focus();
            }
            else if (txtConfirmPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới", "Thông báo");
                txtConfirmPass.Focus();
            }else if (txtNewPass.Text != txtConfirmPass.Text)
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Thực hiện truy vấn
                string update = "UPDATE userLogin SET passAccount = '"+ txtNewPass.Text +"' WHERE userName = '"+ userName +"'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công thành công", "Thông báo!");

                // Trả tài nguyên
                conn.Close();
                cmd.Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
