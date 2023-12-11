using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace EmployeeManagerUtils
{
    /// <summary>
    /// Sql工具类
    /// </summary>
    public class SqlHelper
    {
        private static MySqlConnection connection = null;
        /// <summary>
        /// 获取MySQL数据库连接
        /// </summary>
        /// <returns>返回连接</returns>
        public static MySqlConnection getMySqlConnection()
        {
            /*
             * 1.读取配置文件数据库服务
             */
            String conString = ConfigurationManager.ConnectionStrings["serverCon"].ConnectionString;

            /*
             * 2.根据读取的服务，获取数据库连接
             */ 
            connection = new MySqlConnection(conString);
            connection.Open();

            /*
             * 3.返回获取的数据库连接
             */ 
            return connection;
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void closeMySqlConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
