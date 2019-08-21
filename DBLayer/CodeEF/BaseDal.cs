using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace CodeEF
{
    public class BaseDal : IBaseDal
    {
        #region 使用数据槽来保证上下文的统一
        /// <summary>
        /// 使用数据槽来保证上下文的统一
        /// </summary>
        /// <remarks>使用这种来进行上下文操作不可在使用是使用
        /// using(var db=dbconten)
        /// 这种形式会被释放掉上下文
        /// </remarks>
        /// <returns></returns>
        public override DbContext GetDbContext()
        {
            DbContext dbContext = CallContext.GetData(typeof(BaseDal).Name) as DbContext;
            if (dbContext == null)
            {
                dbContext = new BaseDBContent();

                CallContext.SetData(typeof(BaseDal).Name, dbContext);
            }

            return dbContext;
        }
        #endregion

        #region 实例化创建
        /// <summary>
        /// 实例化创建
        /// </summary>
        /// <returns></returns>
        public override DbContext GetNewDbContext()
        {
            return new BaseDBContent();
        }
        #endregion

    }

}
