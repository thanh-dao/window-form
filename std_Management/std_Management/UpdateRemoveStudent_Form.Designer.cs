namespace Student_Management
{
    partial class UpdateRemoveStudent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRemoveStudent_Form));
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.lb_gender = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lb_lastname = new System.Windows.Forms.Label();
            this.lb_firstname = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.lb_picture = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_findId = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_userid.Location = new System.Drawing.Point(215, 61);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(149, 34);
            this.txt_userid.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Student ID:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(215, 474);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 34);
            this.txt_email.TabIndex = 26;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(91, 474);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(69, 28);
            this.lb_email.TabIndex = 25;
            this.lb_email.Text = "Email:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.Location = new System.Drawing.Point(215, 406);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(284, 34);
            this.txt_phone.TabIndex = 24;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_phone.Location = new System.Drawing.Point(86, 406);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(76, 28);
            this.lb_phone.TabIndex = 23;
            this.lb_phone.Text = "Phone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_female);
            this.groupBox1.Controls.Add(this.rdo_male);
            this.groupBox1.Location = new System.Drawing.Point(215, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(284, 75);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_female.Location = new System.Drawing.Point(149, 20);
            this.rdo_female.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(98, 32);
            this.rdo_female.TabIndex = 1;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_male.Location = new System.Drawing.Point(36, 20);
            this.rdo_male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(77, 32);
            this.rdo_male.TabIndex = 0;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gender.Location = new System.Drawing.Point(76, 328);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(86, 28);
            this.lb_gender.TabIndex = 21;
            this.lb_gender.Text = "Gender:";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_birthdate.Location = new System.Drawing.Point(215, 254);
            this.dtp_birthdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(284, 27);
            this.dtp_birthdate.TabIndex = 20;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.Location = new System.Drawing.Point(46, 246);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(116, 28);
            this.lb_birthdate.TabIndex = 19;
            this.lb_birthdate.Text = "Birth Date:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lastname.Location = new System.Drawing.Point(215, 188);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(284, 34);
            this.txt_lastname.TabIndex = 18;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_firstname.Location = new System.Drawing.Point(215, 122);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(284, 34);
            this.txt_firstname.TabIndex = 17;
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.lb_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_lastname.Location = new System.Drawing.Point(45, 188);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(117, 28);
            this.lb_lastname.TabIndex = 16;
            this.lb_lastname.Text = "Last Name:";
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.lb_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_firstname.Location = new System.Drawing.Point(42, 122);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(120, 28);
            this.lb_firstname.TabIndex = 15;
            this.lb_firstname.Text = "First Name:";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uploadImage.Location = new System.Drawing.Point(645, 478);
            this.btn_uploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(284, 40);
            this.btn_uploadImage.TabIndex = 33;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // pictureBoxStudentImage
            // 
            this.pictureBoxStudentImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudentImage.Image")));
            this.pictureBoxStudentImage.Location = new System.Drawing.Point(645, 328);
            this.pictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            this.pictureBoxStudentImage.Size = new System.Drawing.Size(284, 142);
            this.pictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentImage.TabIndex = 32;
            this.pictureBoxStudentImage.TabStop = false;
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_picture.Location = new System.Drawing.Point(530, 332);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(84, 28);
            this.lb_picture.TabIndex = 31;
            this.lb_picture.Text = "Picture:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.Location = new System.Drawing.Point(645, 122);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(284, 129);
            this.txt_address.TabIndex = 30;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_address.Location = new System.Drawing.Point(530, 128);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(92, 28);
            this.lb_address.TabIndex = 29;
            this.lb_address.Text = "Address:";
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.DarkRed;
            this.btn_deleteUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Location = new System.Drawing.Point(571, 615);
            this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(221, 78);
            this.btn_deleteUser.TabIndex = 35;
            this.btn_deleteUser.Text = "Remove";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_updateUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUser.ForeColor = System.Drawing.Color.White;
            this.btn_updateUser.Location = new System.Drawing.Point(251, 615);
            this.btn_updateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(221, 78);
            this.btn_updateUser.TabIndex = 34;
            this.btn_updateUser.Text = "Edit";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // btn_findId
            // 
            this.btn_findId.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_findId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findId.Location = new System.Drawing.Point(382, 58);
            this.btn_findId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_findId.Name = "btn_findId";
            this.btn_findId.Size = new System.Drawing.Size(117, 52);
            this.btn_findId.TabIndex = 36;
            this.btn_findId.Text = "Search ID";
            this.btn_findId.UseVisualStyleBackColor = false;
            this.btn_findId.Click += new System.EventHandler(this.btn_findId_Click);
            // 
            // UpdateRemoveStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 749);
            this.Controls.Add(this.btn_findId);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_updateUser);
            this.Controls.Add(this.btn_uploadImage);
            this.Controls.Add(this.pictureBoxStudentImage);
            this.Controls.Add(this.lb_picture);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lb_lastname);
            this.Controls.Add(this.lb_firstname);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateRemoveStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRemoveStudent_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.Label lb_firstname;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.Label lb_picture;
        private System.Windows.Forms.Label lb_address;
        internal System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.Button btn_findId;
        internal System.Windows.Forms.TextBox txt_userid;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.TextBox txt_phone;
        internal System.Windows.Forms.RadioButton rdo_female;
        internal System.Windows.Forms.RadioButton rdo_male;
        internal System.Windows.Forms.DateTimePicker dtp_birthdate;
        internal System.Windows.Forms.TextBox txt_lastname;
        internal System.Windows.Forms.TextBox txt_firstname;
        internal System.Windows.Forms.PictureBox pictureBoxStudentImage;
        internal System.Windows.Forms.TextBox txt_address;
    }
}