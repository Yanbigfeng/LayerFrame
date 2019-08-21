using ServerMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.BaseClass;


namespace Server_Areas.Admin
{
    /// <summary>
    /// user相关操作
    /// </summary>
    /// <returns></returns>
   public class UserServer : ServiceBase, IUserServer
    {

        //这里注意如果是多操作合并请不要使用using形式，using会释放上下文

        #region 获取数据
        public List<UserInfor> GetData()
        {
            var db = base.GetDbContext();
            return db.Set<UserInfor>().ToList();

        }
        #endregion


        #region 添加数据
        public int UserAdd(UserInfor user)
        {

            using (var db = base.GetDbContext())
            {
                db.Set<UserInfor>().Add(user);
                return db.SaveChanges();
            }
        }
        #endregion
    }
}
