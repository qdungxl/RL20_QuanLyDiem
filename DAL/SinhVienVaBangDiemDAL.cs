using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SinhVienVaBangDiemDAL:IDataDAL
    {
        public DataSet NapDuLieuChoGridView(MonHoc mh, LopHoc lh)
        {
            openconn();
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "select SinhVien.MaSinhVien,SinhVien.TenSinhVien,BangDiem.Diem from SinhVien inner join BangDiem on SinhVien.MaLop =@malophoc and SinhVien.MaSinhVien = BangDiem.MaSinhVien and BangDiem.MaMonHoc =@mamonhoc";
            command.CommandText = sql;
            command.Parameters.Add("@malophoc", SqlDbType.NVarChar).Value = lh.MaLopHoc;
            command.Parameters.Add("@mamonhoc", SqlDbType.NVarChar).Value = mh.MaMonHoc;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            return ds;
        }
        
        public bool NhapDiem(string maSV, string maMH, int Diem)
        {
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update BangDiem set Diem = @diem where MaSinhVien = @masv and MaMonHoc = @mamh";
            command.Parameters.Add("@masv", SqlDbType.NVarChar).Value = maSV;
            command.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = maMH;
            command.Parameters.Add("@Diem", SqlDbType.Int).Value = Diem;
            command.Connection = conn;
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
    }
}
