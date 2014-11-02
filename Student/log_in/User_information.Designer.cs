namespace log_in
{
    partial class User_information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.my_information = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.my_information)).BeginInit();
            this.SuspendLayout();
            // 
            // my_information
            // 
            this.my_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_information.Location = new System.Drawing.Point(0, 2);
            this.my_information.Name = "my_information";
            this.my_information.RowTemplate.Height = 23;
            this.my_information.Size = new System.Drawing.Size(713, 339);
            this.my_information.TabIndex = 0;
            // 
            // User_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 339);
            this.Controls.Add(this.my_information);
            this.Name = "User_information";
            this.Text = "User_information";
            this.Load += new System.EventHandler(this.User_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView my_information;


    }
}