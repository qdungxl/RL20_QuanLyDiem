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
    public class IDataDAL
    {
        string sqlconn = @"---";//Nhập chuỗi kết nối với SQL vào đây.
        protected SqlConnection conn = null;
        public void openconn()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn != null && conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void closeconn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
