﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.BaseClass;

namespace Server_Areas.Admin
{
    public interface IUserServer
    {

        List<UserInfor> GetData();
        int UserAdd(UserInfor user);
    }
}
