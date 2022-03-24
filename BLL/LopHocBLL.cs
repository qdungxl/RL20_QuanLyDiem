using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LopHocBLL
    {
        public List<LopHoc> LayDuLieuLopHoc()
        {
            return new LopHocDAL().LayDuLieuLopHoc();
        }
    }
}
