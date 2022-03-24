using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            TaiDuLieuLenComboBoxMonHoc();
            TaiDuLieuLenComboBoxLopHoc();
        }
        private void TaiDuLieuLenComboBoxLopHoc()
        {
            cboLopHoc.Items.Clear();
            foreach (LopHoc lh in new LopHocBLL().LayDuLieuLopHoc())
            {
                cboLopHoc.Items.Add(lh);
            }
        }
        private void TaiDuLieuLenComboBoxMonHoc()
        {
            cboMonHoc.Items.Clear();
            foreach (MonHoc mh in new MonHocBLL().LayDuLieuMonHoc())
            {
                cboMonHoc.Items.Add(mh);
            }
        }
        private void HienThiDuLieuLenGridView()
        {
            MonHoc mh = cboMonHoc.SelectedItem as MonHoc;
            LopHoc lh = cboLopHoc.SelectedItem as LopHoc;
            gvDiem.DataSource = new SinhVienVaBangDiemBLL().LayDuLieuChoGridView(mh, lh).Tables[0];
            gvDiem.Columns[0].HeaderText = "Mã sinh viên";
            gvDiem.Columns[1].HeaderText = "Tên sinh viên";
            gvDiem.Columns[2].HeaderText = "Điểm";
            gvDiem.Columns[0].Width = 150;
            gvDiem.Columns[1].Width = 250;
            gvDiem.Columns[2].Width = 150;
            gvDiem.Columns[0].ReadOnly = true;
            gvDiem.Columns[1].ReadOnly = true;
        }

        private void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            HienThiDuLieuLenGridView();
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            NhapDiem();
        }

        private void NhapDiem()
        {
            bool KetQua = true;
            MonHoc mh = cboMonHoc.SelectedItem as MonHoc;
            for (int i = 0; i < gvDiem.RowCount -1; i++)
            {
                string masv = (string)(gvDiem.Rows[i].Cells["MaSinhVien"].Value);
                int diem = (int)(gvDiem.Rows[i].Cells["Diem"].Value);
                if (new SinhVienVaBangDiemBLL().NhapDiem(masv,mh.MaMonHoc,diem)==false)
                {
                    MessageBox.Show("Nhập điểm thất bại.");
                    KetQua = false;
                    break;
                }
            }
            if (KetQua)
            {
                HienThiDuLieuLenGridView();
                MessageBox.Show("Nhập điểm thành công.");
            }
        }
    }
}
