namespace Student_Management
{
    partial class AddNewStudent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudent_Form));
            this.lb_firstname = new System.Windows.Forms.Label();
            this.lb_lastname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lb_gender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_studentid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_picture = new System.Windows.Forms.Label();
            this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.btn_cancelAddStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.lb_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_firstname.Location = new System.Drawing.Point(45, 89);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(120, 28);
            this.lb_firstname.TabIndex = 0;
            this.lb_firstname.Text = "First Name:";
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.lb_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_lastname.Location = new System.Drawing.Point(48, 154);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(117, 28);
            this.lb_lastname.TabIndex = 1;
            this.lb_lastname.Text = "Last Name:";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_firstname.Location = new System.Drawing.Point(218, 89);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(284, 34);
            this.txt_firstname.TabIndex = 2;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lastname.Location = new System.Drawing.Point(218, 154);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(284, 34);
            this.txt_lastname.TabIndex = 4;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.Location = new System.Drawing.Point(49, 212);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(116, 28);
            this.lb_birthdate.TabIndex = 5;
            this.lb_birthdate.Text = "Birth Date:";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_birthdate.Location = new System.Drawing.Point(218, 220);
            this.dtp_birthdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(284, 27);
            this.dtp_birthdate.TabIndex = 6;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gender.Location = new System.Drawing.Point(79, 294);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(86, 28);
            this.lb_gender.TabIndex = 7;
            this.lb_gender.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_female);
            this.groupBox1.Controls.Add(this.rdo_male);
            this.groupBox1.Location = new System.Drawing.Point(218, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(284, 75);
            this.groupBox1.TabIndex = 8;
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
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.Location = new System.Drawing.Point(218, 372);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(284, 34);
            this.txt_phone.TabIndex = 10;
            this.txt_phone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_phone.Location = new System.Drawing.Point(89, 372);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(76, 28);
            this.lb_phone.TabIndex = 9;
            this.lb_phone.Text = "Phone:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(218, 440);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 34);
            this.txt_email.TabIndex = 12;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(94, 440);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(69, 28);
            this.lb_email.TabIndex = 11;
            this.lb_email.Text = "Email:";
            // 
            // txt_studentid
            // 
            this.txt_studentid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_studentid.Location = new System.Drawing.Point(218, 28);
            this.txt_studentid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_studentid.Name = "txt_studentid";
            this.txt_studentid.Size = new System.Drawing.Size(284, 34);
            this.txt_studentid.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Student ID:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.Location = new System.Drawing.Point(218, 508);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(284, 129);
            this.txt_address.TabIndex = 16;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_address.Location = new System.Drawing.Point(71, 508);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(92, 28);
            this.lb_address.TabIndex = 15;
            this.lb_address.Text = "Address:";
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_picture.Location = new System.Drawing.Point(71, 669);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(84, 28);
            this.lb_picture.TabIndex = 17;
            this.lb_picture.Text = "Picture:";
            // 
            // pictureBoxStudentImage
            // 
            this.pictureBoxStudentImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudentImage.Image")));
            this.pictureBoxStudentImage.Location = new System.Drawing.Point(218, 669);
            this.pictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            this.pictureBoxStudentImage.Size = new System.Drawing.Size(284, 142);
            this.pictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentImage.TabIndex = 18;
            this.pictureBoxStudentImage.TabStop = false;
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uploadImage.Location = new System.Drawing.Point(218, 819);
            this.btn_uploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(284, 40);
            this.btn_uploadImage.TabIndex = 19;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_addStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addStudent.ForeColor = System.Drawing.Color.White;
            this.btn_addStudent.Location = new System.Drawing.Point(54, 885);
            this.btn_addStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(448, 55);
            this.btn_addStudent.TabIndex = 20;
            this.btn_addStudent.Text = "Add";
            this.btn_addStudent.UseVisualStyleBackColor = false;
            this.btn_addStudent.Click += new System.EventHandler(this.btn_addStudent_Click);
            // 
            // btn_cancelAddStudent
            // 
            this.btn_cancelAddStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelAddStudent.ForeColor = System.Drawing.Color.White;
            this.btn_cancelAddStudent.Location = new System.Drawing.Point(54, 960);
            this.btn_cancelAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelAddStudent.Name = "btn_cancelAddStudent";
            this.btn_cancelAddStudent.Size = new System.Drawing.Size(448, 50);
            this.btn_cancelAddStudent.TabIndex = 21;
            this.btn_cancelAddStudent.Text = "Cancel";
            this.btn_cancelAddStudent.UseVisualStyleBackColor = false;
            this.btn_cancelAddStudent.Click += new System.EventHandler(this.btn_cancelAddStudent_Click);
            // 
            // AddNewStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 1026);
            this.Controls.Add(this.btn_cancelAddStudent);
            this.Controls.Add(this.btn_addStudent);
            this.Controls.Add(this.btn_uploadImage);
            this.Controls.Add(this.pictureBoxStudentImage);
            this.Controls.Add(this.lb_picture);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.txt_studentid);
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
            this.Name = "AddNewStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStudent_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_firstname;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_studentid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_picture;
        private System.Windows.Forms.PictureBox pictureBoxStudentImage;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Button btn_cancelAddStudent;
    }
}