﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.BaseClass
{
   public partial class RoleInfor
    {
        public int id { get; set; }
        public string roleName { get; set; }
        public string roleRemark { get; set; }
        public Nullable<System.DateTime> addTime { get; set; }
        public Nullable<int> delFlag { get; set; }
    }
}
