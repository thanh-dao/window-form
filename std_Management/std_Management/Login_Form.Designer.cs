namespace Student_Management
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.img_Login = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Login
            // 
            this.img_Login.Image = ((System.Drawing.Image)(resources.GetObject("img_Login.Image")));
            this.img_Login.Location = new System.Drawing.Point(73, 61);
            this.img_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.img_Login.Name = "img_Login";
            this.img_Login.Size = new System.Drawing.Size(107, 124);
            this.img_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Login.TabIndex = 0;
            this.img_Login.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Login";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_username.Location = new System.Drawing.Point(64, 252);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(117, 25);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_password.Location = new System.Drawing.Point(67, 344);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(113, 25);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(202, 249);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(278, 30);
            this.txt_username.TabIndex = 4;
            this.txt_username.Text = "admin";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(202, 341);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(278, 30);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "123";
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(202, 427);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 56);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(384, 427);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 56);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(531, 609);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_Login);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)(this.img_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
    }
}