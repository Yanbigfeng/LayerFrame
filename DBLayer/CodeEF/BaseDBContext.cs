using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using Models.BaseClass;


namespace CodeEF
{
    public partial class BaseDBContent : DbContext
    {
        public BaseDBContent()
        : base("name=DataModelContext")//web.config中connectionstring的名字
        {
           
        }

        //用户
        public DbSet<UserInfor> UserInfors { get; set; }
        //角色
        public DbSet<RoleInfor> RoleInfors { get; set; }
        //权限
        public DbSet<PermissonInfor> PermissonInfors { get; set; }



        //public static string GetConnectionString()
        //{
        //    return ConfigurationManager.ConnectionStrings["DataModelContext"].ConnectionString;
        //}
    }
}
