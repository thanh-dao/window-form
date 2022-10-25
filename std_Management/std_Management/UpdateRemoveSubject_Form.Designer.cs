namespace std_Management
{
    partial class UpdateRemoveSubject_Form
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
            this.nudNumOfCredits = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfCredits = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.lbSubjectID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumOfCredits
            // 
            this.nudNumOfCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudNumOfCredits.Location = new System.Drawing.Point(220, 143);
            this.nudNumOfCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumOfCredits.Name = "nudNumOfCredits";
            this.nudNumOfCredits.Size = new System.Drawing.Size(288, 29);
            this.nudNumOfCredits.TabIndex = 64;
            // 
            // lbNumOfCredits
            // 
            this.lbNumOfCredits.AutoSize = true;
            this.lbNumOfCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumOfCredits.Location = new System.Drawing.Point(26, 142);
            this.lbNumOfCredits.Name = "lbNumOfCredits";
            this.lbNumOfCredits.Size = new System.Drawing.Size(152, 21);
            this.lbNumOfCredits.TabIndex = 63;
            this.lbNumOfCredits.Text = "Number Of Credits:";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectName.Location = new System.Drawing.Point(66, 83);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(116, 21);
            this.lbSubjectName.TabIndex = 62;
            this.lbSubjectName.Text = "Subject Name:";
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSubject.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSubject.Location = new System.Drawing.Point(308, 215);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(137, 58);
            this.btnRemoveSubject.TabIndex = 61;
            this.btnRemoveSubject.Text = "Remove";
            this.btnRemoveSubject.UseVisualStyleBackColor = false;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btn_deleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSubject.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSubject.Location = new System.Drawing.Point(110, 215);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(137, 58);
            this.btnUpdateSubject.TabIndex = 60;
            this.btnUpdateSubject.Text = "Update";
            this.btnUpdateSubject.UseVisualStyleBackColor = false;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubjectName.Location = new System.Drawing.Point(220, 83);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(288, 29);
            this.txtSubjectName.TabIndex = 59;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubjectID.Location = new System.Drawing.Point(220, 32);
            this.txtSubjectID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(288, 29);
            this.txtSubjectID.TabIndex = 58;
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectID.Location = new System.Drawing.Point(95, 32);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(89, 21);
            this.lbSubjectID.TabIndex = 57;
            this.lbSubjectID.Text = "Subject ID:";
            // 
            // UpdateRemoveSubject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 338);
            this.Controls.Add(this.nudNumOfCredits);
            this.Controls.Add(this.lbNumOfCredits);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.btnRemoveSubject);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lbSubjectID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateRemoveSubject_Form";
            this.Text = "UpdateRemoveSubject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown nudNumOfCredits;
        private System.Windows.Forms.Label lbNumOfCredits;
        private System.Windows.Forms.Label lbSubjectName;
        internal System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        internal System.Windows.Forms.TextBox txtSubjectName;
        internal System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label lbSubjectID;
    }
}