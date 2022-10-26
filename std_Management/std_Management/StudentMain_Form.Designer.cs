namespace std_Management
{
    partial class StudentMain_Form
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
            this.pROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROFILEToolStripMenuItem,
            this.sUBJECTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROFILEToolStripMenuItem
            // 
            this.pROFILEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pROFILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourInformationToolStripMenuItem});
            this.pROFILEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pROFILEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pROFILEToolStripMenuItem.Name = "pROFILEToolStripMenuItem";
            this.pROFILEToolStripMenuItem.Size = new System.Drawing.Size(114, 35);
            this.pROFILEToolStripMenuItem.Text = "PROFILE";
            // 
            // yourInformationToolStripMenuItem
            // 
            this.yourInformationToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.yourInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.yourInformationToolStripMenuItem.Name = "yourInformationToolStripMenuItem";
            this.yourInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.yourInformationToolStripMenuItem.Text = "Your Information";
            this.yourInformationToolStripMenuItem.Click += new System.EventHandler(this.yourInformationToolStripMenuItem_Click);
            // 
            // sUBJECTToolStripMenuItem
            // 
            this.sUBJECTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sUBJECTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectListToolStripMenuItem});
            this.sUBJECTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sUBJECTToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.sUBJECTToolStripMenuItem.Name = "sUBJECTToolStripMenuItem";
            this.sUBJECTToolStripMenuItem.Size = new System.Drawing.Size(119, 35);
            this.sUBJECTToolStripMenuItem.Text = "SUBJECT";
            // 
            // subjectListToolStripMenuItem
            // 
            this.subjectListToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.subjectListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.subjectListToolStripMenuItem.Name = "subjectListToolStripMenuItem";
            this.subjectListToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.subjectListToolStripMenuItem.Text = "Subject List";
            this.subjectListToolStripMenuItem.Click += new System.EventHandler(this.subjectListToolStripMenuItem_Click);
            // 
            // StudentMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 232);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudentMain_Form";
            this.Text = "StudentMain_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROFILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectListToolStripMenuItem;
    }
}