using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration; 

namespace log_in
{
    // class DBHelpe
    //{
    //     public static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    //}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtUserPassWord.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                Lable1.Focus();
                return;
            }
            SqlConnection connString = new SqlConnection();
            connString.ConnectionString = "server=ZUNMPLHDVXNKC0C;database=Student;uid=sa;pwd=123456";
            //string connString = DBHelpe.connString;
            string sqlStr = string.Format("Select count(*) from Student_info where Student_ID='{0}'and Password='{1}'", txtUserName.Text.Trim(), txtUserPassWord.Text.Trim());
            using (SqlConnection conn = new SqlConnection(connString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                conn.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                if (n == 1)
                {
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "错误");
                    Lable1.Text = "";
                    Lable2.Text = "";
                    Lable1.Focus();
                }
            }
        }
              private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}