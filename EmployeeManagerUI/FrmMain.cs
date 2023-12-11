using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeServices;
using EmployeeManagerModel;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace EmployeeManagerUI
{
    public partial class FrmMain : Form
    {
        // 用户名
        private string username;

        // service
        private EmployeeService employeeService = new EmployeeService();
        public FrmMain()
        {
            InitializeComponent();
            //禁止自动生成列，以下场景会用到：数据源的列超过需要展示的列
            this.dbgEmployees.AutoGenerateColumns = false;
        }

        public FrmMain(string username)
        {
            InitializeComponent();
            this.username = username;
            //禁止自动生成列，以下场景会用到：数据源的列超过需要展示的列
            this.dbgEmployees.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        private void getAllEmployees()
        {
            /*
             * 1.定义SQL语句
             */
            StringBuilder builder = new StringBuilder();
            string sql = "select e.empid,e.ename,e.age,e.gender,e.job,e.mgr,e.hiredate,e.phone,e.deptno,d.dname as dname " +
                         "from employee e left join department d on e.deptno = d.deptno where 1 = 1 ";
            builder.Append(sql);
            /*
             * 2.定义where查询条件,获取查询条件
             */ 
            string empno = edtEmpId.Text;
            string ename = edtEmpName.Text;
            string gender = cbbGender.Text;
            string bHireDate = dtpBHireDate.Text;
            string eHireDate = dtpEHireDate.Text;
            string mgr = edtEmpMgr.Text;
            string deptno = cbbDeptno.Text;

            
            if (!String.IsNullOrEmpty(empno))
            {
                builder.Append(" and e.empid=" + empno);        
            }
            else
            {
                if (!String.IsNullOrEmpty(ename))
                {
                    builder.Append(" and e.ename like '%" + ename + "%'");
                }
                if (!String.IsNullOrEmpty(mgr))
                {
                    builder.Append(" and e.mgr=" + mgr);
                }
                if (!String.IsNullOrEmpty(gender))
                {
                    builder.Append(" and e.gender=" + (gender == "男" ? "1" : "0"));
                }
                if (!String.IsNullOrEmpty(deptno))
                {
                    builder.Append(" and e.deptno=" + deptno);
                }

                builder.Append(" and hiredate between '" + bHireDate + "'" + " and '" + eHireDate + "'");
            }


            List<Employee> employees = employeeService.queryAllEmployees(builder.ToString());
            dbgEmployees.DataSource = employees;
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            tslTime.Text = DateTime.Now.ToString();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tslLoginName.Text = this.username;

            cbbDeptno.Items.Clear();
            List<string> ids = employeeService.queryAllDeptno();
            foreach (string id in ids)
            {
                cbbDeptno.Items.Add(id);
            }
            //this.getAllEmployees();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.getAllEmployees();
        }

        private void dbgEmployees_SelectionChanged(object sender, EventArgs e)
        {
            edtId.Text = dbgEmployees.CurrentRow.Cells["empid"].Value.ToString();
            edtName.Text = dbgEmployees.CurrentRow.Cells["ename"].Value.ToString();
            edtAge.Text = dbgEmployees.CurrentRow.Cells["age"].Value.ToString();
            edtGender.Text = dbgEmployees.CurrentRow.Cells["gender"].Value.ToString();
            edtJob.Text = dbgEmployees.CurrentRow.Cells["job"].Value.ToString();
            edtMgr.Text = dbgEmployees.CurrentRow.Cells["mgr"].Value.ToString();
            edtHireDate.Text = dbgEmployees.CurrentRow.Cells["hiredate"].Value.ToString();
            edtPhone.Text = dbgEmployees.CurrentRow.Cells["phone"].Value.ToString();
            edtDeptno.Text = dbgEmployees.CurrentRow.Cells["deptno"].Value.ToString();
            edtDeptName.Text = dbgEmployees.CurrentRow.Cells["dname"].Value.ToString();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();
        }
    }
}
