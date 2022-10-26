namespace std_Management
{
    partial class ClassList_Form
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
            this.txt_classId = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dtgClassList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(640, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by ID:";
            // 
            // txt_classId
            // 
            this.txt_classId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_classId.Location = new System.Drawing.Point(774, 21);
            this.txt_classId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_classId.Name = "txt_classId";
            this.txt_classId.Size = new System.Drawing.Size(125, 29);
            this.txt_classId.TabIndex = 6;
            this.txt_classId.TextChanged += new System.EventHandler(this.txt_classId_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(50, 514);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(202, 45);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dtgClassList
            // 
            this.dtgClassList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClassList.Location = new System.Drawing.Point(50, 63);
            this.dtgClassList.Name = "dtgClassList";
            this.dtgClassList.RowHeadersWidth = 51;
            this.dtgClassList.RowTemplate.Height = 24;
            this.dtgClassList.Size = new System.Drawing.Size(858, 435);
            this.dtgClassList.TabIndex = 4;
            this.dtgClassList.DoubleClick += new System.EventHandler(this.dtgClassList_DoubleClick);
            // 
            // ClassList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_classId);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dtgClassList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassList_Form";
            this.Text = "ClassList_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_classId;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dtgClassList;
    }
}