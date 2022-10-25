namespace std_Management
{
    partial class DefineClass_Form
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
            this.txtClassNumOfStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbClassName = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClassNumOfStudent
            // 
            this.txtClassNumOfStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassNumOfStudent.Location = new System.Drawing.Point(237, 135);
            this.txtClassNumOfStudent.Name = "txtClassNumOfStudent";
            this.txtClassNumOfStudent.Size = new System.Drawing.Size(288, 29);
            this.txtClassNumOfStudent.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Number Of Student:";
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClassName.Location = new System.Drawing.Point(88, 86);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(97, 21);
            this.lbClassName.TabIndex = 62;
            this.lbClassName.Text = "Class Name:";
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClassID.Location = new System.Drawing.Point(118, 43);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(70, 21);
            this.lbClassID.TabIndex = 61;
            this.lbClassID.Text = "Class ID:";
            this.lbClassID.Click += new System.EventHandler(this.lbClassID_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassName.Location = new System.Drawing.Point(237, 86);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(288, 29);
            this.txtClassName.TabIndex = 60;
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassId.Location = new System.Drawing.Point(237, 38);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(288, 29);
            this.txtClassId.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(626, 81);
=======
            this.label1.Location = new System.Drawing.Point(716, 116);
>>>>>>> 286d10f590318cf5a430e67a9267ef6b9ef8d7b0
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Teacher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(603, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "Student ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbStudentID
            // 
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(740, 137);
            this.cbStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(288, 23);
            this.cbStudentID.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(628, 40);
=======
            this.label5.Location = new System.Drawing.Point(719, 53);
>>>>>>> 286d10f590318cf5a430e67a9267ef6b9ef8d7b0
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Subject:";
            // 
            // cbSubject
            // 
<<<<<<< HEAD
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(740, 38);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(288, 23);
            this.cbSubject.TabIndex = 71;
=======
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(846, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(329, 28);
            this.comboBox2.TabIndex = 71;
>>>>>>> 286d10f590318cf5a430e67a9267ef6b9ef8d7b0
            // 
            // cbTeacher
            // 
<<<<<<< HEAD
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(740, 84);
            this.cbTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(288, 23);
            this.cbTeacher.TabIndex = 72;
=======
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(846, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(329, 28);
            this.comboBox3.TabIndex = 72;
>>>>>>> 286d10f590318cf5a430e67a9267ef6b9ef8d7b0
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.DarkRed;
            this.btn_deleteUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Location = new System.Drawing.Point(913, 191);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(116, 38);
            this.btn_deleteUser.TabIndex = 75;
            this.btn_deleteUser.Text = "Remove";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(782, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 74;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_updateUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUser.ForeColor = System.Drawing.Color.White;
            this.btn_updateUser.Location = new System.Drawing.Point(647, 191);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(116, 38);
            this.btn_updateUser.TabIndex = 73;
            this.btn_updateUser.Text = "Add";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 315);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 254);
            this.dataGridView1.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(874, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Search by ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(998, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(98, 29);
            this.txtSearch.TabIndex = 77;
            // 
            // DefineClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_updateUser);
            this.Controls.Add(this.cbTeacher);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassNumOfStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DefineClass_Form";
            this.Text = "DefineClass_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassNumOfStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbTeacher;
        internal System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
    }
}