using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace log_in
{
    public partial class User_information : Form
    {
        public User_information()
        {
            InitializeComponent();
        }
        string connString = DBHelper.connString;//连接数据库
        private void User_information_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select User_ID,User_PWD as User_DES from User_info where User_ID like='" + UserHelper.userName + "'";
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            my_information.DataSource = dt.DefaultView;
        }

    }
}


