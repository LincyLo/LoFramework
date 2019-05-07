using System;
using Autofac;
using Autofac.Core;
using Lo.Data.Extension;
using Unity.Resolution;

namespace Lo.Data.Repository
{
    /// <summary>
    /// 数据库建立工厂
    /// </summary>
    public class DbFactory
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="DbType">数据库类型</param>
        /// <returns></returns>
        public static IDatabase Base(string connString, DatabaseType DbType)
        {
            DbHelper.DbType = DbType;
            return AutofacIocHelper.DBInstance.GetService<IDatabase>(
                new NamedParameter("connString", connString),
                new NamedParameter("DbType", DbType.ToString())
            );
        }
        /// <summary>
        /// 连接基础库
        /// </summary>
        /// <returns></returns>
        public static IDatabase Base()
        {
            DbHelper.DbType = DatabaseType.SqlServer; //(DatabaseType)Enum.Parse(typeof(DatabaseType), AutofacIocHelper.GetmapToByName("DBcontainer", "IDbContext"));

            return AutofacIocHelper.DBInstance.GetService<IDatabase>(
                new NamedParameter("connString", "connString"),
                new NamedParameter("DbType", "")
             );

        }
    }
}
