using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagerUtils;
using MySql.Data.MySqlClient;
using EmployeeServices;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    public partial class FrmLogin : Form
    {
        private EmployeeService employeeService = new EmployeeService();
        public FrmLogin()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\EmeraldColor1.ssk";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
             * 1.获取连接
             */ 
            MySqlConnection connection = SqlHelper.getMySqlConnection();

            /*
             * 2.根据用户名密码登录系统
             */ 
            string username = edtUserName.Text;
            string password = edtPassword.Text; 
            if (!employeeService.checkLogin(username,password) )
            {
                MessageBox.Show("用户名密码不能为空!", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.Hide();    
                FrmMain frmMain = new FrmMain(username);
                frmMain.Show();
            }
            SqlHelper.closeMySqlConnection();
        }
    }
}
