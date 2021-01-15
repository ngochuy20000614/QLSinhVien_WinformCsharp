using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=.;Initial Catalog=QLDiemSinhVien;Integrated Security=True");
        private void XuatSinhVien()
        {
            cnn.Open();
            string sql = "SELECT * from SinhVien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DTG_sinhvien.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            XuatSinhVien();
        }

        private void bt_timkiemsinhvien_Click(object sender, EventArgs e)
        {
            string data = tb_timkiemsinhvien.Text.ToString();
            cnn.Open();
            string sql = "SELECT * FROM SinhVien WHERE hoTen LIKE N'%" + data + "%' or " +
                                                               "maSV LIKE '%" + data + "%'or " +
                                                               "maLop LIKE '%" + data + "%' or " +
                                                               "gioiTinh LIKE '%" + data + "%' or " +
                                                               "diaChi LIKE N'%" + data + "%' or " +
                                                               "namSinh LIKE '%" + data + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, cnn);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            cnn.Close();
            DTG_sinhvien.DataSource = table;
        }
    }
}
