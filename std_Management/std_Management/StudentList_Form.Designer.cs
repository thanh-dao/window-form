namespace Student_Management
{
    partial class StudentList_Form
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
            this.dtg_studentList = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_studentList
            // 
            this.dtg_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_studentList.Location = new System.Drawing.Point(12, 78);
            this.dtg_studentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_studentList.Name = "dtg_studentList";
            this.dtg_studentList.RowHeadersWidth = 51;
            this.dtg_studentList.RowTemplate.Height = 24;
            this.dtg_studentList.Size = new System.Drawing.Size(980, 580);
            this.dtg_studentList.TabIndex = 0;
            this.dtg_studentList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_studentList_ColumnHeaderMouseClick);
            this.dtg_studentList.DoubleClick += new System.EventHandler(this.dtg_studentList_DoubleClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(12, 680);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(231, 60);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(839, 22);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(142, 27);
            this.txt_userId.TabIndex = 2;
            this.txt_userId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by id";
            // 
            // StudentList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dtg_studentList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentList_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentList_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_studentList;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.Label label1;
    }
}