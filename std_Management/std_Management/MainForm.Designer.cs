namespace Student_Management
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.majorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJOR1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lECTUREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASSID2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASSID3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECT3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJOR2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJOR3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentToolStripMenuItem,
            this.majorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StudentToolStripMenuItem
            // 
            this.StudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentsListToolStripMenuItem,
            this.updateStudentInformationToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.managementStudentToolStripMenuItem,
            this.printStudentListToolStripMenuItem,
            this.sTUDENTToolStripMenuItem1,
            this.sTUDENTToolStripMenuItem2});
            this.StudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem";
            this.StudentToolStripMenuItem.Size = new System.Drawing.Size(130, 35);
            this.StudentToolStripMenuItem.Text = "STUDENT";
            this.StudentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.addNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.studentsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentsListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // updateStudentInformationToolStripMenuItem
            // 
            this.updateStudentInformationToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.updateStudentInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateStudentInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.updateStudentInformationToolStripMenuItem.Name = "updateStudentInformationToolStripMenuItem";
            this.updateStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.updateStudentInformationToolStripMenuItem.Text = "Update/Remove Student";
            this.updateStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.updateStudentInformationToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.staticToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staticToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.staticToolStripMenuItem.Text = "Statics";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // managementStudentToolStripMenuItem
            // 
            this.managementStudentToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.managementStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managementStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.managementStudentToolStripMenuItem.Name = "managementStudentToolStripMenuItem";
            this.managementStudentToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.managementStudentToolStripMenuItem.Text = "Management Student";
            // 
            // printStudentListToolStripMenuItem
            // 
            this.printStudentListToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.printStudentListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printStudentListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.printStudentListToolStripMenuItem.Name = "printStudentListToolStripMenuItem";
            this.printStudentListToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.printStudentListToolStripMenuItem.Text = "Print Student List";
            // 
            // sTUDENTToolStripMenuItem1
            // 
            this.sTUDENTToolStripMenuItem1.Name = "sTUDENTToolStripMenuItem1";
            this.sTUDENTToolStripMenuItem1.Size = new System.Drawing.Size(324, 36);
            this.sTUDENTToolStripMenuItem1.Text = "STUDENT";
            // 
            // sTUDENTToolStripMenuItem2
            // 
            this.sTUDENTToolStripMenuItem2.Name = "sTUDENTToolStripMenuItem2";
            this.sTUDENTToolStripMenuItem2.Size = new System.Drawing.Size(324, 36);
            this.sTUDENTToolStripMenuItem2.Text = "STUDENT";
            // 
            // majorToolStripMenuItem
            // 
            this.majorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.majorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAJOR1ToolStripMenuItem,
            this.mAJOR2ToolStripMenuItem,
            this.mAJOR3ToolStripMenuItem});
            this.majorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.majorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.majorToolStripMenuItem.Name = "majorToolStripMenuItem";
            this.majorToolStripMenuItem.Size = new System.Drawing.Size(105, 35);
            this.majorToolStripMenuItem.Text = "MAJOR";
            // 
            // mAJOR1ToolStripMenuItem
            // 
            this.mAJOR1ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.mAJOR1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUBJECT1ToolStripMenuItem,
            this.sUBJECT2ToolStripMenuItem,
            this.sUBJECT3ToolStripMenuItem});
            this.mAJOR1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mAJOR1ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.mAJOR1ToolStripMenuItem.Name = "mAJOR1ToolStripMenuItem";
            this.mAJOR1ToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.mAJOR1ToolStripMenuItem.Text = "MAJOR 1";
            // 
            // sUBJECT1ToolStripMenuItem
            // 
            this.sUBJECT1ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.sUBJECT1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLASSToolStripMenuItem,
            this.cLASSID2ToolStripMenuItem,
            this.cLASSID3ToolStripMenuItem});
            this.sUBJECT1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sUBJECT1ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.sUBJECT1ToolStripMenuItem.Name = "sUBJECT1ToolStripMenuItem";
            this.sUBJECT1ToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.sUBJECT1ToolStripMenuItem.Text = "SUBJECT 1";
            // 
            // cLASSToolStripMenuItem
            // 
            this.cLASSToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cLASSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lECTUREToolStripMenuItem,
            this.sTUDENTLISTToolStripMenuItem});
            this.cLASSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cLASSToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.cLASSToolStripMenuItem.Name = "cLASSToolStripMenuItem";
            this.cLASSToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.cLASSToolStripMenuItem.Text = "CLASS_ID 1 ";
            // 
            // lECTUREToolStripMenuItem
            // 
            this.lECTUREToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.lECTUREToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lECTUREToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.lECTUREToolStripMenuItem.Name = "lECTUREToolStripMenuItem";
            this.lECTUREToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.lECTUREToolStripMenuItem.Text = "LECTURE";
            this.lECTUREToolStripMenuItem.Click += new System.EventHandler(this.lECTUREToolStripMenuItem_Click);
            // 
            // sTUDENTLISTToolStripMenuItem
            // 
            this.sTUDENTLISTToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.sTUDENTLISTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sTUDENTLISTToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.sTUDENTLISTToolStripMenuItem.Name = "sTUDENTLISTToolStripMenuItem";
            this.sTUDENTLISTToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.sTUDENTLISTToolStripMenuItem.Text = "STUDENT LIST";
            this.sTUDENTLISTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTLISTToolStripMenuItem_Click);
            // 
            // cLASSID2ToolStripMenuItem
            // 
            this.cLASSID2ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cLASSID2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cLASSID2ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.cLASSID2ToolStripMenuItem.Name = "cLASSID2ToolStripMenuItem";
            this.cLASSID2ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.cLASSID2ToolStripMenuItem.Text = "CLASS_ID 2";
            // 
            // cLASSID3ToolStripMenuItem
            // 
            this.cLASSID3ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.cLASSID3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cLASSID3ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.cLASSID3ToolStripMenuItem.Name = "cLASSID3ToolStripMenuItem";
            this.cLASSID3ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.cLASSID3ToolStripMenuItem.Text = "CLASS_ID 3";
            // 
            // sUBJECT2ToolStripMenuItem
            // 
            this.sUBJECT2ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.sUBJECT2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sUBJECT2ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.sUBJECT2ToolStripMenuItem.Name = "sUBJECT2ToolStripMenuItem";
            this.sUBJECT2ToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.sUBJECT2ToolStripMenuItem.Text = "SUBJECT 2";
            // 
            // sUBJECT3ToolStripMenuItem
            // 
            this.sUBJECT3ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.sUBJECT3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sUBJECT3ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.sUBJECT3ToolStripMenuItem.Name = "sUBJECT3ToolStripMenuItem";
            this.sUBJECT3ToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.sUBJECT3ToolStripMenuItem.Text = "SUBJECT 3";
            // 
            // mAJOR2ToolStripMenuItem
            // 
            this.mAJOR2ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.mAJOR2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mAJOR2ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.mAJOR2ToolStripMenuItem.Name = "mAJOR2ToolStripMenuItem";
            this.mAJOR2ToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.mAJOR2ToolStripMenuItem.Text = "MAJOR 2";
            // 
            // mAJOR3ToolStripMenuItem
            // 
            this.mAJOR3ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.mAJOR3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mAJOR3ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.mAJOR3ToolStripMenuItem.Name = "mAJOR3ToolStripMenuItem";
            this.mAJOR3ToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.mAJOR3ToolStripMenuItem.Text = "MAJOR 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 769);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem majorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJOR1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lECTUREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASSID2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASSID3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECT3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJOR2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJOR3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem2;
    }
}