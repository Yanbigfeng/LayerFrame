using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeEF;
using System.Data.Entity;

namespace ServerMain
{
    /// <summary>
    /// 基础业务底层
    /// </summary>
    public abstract class ServiceBase
    {


        //这里有使用实例化，三层形式
        //暂且使用实例化
        public IBaseDal db = new BaseDal();

        protected DbContext GetDbContext()
        {
            return db.GetDbContext();
        }

    }
}
