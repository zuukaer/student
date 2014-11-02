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
                 txtUserName.Focus();
                return;
            }
            try
            {
                 string connString = DBHelper.connString;//连接数据库
                if (this.radioButton1.Checked == true)
                {
                    string sqlStr = string.Format("Select count(*) from Student_info where Student_ID='{0}'and Password='{1}'", txtUserName.Text.Trim(), txtUserPassWord.Text.Trim());
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            //MessageBox.Show("登陆成功");
                            UserHelper.userName = txtUserName.Text.Trim();
                            UserHelper.password = txtUserPassWord.Text.Trim();
                            this.Hide();
                            Stu_FormMain f = new Stu_FormMain();
                            f.Show();                          
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误，请重新输入！", "错误");
                            txtUserName.Text = "";
                            txtUserPassWord.Text = "";
                            txtUserName.Focus();
                        }
                    }
                }

                else if (this.radioButton2.Checked == true)
                {
                    string sqlStr = string.Format("Select count(*) from User_info where User_ID='{0}'and User_PWD='{1}'", txtUserName.Text.Trim(), txtUserPassWord.Text.Trim());
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            //MessageBox.Show("登陆成功");
                            UserHelper.userName = txtUserName.Text.Trim();//保存用户名及密码到 UserHelper类中
                            UserHelper.password = txtUserPassWord.Text.Trim();
                            this.Hide();
                            User_FormMain f = new User_FormMain();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误，请重新输入！", "错误");
                            txtUserName.Text = "";
                            txtUserPassWord.Text = "";
                            txtUserName.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择登陆身份！", "错误");
                    txtUserName.Text = "";
                    txtUserPassWord.Text = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception)
            {
                throw new Exception("产生异常");
            }
        }
              private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

