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
    public class LopHocDAL:IDataDAL
    {
        public List<LopHoc> LayDuLieuLopHoc()
        {
            List<LopHoc> DsLopHoc = new List<LopHoc>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LopHoc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LopHoc lh = new LopHoc();
                lh.MaLopHoc = reader.GetString(0);
                lh.TenLopHoc = reader.GetString(1);
                DsLopHoc.Add(lh);
            }
            reader.Close();
            return DsLopHoc;
        }
    }
}
