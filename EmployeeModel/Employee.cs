using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModel
{
    /// <summary>
    /// 员工实体类
    /// </summary>
    public class Employee
    {
        // 员工编号
        private int empid;

        // 员工名称
        private string ename;

        // 员工年龄
        private int age;

        // 员工性别
        private string gender;

        // 员工职务
        private string job;

        // 直属上级
        private int mgr;

        // 入职日期
        private DateTime hiredate;

        // 联系方式
        private string phone;

        // 部门编号
        private int deptno;

        // 部门信息
        //private Department department;
        private string dname;

        public Employee()
        {
        }

        public Employee(int empid, string ename, int age, string gender, string job, int mgr, DateTime hiredate, string phone, int deptno, string dname)
        {
            this.Empid = empid;
            this.Ename = ename;
            this.Age = age;
            this.Gender = gender;
            this.Job = job;
            this.Mgr = mgr;
            this.Hiredate = hiredate;
            this.Phone = phone;
            this.Deptno = deptno;
            this.Dname = dname;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Ename { get => ename; set => ename = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Job { get => job; set => job = value; }
        public int Mgr { get => mgr; set => mgr = value; }
        public DateTime Hiredate { get => hiredate; set => hiredate = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Deptno { get => deptno; set => deptno = value; }
        public string Dname { get => dname; set => dname = value; }
    }
}
