﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public override string ToString()
        {
            return TenMonHoc;
        }
    }
}
