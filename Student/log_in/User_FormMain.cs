using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace log_in
{
    public partial class User_FormMain : Form
    {
        public User_FormMain()
        {
            InitializeComponent();
        }
        class DBHelpe
        {
            public static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void User_FormMain_Load(object sender, EventArgs e)
        {
            string connString = DBHelpe.connString;//连接数据库       
            userName_Main.Text = "欢迎  " + UserHelper.userName + "  登陆本系统";
            userName1_Main.Text = "欢迎  " + UserHelper.userName + "  登陆本系统";
            Date_Main.Text="当前时间为： "+DateTime.Now.ToLongDateString();

        }
        //退出按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要退出系统吗?", "系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }
        //刷新按钮
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }
        //显示用户信息按钮
        private void User_information_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_information f = new User_information();
            f.Show();
        }

    }
}
