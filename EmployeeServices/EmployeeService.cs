using EmployeeManagerModel;
using EmployeeManagerUtils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace EmployeeServices
{
    /// <summary>
    /// 员工信息业务层
    /// </summary>
    public class EmployeeService
    {
        /// <summary>
        /// 员工登录校验
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否登录成功</returns>
        public bool checkLogin(string username, string password)
        {
            /*
             * 1.为空校验
             */
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            try
            {
                /*
                 * 2.定义SQL语句，进行SQL校验
                 */
                string sql = "select count(1) from admin where name=@name and password=@password";

                /*
                 * 3.获取数据库连接
                 */
                MySqlConnection connection = SqlHelper.getMySqlConnection();

                /*
                 * 4.定义参数，防止SQL注入
                 */
                MySqlParameter[] parameters = { new MySqlParameter("@name", username), new MySqlParameter("@password", password) };

                /*
                 * 5.执行SQL语句
                 */
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddRange(parameters);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                SqlHelper.closeMySqlConnection();
            }

        }

        /// <summary>
        /// 手机号校验
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns>校验是否通过</returns>
        public bool checkPhone(string phone)
        {
            Regex regex = new Regex("@\"[1]+[3-8]+\\d{9}\"");
            if (regex.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        /// <returns>所有员工集合</returns>
        public List<Employee> queryAllEmployees(string sql)
        {
            /*
             * 1.获取连接
             */
            MySqlConnection connection = SqlHelper.getMySqlConnection();

            /*
             * 2.执行SQL
             */
            MySqlCommand command = new MySqlCommand(sql, connection);
            //command.Parameters.AddRange(parameters);

            MySqlDataReader reader = command.ExecuteReader();

            /*
             * 3.定义集合,装载Employee对象
             */
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();

                emp.Empid = reader.GetInt32("empid");
                emp.Ename = reader.GetString("ename");
                emp.Age = reader.GetInt32("age");
                emp.Gender = reader.GetString("gender") == "1" ? "男" : "女";
                emp.Job = reader.GetString("job");
                emp.Mgr = Convert.ToInt32(Convert.ToString(reader.GetInt32("mgr")));
                emp.Hiredate = Convert.ToDateTime(reader.GetString("hiredate"));
                emp.Phone = reader.GetString("phone");
                emp.Deptno = reader.GetInt32("deptno");
                emp.Dname = reader.GetString("dname");

                list.Add(emp);
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 获取所有的部门编号
        /// </summary>
        /// <returns>部门编号集合</returns>
        public List<string> queryAllDeptno()
        {
            /*
             * 1.获取连接
             */
            MySqlConnection connection = SqlHelper.getMySqlConnection();

            /*
             * 2.定义查询SQL
             */
            string sql = "select deptno from department";

            /*
             * 3.执行SQL
             */
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            /*
             * 4.定义集合,装载Employee对象
             */
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetString("deptno"));
            }
            reader.Close();
            return list;
        }

        /// <summary>
        /// 获取所有员工编号
        /// </summary>
        /// <returns>员工编号集合</returns>
        public List<string> queryAllEmployeeNo()
        {
            /*
             * 1.获取连接
             */
            MySqlConnection mySqlConnection = SqlHelper.getMySqlConnection();

            /*
             * 2.定义查询SQL
             */
            string sql = "select empid from employee";

            /*
             * 3.执行SQL
             */
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            /*
             * 4.定义集合，加载员工编号
             */
            List<string> empnoList = new List<string>();
            while (reader.Read())
            {
                empnoList.Add(reader.GetString("empid").ToString());
            }
            reader.Close();

            /*
             * 5.返回集合
             */
            return empnoList;
        }

        /// <summary>
        /// 根据部门编号获取部门名称
        /// </summary>
        /// <param name="id">部门编号</param>
        /// <returns>部门名称</returns>
        public string getDeptNameById(string id)
        {
            /*
             * 1.获取连接
             */
            MySqlConnection mySqlConnection = SqlHelper.getMySqlConnection();

            /*
             * 2.定义SQL语句
             */
            string sql = "select dname from department where deptno=@deptno";

            /*
             * 3.设置参数，防止SQL注入
             */
            MySqlParameter mySqlParameter = new MySqlParameter("@deptno", id);

            /*
             * 4.添加参数，执行SQL
             */
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.Parameters.Add(mySqlParameter);
            string name = (string)mySqlCommand.ExecuteScalar();

            /*
             * 5.返回部门名称
             */
            return name;

        }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <returns>受影响的行</returns>
        public int addEmployee(Employee employee)
        {
            /*
             * 1.获取连接
             */
            MySqlConnection connection = SqlHelper.getMySqlConnection();

            /*
             * 2.定义插入SQL语句
             */
            string sql = "insert into employee(ename,age,gender,job,mgr,hiredate,phone,deptno) values" +
                "(@ename,@age,@gender,@job,@mgr,@hiredate,@phone,@deptno)";

            /*
             * 3.获取插入的数据,并设置参数
             */
            string name = employee.Ename;
            int age = employee.Age;
            string gender = employee.Gender;
            string job = employee.Job;
            int mgr = employee.Mgr;
            DateTime hiredate = employee.Hiredate;
            string phone = employee.Phone;
            int deptno = employee.Deptno;


            MySqlParameter[] parameters = {new MySqlParameter("@ename",name),
            new MySqlParameter("@age",age),
            new MySqlParameter("@gender",gender),
            new MySqlParameter("@job",job),
            new MySqlParameter("@mgr",mgr),
            new MySqlParameter("@hiredate",hiredate),
            new MySqlParameter("@phone",phone),
            new MySqlParameter("@deptno",deptno)};

            /*
             * 4.执行SQL
             */
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddRange(parameters);
            int count = command.ExecuteNonQuery();

            return count;
        }


    }
}
