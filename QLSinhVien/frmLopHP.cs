using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmLopHP : Form
    {
        tblLopHP lhp = new tblLopHP();
        public frmLopHP()
        {
            InitializeComponent();
        }

        private void frmLopHP_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataLopHPDataContext db = new DataLopHPDataContext();
                lhp.maHP = txtMaHP.Text;
                lhp.maLHP = txtMaLHP.Text;
                lhp.tenLHP = txtTenLHP.Text;
                lhp.maGV = txtGV.Text;
                lhp.maHK = int.Parse(txtMaHK.Text);
                lhp.sSMax = int.Parse(txtSSMax.Text);
                lhp.sSDK = int.Parse(txtSSDK.Text);
                db.tblLopHPs.InsertOnSubmit(lhp);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm");
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dtgLopHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgLopHP.CurrentRow.Index != -1)
                {
                    txtMaHK.Text = dtgLopHP.CurrentRow.Cells[2].Value.ToString();
                    txtMaHP.Text = dtgLopHP.CurrentRow.Cells[1].Value.ToString();
                    txtMaLHP.Text = dtgLopHP.CurrentRow.Cells[0].Value.ToString();
                    txtGV.Text = dtgLopHP.CurrentRow.Cells[4].Value.ToString();
                    txtSSDK.Text = dtgLopHP.CurrentRow.Cells[5].Value.ToString();
                    txtSSMax.Text = dtgLopHP.CurrentRow.Cells[6].Value.ToString();
                    txtTenLHP.Text = dtgLopHP.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgLopHP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtgLopHP.Columns[0].Width = 110;
            dtgLopHP.Columns[1].Width = 100;
            dtgLopHP.Columns[2].Width = 80;
            dtgLopHP.Columns[3].Width = 200;
            dtgLopHP.Columns[4].Width = 200;
            dtgLopHP.Columns[5].Width = 60;
            dtgLopHP.Columns[6].Width = 60;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "")
            {
                DataLopHPDataContext db = new DataLopHPDataContext();
                var Lst = from hp in db.tblLopHPs
                          join gv in db.tblGiaoViens on hp.maGV equals gv.maGV
                          where hp.tenLHP.Contains(txtTK.Text)
                          select new
                          {
                              maLHP = hp.maLHP,
                              hp.maHP,
                              maHK = hp.maHK,
                              tenLHP = hp.tenLHP,
                              maGV = gv.hoTen,
                              sSDK = hp.sSDK,
                              sSMax = hp.sSMax
                          };

                dtgLopHP.DataSource = Lst.ToList();
            }
            else
                LoadData();
            
        }
        private void LoadData()
        {
            DataLopHPDataContext db = new DataLopHPDataContext();
            var Lst = from hp in db.tblLopHPs
                      join gv in db.tblGiaoViens on hp.maGV equals gv.maGV
                      select new
                      {
                          maLHP = hp.maLHP,
                          hp.maHP,
                          maHK = hp.maHK,
                          tenLHP = hp.tenLHP,
                          maGV = gv.hoTen,
                          sSDK = hp.sSDK,
                          sSMax = hp.sSMax
                      };
            dtgLopHP.DataSource = Lst.ToList();
            txtMaHK.DataBindings.Clear();
            txtMaHP.DataBindings.Clear();
            txtMaLHP.DataBindings.Clear();
            txtGV.DataBindings.Clear();
            txtSSDK.DataBindings.Clear();
            txtSSMax.DataBindings.Clear();
            txtTenLHP.DataBindings.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá lớp học phần này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataLopHPDataContext db = new DataLopHPDataContext();
                try
                {
                    var r = from hp in db.tblLopHPs
                            where hp.maLHP.ToString().Contains(txtMaLHP.Text.ToString())
                            select hp;
                    db.tblLopHPs.DeleteAllOnSubmit(r);
                    db.SubmitChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa lớp học phần này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataLopHPDataContext db = new DataLopHPDataContext();
                    lhp = db.tblLopHPs.Where(s => s.maLHP == txtMaLHP.Text.ToString()).Single();
                    lhp.maHP = txtMaHP.Text;
                    lhp.tenLHP = txtTenLHP.Text;
                    lhp.maHK = int.Parse(txtMaHK.Text);
                    lhp.sSMax = int.Parse(txtSSMax.Text);
                    lhp.sSDK = int.Parse(txtSSDK.Text);
                    db.SubmitChanges();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
