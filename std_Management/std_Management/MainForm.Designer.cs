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
            this.printStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECTSLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSUBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEREMOVESUBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDCLASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWCLASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATECLASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEFINETECHERSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentToolStripMenuItem,
            this.sUBJECTSToolStripMenuItem,
            this.mARKToolStripMenuItem,
            this.cLASSToolStripMenuItem1});
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
            this.printStudentListToolStripMenuItem});
            this.StudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem";
            this.StudentToolStripMenuItem.Size = new System.Drawing.Size(83, 35);
            this.StudentToolStripMenuItem.Text = "USER";
            this.StudentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.addNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.studentsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentsListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // updateStudentInformationToolStripMenuItem
            // 
            this.updateStudentInformationToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.updateStudentInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateStudentInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.updateStudentInformationToolStripMenuItem.Name = "updateStudentInformationToolStripMenuItem";
            this.updateStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.updateStudentInformationToolStripMenuItem.Text = "Update/Remove Student";
            this.updateStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.updateStudentInformationToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.staticToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staticToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.staticToolStripMenuItem.Text = "Statics";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // printStudentListToolStripMenuItem
            // 
            this.printStudentListToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.printStudentListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printStudentListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.printStudentListToolStripMenuItem.Name = "printStudentListToolStripMenuItem";
            this.printStudentListToolStripMenuItem.Size = new System.Drawing.Size(324, 32);
            this.printStudentListToolStripMenuItem.Text = "Print Student List";
            // 
            // sUBJECTSToolStripMenuItem
            // 
            this.sUBJECTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUBJECTSLISTToolStripMenuItem,
            this.aDDSUBJECTToolStripMenuItem,
            this.uPDATEREMOVESUBJECTToolStripMenuItem});
            this.sUBJECTSToolStripMenuItem.Name = "sUBJECTSToolStripMenuItem";
            this.sUBJECTSToolStripMenuItem.Size = new System.Drawing.Size(80, 35);
            this.sUBJECTSToolStripMenuItem.Text = "SUBJECT";
            // 
            // sUBJECTSLISTToolStripMenuItem
            // 
            this.sUBJECTSLISTToolStripMenuItem.Name = "sUBJECTSLISTToolStripMenuItem";
            this.sUBJECTSLISTToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.sUBJECTSLISTToolStripMenuItem.Text = "SUBJECT LIST";
            this.sUBJECTSLISTToolStripMenuItem.Click += new System.EventHandler(this.sUBJECTSLISTToolStripMenuItem_Click);
            // 
            // aDDSUBJECTToolStripMenuItem
            // 
            this.aDDSUBJECTToolStripMenuItem.Name = "aDDSUBJECTToolStripMenuItem";
            this.aDDSUBJECTToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.aDDSUBJECTToolStripMenuItem.Text = "ADD SUBJECT";
            this.aDDSUBJECTToolStripMenuItem.Click += new System.EventHandler(this.aDDSUBJECTToolStripMenuItem_Click);
            // 
            // uPDATEREMOVESUBJECTToolStripMenuItem
            // 
            this.uPDATEREMOVESUBJECTToolStripMenuItem.Name = "uPDATEREMOVESUBJECTToolStripMenuItem";
            this.uPDATEREMOVESUBJECTToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.uPDATEREMOVESUBJECTToolStripMenuItem.Text = "UPDATE/REMOVE SUBJECT";
            // 
            // mARKToolStripMenuItem
            // 
            this.mARKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classListToolStripMenuItem});
            this.mARKToolStripMenuItem.Name = "mARKToolStripMenuItem";
            this.mARKToolStripMenuItem.Size = new System.Drawing.Size(170, 35);
            this.mARKToolStripMenuItem.Text = "MARK MANAGEMENT";
            // 
            // classListToolStripMenuItem
            // 
            this.classListToolStripMenuItem.Name = "classListToolStripMenuItem";
            this.classListToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.classListToolStripMenuItem.Text = "CLASS LIST";
            // 
            // cLASSToolStripMenuItem1
            // 
            this.cLASSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDCLASSToolStripMenuItem,
            this.aDDNEWCLASSToolStripMenuItem,
            this.uPDATECLASSToolStripMenuItem,
            this.dEFINETECHERSTUDENTToolStripMenuItem});
            this.cLASSToolStripMenuItem1.Name = "cLASSToolStripMenuItem1";
            this.cLASSToolStripMenuItem1.Size = new System.Drawing.Size(65, 35);
            this.cLASSToolStripMenuItem1.Text = "CLASS";
            // 
            // aDDCLASSToolStripMenuItem
            // 
            this.aDDCLASSToolStripMenuItem.Name = "aDDCLASSToolStripMenuItem";
            this.aDDCLASSToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.aDDCLASSToolStripMenuItem.Text = "CLASS LIST";
            // 
            // aDDNEWCLASSToolStripMenuItem
            // 
            this.aDDNEWCLASSToolStripMenuItem.Name = "aDDNEWCLASSToolStripMenuItem";
            this.aDDNEWCLASSToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.aDDNEWCLASSToolStripMenuItem.Text = "ADD NEW CLASS";
            // 
            // uPDATECLASSToolStripMenuItem
            // 
            this.uPDATECLASSToolStripMenuItem.Name = "uPDATECLASSToolStripMenuItem";
            this.uPDATECLASSToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.uPDATECLASSToolStripMenuItem.Text = "UPDATE/REMOVE CLASS";
            // 
            // dEFINETECHERSTUDENTToolStripMenuItem
            // 
            this.dEFINETECHERSTUDENTToolStripMenuItem.Name = "dEFINETECHERSTUDENTToolStripMenuItem";
            this.dEFINETECHERSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.dEFINETECHERSTUDENTToolStripMenuItem.Text = "DEFINE TECHER/STUDENT";
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
        private System.Windows.Forms.ToolStripMenuItem printStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECTSLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSUBJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEREMOVESUBJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aDDCLASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWCLASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATECLASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEFINETECHERSTUDENTToolStripMenuItem;
    }
}