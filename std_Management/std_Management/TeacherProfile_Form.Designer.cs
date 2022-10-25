namespace std_Management
{
    partial class TeacherProfile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherProfile_Form));
            this.btn_findId = new System.Windows.Forms.Button();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.lb_picture = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_findId
            // 
            this.btn_findId.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_findId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findId.Location = new System.Drawing.Point(430, 26);
            this.btn_findId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_findId.Name = "btn_findId";
            this.btn_findId.Size = new System.Drawing.Size(117, 52);
            this.btn_findId.TabIndex = 58;
            this.btn_findId.Text = "Search ID";
            this.btn_findId.UseVisualStyleBackColor = false;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_updateUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUser.ForeColor = System.Drawing.Color.White;
            this.btn_updateUser.Location = new System.Drawing.Point(263, 520);
            this.btn_updateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(221, 78);
            this.btn_updateUser.TabIndex = 56;
            this.btn_updateUser.Text = "Edit";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uploadImage.Location = new System.Drawing.Point(693, 446);
            this.btn_uploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(284, 40);
            this.btn_uploadImage.TabIndex = 55;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxStudentImage
            // 
            this.pictureBoxStudentImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudentImage.Image")));
            this.pictureBoxStudentImage.Location = new System.Drawing.Point(693, 296);
            this.pictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            this.pictureBoxStudentImage.Size = new System.Drawing.Size(284, 142);
            this.pictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentImage.TabIndex = 54;
            this.pictureBoxStudentImage.TabStop = false;
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_picture.Location = new System.Drawing.Point(578, 300);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(84, 28);
            this.lb_picture.TabIndex = 53;
            this.lb_picture.Text = "Picture:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.Location = new System.Drawing.Point(693, 90);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(284, 129);
            this.txt_address.TabIndex = 52;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_address.Location = new System.Drawing.Point(578, 96);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(92, 28);
            this.lb_address.TabIndex = 51;
            this.lb_address.Text = "Address:";
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_userid.Location = new System.Drawing.Point(263, 29);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(149, 34);
            this.txt_userid.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 49;
            this.label4.Text = "Teacher ID:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(263, 442);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 34);
            this.txt_email.TabIndex = 48;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(139, 442);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(69, 28);
            this.lb_email.TabIndex = 47;
            this.lb_email.Text = "Email:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.Location = new System.Drawing.Point(263, 374);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(284, 34);
            this.txt_phone.TabIndex = 46;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_phone.Location = new System.Drawing.Point(134, 374);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(76, 28);
            this.lb_phone.TabIndex = 45;
            this.lb_phone.Text = "Phone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_female);
            this.groupBox1.Controls.Add(this.rdo_male);
            this.groupBox1.Location = new System.Drawing.Point(263, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(284, 75);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_female.Location = new System.Drawing.Point(149, 21);
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
            this.rdo_male.Location = new System.Drawing.Point(36, 21);
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
            this.lb_gender.Location = new System.Drawing.Point(124, 296);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(86, 28);
            this.lb_gender.TabIndex = 43;
            this.lb_gender.Text = "Gender:";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_birthdate.Location = new System.Drawing.Point(263, 222);
            this.dtp_birthdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(284, 27);
            this.dtp_birthdate.TabIndex = 42;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.Location = new System.Drawing.Point(94, 214);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(116, 28);
            this.lb_birthdate.TabIndex = 41;
            this.lb_birthdate.Text = "Birth Date:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lastname.Location = new System.Drawing.Point(263, 156);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(284, 34);
            this.txt_lastname.TabIndex = 40;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_firstname.Location = new System.Drawing.Point(263, 90);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(284, 34);
            this.txt_firstname.TabIndex = 39;
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.lb_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_lastname.Location = new System.Drawing.Point(93, 156);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(117, 28);
            this.lb_lastname.TabIndex = 38;
            this.lb_lastname.Text = "Last Name:";
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.lb_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_firstname.Location = new System.Drawing.Point(90, 90);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(120, 28);
            this.lb_firstname.TabIndex = 37;
            this.lb_firstname.Text = "First Name:";
            // 
            // TeacherProfile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 626);
            this.Controls.Add(this.btn_findId);
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
            this.Name = "TeacherProfile_Form";
            this.Text = "TeacherProfile_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_findId;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.Button btn_uploadImage;
        internal System.Windows.Forms.PictureBox pictureBoxStudentImage;
        private System.Windows.Forms.Label lb_picture;
        internal System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lb_address;
        internal System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
        internal System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton rdo_female;
        internal System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.Label lb_gender;
        internal System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.Label lb_birthdate;
        internal System.Windows.Forms.TextBox txt_lastname;
        internal System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.Label lb_firstname;
    }
}