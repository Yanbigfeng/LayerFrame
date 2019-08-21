using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.BaseClass;
using ServerMain;

namespace Server_Areas.Admin
{
   public class RoleServer: ServiceBase,IRoleServer
    {
        #region 获取数据
        public List<RoleInfor> GetData()
        {
            var db = base.GetDbContext();
            return db.Set<RoleInfor>().ToList();

        }
        #endregion
    }
}
