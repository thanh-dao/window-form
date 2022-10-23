namespace std_Management
{
    partial class AddSubject_Form
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
            this.lbNumOfCredits = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudNumOfCredits = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumOfCredits
            // 
            this.lbNumOfCredits.AutoSize = true;
            this.lbNumOfCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumOfCredits.Location = new System.Drawing.Point(35, 200);
            this.lbNumOfCredits.Name = "lbNumOfCredits";
            this.lbNumOfCredits.Size = new System.Drawing.Size(189, 28);
            this.lbNumOfCredits.TabIndex = 47;
            this.lbNumOfCredits.Text = "Number Of Credits:";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectName.Location = new System.Drawing.Point(80, 121);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(144, 28);
            this.lbSubjectName.TabIndex = 46;
            this.lbSubjectName.Text = "Subject Name:";
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_updateUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUser.ForeColor = System.Drawing.Color.White;
            this.btn_updateUser.Location = new System.Drawing.Point(114, 305);
            this.btn_updateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(157, 78);
            this.btn_updateUser.TabIndex = 44;
            this.btn_updateUser.Text = "Add";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubjectName.Location = new System.Drawing.Point(256, 121);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(241, 34);
            this.txtSubjectName.TabIndex = 43;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubjectID.Location = new System.Drawing.Point(256, 53);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(241, 34);
            this.txtSubjectID.TabIndex = 41;
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectID.Location = new System.Drawing.Point(114, 53);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(110, 28);
            this.lbSubjectID.TabIndex = 40;
            this.lbSubjectID.Text = "Subject ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(340, 305);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 78);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudNumOfCredits
            // 
            this.nudNumOfCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudNumOfCredits.Location = new System.Drawing.Point(256, 201);
            this.nudNumOfCredits.Name = "nudNumOfCredits";
            this.nudNumOfCredits.Size = new System.Drawing.Size(241, 34);
            this.nudNumOfCredits.TabIndex = 48;
            // 
            // AddSubject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(this.nudNumOfCredits);
            this.Controls.Add(this.lbNumOfCredits);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_updateUser);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "AddSubject_Form";
            this.Text = "AddSubject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumOfCredits;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label lbSubjectID;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudNumOfCredits;
    }
}