using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        TKHK tk = new TKHK();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            XuatSinhVienRaDataGridView();
            LoadDanhSachSinhVien();
            LoadComboBox_theoHocKi();
        }
        private void XuatSinhVienRaDataGridView()
        {
            DataDiemSVDataContext db = new DataDiemSVDataContext();
            var list = from tkhk in db.TKHKs
                      join sv in db.SinhViens on tkhk.maSV equals sv.maSV
                      orderby  tkhk.maHK
                      select new
                      {
                          maHK = tkhk.maHK,
                          maSV = tkhk.maSV,
                          sTCDK = tkhk.sTCDK,
                          dTBC = tkhk.dTBC,
                          sTCTL = tkhk.sTCTL
                      };
            DGV_thongtinsinhvien.DataSource = list.ToList();
            tb_masinhvien.DataBindings.Clear();
            tb_hocki.DataBindings.Clear();
            tb_sotinchi.DataBindings.Clear();
            tb_diemtrungbinh.DataBindings.Clear();
            tb_sotinchitichluy.DataBindings.Clear();
        }

        private void DGV_thongtinsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_thongtinsinhvien.CurrentRow.Index != -1)
                {
                    tb_masinhvien.Text = DGV_thongtinsinhvien.CurrentRow.Cells[1].Value.ToString();
                    tb_hocki.Text = DGV_thongtinsinhvien.CurrentRow.Cells[0].Value.ToString();
                    tb_sotinchi.Text = DGV_thongtinsinhvien.CurrentRow.Cells[2].Value.ToString();
                    tb_diemtrungbinh.Text = DGV_thongtinsinhvien.CurrentRow.Cells[3].Value.ToString();
                    tb_sotinchitichluy.Text = DGV_thongtinsinhvien.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDanhSachSinhVien()
        {
            tb_masinhvien.Text = DGV_thongtinsinhvien.CurrentRow.Cells[1].Value.ToString();
            tb_hocki.Text = DGV_thongtinsinhvien.CurrentRow.Cells[0].Value.ToString();
            tb_sotinchi.Text = DGV_thongtinsinhvien.CurrentRow.Cells[2].Value.ToString();
            tb_diemtrungbinh.Text = DGV_thongtinsinhvien.CurrentRow.Cells[3].Value.ToString();
            tb_sotinchitichluy.Text = DGV_thongtinsinhvien.CurrentRow.Cells[4].Value.ToString();
        }
        public void LoadComboBox_theoHocKi()
        {
            DataDiemSVDataContext db = new DataDiemSVDataContext();
            var list = from p in db.HocKies
                       where p.maHK == p.maHK//Chọn toàn bộ bảng
                       select p;
            
            CBB_theohocki.DataSource = list.ToList();
            CBB_theohocki.DisplayMember = "maHK";
            CBB_theohocki.ValueMember = "maHK";

        }
  
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                tb_timkiem.Select();
                XuatSinhVienRaDataGridView();
            }
            else
            {
                try
                {
                    string data = tb_timkiem.Text.ToString();
                    using (DataDiemSVDataContext db = new DataDiemSVDataContext())
                    {
                        DGV_thongtinsinhvien.DataSource = db.TKHKs.Where(p => p.maSV.Equals(data));
                    }
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void LoadDuLieuTheoHocKi(int hocki)
        {
            DataDiemSVDataContext db = new DataDiemSVDataContext();
            var list = from tkhk in db.TKHKs
                       join sv in db.SinhViens on tkhk.maSV equals sv.maSV
                       where tkhk.maHK == hocki
                       orderby tkhk.maHK
                       select new
                       {
                           maHK = tkhk.maHK,
                           maSV = tkhk.maSV,
                           sTCDK = tkhk.sTCDK,
                           dTBC = tkhk.dTBC,
                           sTCTL = tkhk.sTCTL
                       };
            DGV_thongtinsinhvien.DataSource = list.ToList();
            tb_masinhvien.DataBindings.Clear();
            tb_hocki.DataBindings.Clear();
            tb_sotinchi.DataBindings.Clear();
            tb_diemtrungbinh.DataBindings.Clear();
            tb_sotinchitichluy.DataBindings.Clear();
        }
        private void CBB_theohocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text_cbb = CBB_theohocki.Text.ToString();
            if (text_cbb.Equals("111"))
            {
                XuatSinhVienRaDataGridView();
            }
            if (text_cbb.Equals("118"))
            {
                LoadDuLieuTheoHocKi(118);
            }
            if (text_cbb.Equals("218"))
            {
                LoadDuLieuTheoHocKi(218);
            }
            if (text_cbb.Equals("119"))
            {
                LoadDuLieuTheoHocKi(119);
            }
            if (text_cbb.Equals("219"))
            {
                LoadDuLieuTheoHocKi(219);
            }
            if (text_cbb.Equals("120"))
            {
                LoadDuLieuTheoHocKi(120);
            }
            if (text_cbb.Equals("220"))
            {
                LoadDuLieuTheoHocKi(220);
            }
            
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
           
            if (tb_masinhvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không??", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataDiemSVDataContext db = new DataDiemSVDataContext();
                    var r = from hp in db.TKHKs
                            join sv in db.SinhViens on hp.maSV equals sv.maSV
                            where hp.maHK.ToString().Contains(tb_hocki.Text.ToString())
                            where hp.maSV.ToString().Contains(tb_masinhvien.Text.ToString())
                            select hp;
                    db.TKHKs.DeleteAllOnSubmit(r);
                    db.SubmitChanges();
                    XuatSinhVienRaDataGridView();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            
            if (tb_masinhvien.Text == "" || tb_hocki.Text == "" 
                || tb_diemtrungbinh.Text == "" || tb_sotinchi.Text == "" || tb_sotinchitichluy.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có muốn thay đổi thông tin sinh viên hay ko ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    byte sotinchi = byte.Parse(tb_sotinchi.Text);
                    byte sotinchitichluy = byte.Parse(tb_sotinchitichluy.Text);
                    decimal dTBC = decimal.Parse(tb_diemtrungbinh.Text);
                    DataDiemSVDataContext db = new DataDiemSVDataContext();
                    tk = db.TKHKs.Where(s => s.maHK == int.Parse(tb_hocki.Text.ToString())).FirstOrDefault();
                    tk = db.TKHKs.Where(s => s.maSV == tb_masinhvien.Text.ToString()).FirstOrDefault();
                    tk.maHK = int.Parse(tb_hocki.Text.ToString());
                    tk.maSV = tb_masinhvien.Text;
                    tk.sTCDK = sotinchi;
                    tk.sTCTL = sotinchitichluy;
                    tk.dTBC = dTBC;
                    db.SubmitChanges();
                    XuatSinhVienRaDataGridView();
                    MessageBox.Show("Thay đổi thành công");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Mã sinh viên hoặc mã học kì không tồn tại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        public void ClearText()
        {
            tb_masinhvien.Text = "";
            tb_hocki.Text = "";
            tb_diemtrungbinh.Text = "";
            tb_sotinchi.Text = "";
            tb_sotinchitichluy.Text = "";
        }
        private void bt_them_Click(object sender, EventArgs e)
        {

            if (tb_masinhvien.Text == "" || tb_hocki.Text == ""
                || tb_diemtrungbinh.Text == "" || tb_sotinchi.Text == "" || tb_sotinchitichluy.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(MessageBox.Show("Bạn muốn thêm mới một dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    TKHK tKHK = new TKHK();
                    DataDiemSVDataContext db = new DataDiemSVDataContext();
                    tKHK.maSV = tb_masinhvien.Text.ToString();
                    tKHK.maHK = int.Parse(tb_hocki.Text);
                    tKHK.sTCDK = byte.Parse(tb_sotinchi.Text);
                    tKHK.sTCTL = byte.Parse(tb_sotinchitichluy.Text);
                    tKHK.dTBC = decimal.Parse(tb_diemtrungbinh.Text);
                    db.TKHKs.InsertOnSubmit(tKHK);
                    db.SubmitChanges();
                    MessageBox.Show("Đã thêm thành công");

                    Form1_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Mã sinh viên hoặc mã học kì đã tồn tại, vui lòng kiểm tra lại giá trị đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void xuatxml_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try
            {
                var res_SinhVien = from r in db.SINHVIEN_VIEWs select r;
                XElement node = new XElement("QLSinhVien", from a in res_SinhVien
                                                           select
                                                           new XElement("SinhVien",
                                                           new XElement("maSV", a.maSV),
                                                           new XElement("hoTen", a.hoTen),
                                                           new XElement("maLop", a.maLop),
                                                           new XElement("sTCDK", a.sTCDK),
                                                           new XElement("dTBC", a.dTBC),
                                                           new XElement("maHK", a.maHK)
                                                           ));

                node.Save("../../QLSinhVien.xml");
                MessageBox.Show("Xuất xml thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("Loi "+ ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bt_themsinhvien_Click(object sender, EventArgs e)
        {
            var formThemSV = new ThemSinhVien();
            formThemSV.Show();
        }

        
    }
}
