namespace Student_Management
{
    partial class ChangeTeacherForm
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
            this.lb_currentTeacher = new System.Windows.Forms.Label();
            this.txt_currentNameLecture = new System.Windows.Forms.TextBox();
            this.dtg_substituteTeacher = new System.Windows.Forms.DataGridView();
            this.lb_substituteTeacher = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_substituteTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_currentTeacher
            // 
            this.lb_currentTeacher.AutoSize = true;
            this.lb_currentTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentTeacher.Location = new System.Drawing.Point(37, 62);
            this.lb_currentTeacher.Name = "lb_currentTeacher";
            this.lb_currentTeacher.Size = new System.Drawing.Size(257, 41);
            this.lb_currentTeacher.TabIndex = 0;
            this.lb_currentTeacher.Text = "Current Lecturer:";
            // 
            // txt_currentNameLecture
            // 
            this.txt_currentNameLecture.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentNameLecture.Location = new System.Drawing.Point(309, 62);
            this.txt_currentNameLecture.Name = "txt_currentNameLecture";
            this.txt_currentNameLecture.Size = new System.Drawing.Size(265, 43);
            this.txt_currentNameLecture.TabIndex = 1;
            this.txt_currentNameLecture.Text = "Nguyễn Thế Hoàng";
            this.txt_currentNameLecture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtg_substituteTeacher
            // 
            this.dtg_substituteTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_substituteTeacher.Location = new System.Drawing.Point(44, 191);
            this.dtg_substituteTeacher.Name = "dtg_substituteTeacher";
            this.dtg_substituteTeacher.RowHeadersWidth = 51;
            this.dtg_substituteTeacher.RowTemplate.Height = 24;
            this.dtg_substituteTeacher.Size = new System.Drawing.Size(592, 250);
            this.dtg_substituteTeacher.TabIndex = 2;
            // 
            // lb_substituteTeacher
            // 
            this.lb_substituteTeacher.AutoSize = true;
            this.lb_substituteTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_substituteTeacher.Location = new System.Drawing.Point(37, 147);
            this.lb_substituteTeacher.Name = "lb_substituteTeacher";
            this.lb_substituteTeacher.Size = new System.Drawing.Size(279, 41);
            this.lb_substituteTeacher.TabIndex = 3;
            this.lb_substituteTeacher.Text = "Substitute Teacher";
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Change.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Change.Location = new System.Drawing.Point(44, 469);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(131, 56);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "CHANGE";
            this.btn_Change.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 469);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 56);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCLE";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ChangeTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 542);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lb_substituteTeacher);
            this.Controls.Add(this.dtg_substituteTeacher);
            this.Controls.Add(this.txt_currentNameLecture);
            this.Controls.Add(this.lb_currentTeacher);
            this.Name = "ChangeTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_substituteTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_currentTeacher;
        private System.Windows.Forms.TextBox txt_currentNameLecture;
        private System.Windows.Forms.DataGridView dtg_substituteTeacher;
        private System.Windows.Forms.Label lb_substituteTeacher;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Cancel;
    }
}