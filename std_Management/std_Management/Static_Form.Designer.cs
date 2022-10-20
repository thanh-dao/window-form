namespace Student_Management
{
    partial class Static_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_TotalStudents = new System.Windows.Forms.Label();
            this.lb_totalMale = new System.Windows.Forms.Label();
            this.lb_totalFemale = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lb_TotalStudents);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.lb_totalMale);
            this.panel2.Location = new System.Drawing.Point(12, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 86);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.Controls.Add(this.lb_totalFemale);
            this.panel3.Location = new System.Drawing.Point(312, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 86);
            this.panel3.TabIndex = 1;
            // 
            // lb_TotalStudents
            // 
            this.lb_TotalStudents.AutoSize = true;
            this.lb_TotalStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalStudents.Location = new System.Drawing.Point(153, 20);
            this.lb_TotalStudents.Name = "lb_TotalStudents";
            this.lb_TotalStudents.Size = new System.Drawing.Size(294, 46);
            this.lb_TotalStudents.TabIndex = 0;
            this.lb_TotalStudents.Text = "Total Students: 30";
            // 
            // lb_totalMale
            // 
            this.lb_totalMale.AutoSize = true;
            this.lb_totalMale.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalMale.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_totalMale.Location = new System.Drawing.Point(65, 20);
            this.lb_totalMale.Name = "lb_totalMale";
            this.lb_totalMale.Size = new System.Drawing.Size(180, 46);
            this.lb_totalMale.TabIndex = 0;
            this.lb_totalMale.Text = "Male: 60%";
            // 
            // lb_totalFemale
            // 
            this.lb_totalFemale.AutoSize = true;
            this.lb_totalFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_totalFemale.Location = new System.Drawing.Point(51, 20);
            this.lb_totalFemale.Name = "lb_totalFemale";
            this.lb_totalFemale.Size = new System.Drawing.Size(215, 46);
            this.lb_totalFemale.TabIndex = 1;
            this.lb_totalFemale.Text = "Female: 40%";
            // 
            // Static_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 205);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Static_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Static_Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TotalStudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_totalMale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_totalFemale;
    }
}