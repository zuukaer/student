namespace log_in
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Lable1 = new System.Windows.Forms.Label();
            this.Lable2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(60, 30);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(41, 12);
            this.Lable1.TabIndex = 2;
            this.Lable1.Text = "学号：";
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Location = new System.Drawing.Point(60, 87);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(41, 12);
            this.Lable2.TabIndex = 3;
            this.Lable2.Text = "密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserPassWord
            // 
            this.txtUserPassWord.Location = new System.Drawing.Point(124, 87);
            this.txtUserPassWord.Name = "txtUserPassWord";
            this.txtUserPassWord.Size = new System.Drawing.Size(137, 21);
            this.txtUserPassWord.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 195);
            this.Controls.Add(this.txtUserPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassWord;
    }
}

