namespace std_Management
{
    partial class subjectList_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subjectId = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dtgSujectList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSujectList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(718, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by ID:";
            // 
            // txt_subjectId
            // 
            this.txt_subjectId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_subjectId.Location = new System.Drawing.Point(871, 31);
            this.txt_subjectId.Name = "txt_subjectId";
            this.txt_subjectId.Size = new System.Drawing.Size(142, 34);
            this.txt_subjectId.TabIndex = 6;
            this.txt_subjectId.TextChanged += new System.EventHandler(this.txt_subjectId_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(44, 689);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(231, 60);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dtgSujectList
            // 
            this.dtgSujectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSujectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSujectList.Location = new System.Drawing.Point(44, 87);
            this.dtgSujectList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgSujectList.Name = "dtgSujectList";
            this.dtgSujectList.RowHeadersWidth = 51;
            this.dtgSujectList.RowTemplate.Height = 24;
            this.dtgSujectList.Size = new System.Drawing.Size(980, 580);
            this.dtgSujectList.TabIndex = 4;
            this.dtgSujectList.DoubleClick += new System.EventHandler(this.dtgSujectList_DoubleClick);
            // 
            // subjectList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subjectId);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dtgSujectList);
            this.Name = "subjectList_Form";
            this.Text = "subjectList_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSujectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subjectId;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dtgSujectList;
    }
}