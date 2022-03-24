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
    public class MonHocDAL:IDataDAL
    {
        public List<MonHoc> LayDuLieuMonHoc()
        {
            List<MonHoc> DsMonHoc = new List<MonHoc>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from MonHoc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MonHoc mh = new MonHoc();
                mh.MaMonHoc = reader.GetString(0);
                mh.TenMonHoc = reader.GetString(1);
                DsMonHoc.Add(mh);
            }
            reader.Close();
            return DsMonHoc;
        }
    }
}
