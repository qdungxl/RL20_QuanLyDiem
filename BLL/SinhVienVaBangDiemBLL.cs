using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class SinhVienVaBangDiemBLL
    {
        public DataSet LayDuLieuChoGridView(MonHoc mh, LopHoc lh)
        {
            return new SinhVienVaBangDiemDAL().NapDuLieuChoGridView(mh, lh);
        }
        /// <summary>
        /// Nhập điểm cho Sinh Viên ứng với mã Sinh Viên và mã Lớp Hoc.
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="maMH"></param>
        /// <param name="Diem"></param>
        public bool NhapDiem(string maSV, string maMH, int Diem)
        {
            return new SinhVienVaBangDiemDAL().NhapDiem(maSV, maMH, Diem);
        }
    }
}
