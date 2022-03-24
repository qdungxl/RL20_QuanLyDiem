using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc
    {
        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        public override string ToString()
        {
            return TenLopHoc;
        }
    }
}
