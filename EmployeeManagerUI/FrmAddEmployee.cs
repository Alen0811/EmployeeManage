using EmployeeManagerModel;
using EmployeeServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagerUI
{
    public partial class FrmAddEmployee : Form
    {
        private EmployeeService employeeService = new EmployeeService();
        public FrmAddEmployee()
        {
            InitializeComponent();
            edtAddAge.KeyPress += edtAddAge_KeyPress;
        }

        /// <summary>
        /// 获取所有员工编号
        /// </summary>
        /// <returns>员工编号集合</returns>
        private List<string> getAllEmployeeNo()
        {
            return employeeService.queryAllEmployeeNo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 名称为空校验
            if (string.IsNullOrEmpty(edtAddName.Text))
            {
                MessageBox.Show("名称不能为空！", "提示", MessageBoxButtons.OK);
                edtAddName.Focus();
                return;
            }

            // 年龄为空校验
            if (string.IsNullOrEmpty(edtAddAge.Text))
            {
                MessageBox.Show("年龄不能为空！", "提示", MessageBoxButtons.OK);
                edtAddAge.Focus();
                return;
            }

            // 性别为空校验
            if (string.IsNullOrEmpty(cbbAddGender.Text))
            {
                MessageBox.Show("性别不能为空！", "提示", MessageBoxButtons.OK);
                cbbAddGender.Focus();
                return;
            }

            // 直属上级为空校验
            if (string.IsNullOrEmpty(cbbAddMgr.Text))
            {
                MessageBox.Show("直属上级不能为空！", "提示", MessageBoxButtons.OK);
                cbbAddMgr.Focus();
                return;
            }

            // 职务为空校验
            if (string.IsNullOrEmpty(edtAddJob.Text))
            {
                MessageBox.Show("员工职务不能为空！", "提示", MessageBoxButtons.OK);
                edtAddJob.Focus();
                return;
            }

            // 联系方式为空校验
            if (string.IsNullOrEmpty(edtAddPhone.Text))
            {
                MessageBox.Show("联系方式不能为空！", "提示", MessageBoxButtons.OK);
                edtAddPhone.Focus();
                return;
            }

            // 所属部门为空校验
            if (string.IsNullOrEmpty(cbbAddDeptno.Text))
            {
                MessageBox.Show("所属部门不能为空！", "提示", MessageBoxButtons.OK);
                cbbAddDeptno.Focus();
                return;
            }
            /*
             * 1.创建Employee对象
             */
            Employee employee = new Employee();
            employee.Ename = edtAddName.Text;
            employee.Age = int.Parse(edtAddAge.Text);
            employee.Gender = cbbAddGender.Text == "男" ? "1" : "0";
            employee.Mgr = int.Parse(cbbAddMgr.Text); 
            employee.Job = edtAddJob.Text;
            employee.Hiredate = DateTime.Parse(dtpAddHireDate.Text);
            employee.Phone = edtAddPhone.Text;  
            employee.Deptno = int.Parse(cbbAddDeptno.Text);

            // 校验联系方式
            if (!employeeService.checkPhone(employee.Phone))
            {
                MessageBox.Show("联系方式格式不正确！", "提示", MessageBoxButtons.OK);
                return;
            }

            // 年龄校验
            if (employee.Age > 60 || employee.Age < 18)
            {
                MessageBox.Show("输入的年龄不合法！", "提示", MessageBoxButtons.OK);
                return;
            }
            /*
             * 2.添加员工
             */ 
            int count = employeeService.addEmployee(employee);
            if (count > 0)
            {
                MessageBox.Show("添加成功!","提示",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            /*
             * 1.加载员工编号
             */ 
            List<string> empnos = this.getAllEmployeeNo();
            cbbAddMgr.Items.Clear();
            cbbAddMgr.Items.Add("0");
            foreach (string empno in empnos)
            {
                cbbAddMgr.Items.Add(empno);
            }

            /*
             * 2.加载部门编号
             */
            List<string> deptnos = employeeService.queryAllDeptno();
            foreach (string deptno in deptnos)
            {
                cbbAddDeptno.Items.Add(deptno);
            }
        }

        private void cbbAddDeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            edtAddDeptName.Text = string.Empty;
            edtAddDeptName.Text = employeeService.getDeptNameById(cbbAddDeptno.Text);
        }

        /// <summary>
        /// 控制年龄输入框只能输入纯数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edtAddAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // 如果按键不是数字并且不是控制键，则不允许输入
                e.Handled = true;
            }
            

        }
    }
}
