using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// 部门实体类
    /// </summary>
    [Serializable]
    public class Department
    {
        // 部门编号
        private int deptno;

        // 部门名称
        private string dname;

        public Department()
        {
        }

        public int Deptno { get => deptno; set => deptno = value; }
        public string Dname { get => dname; set => dname = value; }
    }
}
