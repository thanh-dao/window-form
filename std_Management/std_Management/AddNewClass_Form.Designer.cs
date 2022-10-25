namespace std_Management
{
    partial class AddNewClass_Form
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
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.dtgAddNewClass = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btnRemoveClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.nudNumOfStudent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddNewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddNewClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewClass.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClass.Location = new System.Drawing.Point(167, 236);
            this.btnAddNewClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Size = new System.Drawing.Size(132, 50);
            this.btnAddNewClass.TabIndex = 59;
            this.btnAddNewClass.Text = "Add";
            this.btnAddNewClass.UseVisualStyleBackColor = false;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(650, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Search by ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Number Of Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Class Name:";
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClassID.Location = new System.Drawing.Point(138, 34);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(88, 28);
            this.lbClassID.TabIndex = 51;
            this.lbClassID.Text = "Class ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(791, 296);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 34);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassName.Location = new System.Drawing.Point(274, 91);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(329, 34);
            this.txtClassName.TabIndex = 48;
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassId.Location = new System.Drawing.Point(274, 28);
            this.txtClassId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(329, 34);
            this.txtClassId.TabIndex = 47;
            // 
            // dtgAddNewClass
            // 
            this.dtgAddNewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddNewClass.Location = new System.Drawing.Point(59, 351);
            this.dtgAddNewClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgAddNewClass.Name = "dtgAddNewClass";
            this.dtgAddNewClass.RowHeadersWidth = 51;
            this.dtgAddNewClass.RowTemplate.Height = 25;
            this.dtgAddNewClass.Size = new System.Drawing.Size(844, 275);
            this.dtgAddNewClass.TabIndex = 46;
            this.dtgAddNewClass.DoubleClick += new System.EventHandler(this.dtgAddNewClass_DoubleClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(59, 667);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(231, 60);
            this.btn_refresh.TabIndex = 60;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveClass.ForeColor = System.Drawing.Color.White;
            this.btnRemoveClass.Location = new System.Drawing.Point(471, 236);
            this.btnRemoveClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(132, 50);
            this.btnRemoveClass.TabIndex = 62;
            this.btnRemoveClass.Text = "Remove";
            this.btnRemoveClass.UseVisualStyleBackColor = false;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateClass.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClass.Location = new System.Drawing.Point(322, 236);
            this.btnUpdateClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(132, 50);
            this.btnUpdateClass.TabIndex = 61;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // nudNumOfStudent
            // 
            this.nudNumOfStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudNumOfStudent.Location = new System.Drawing.Point(274, 168);
            this.nudNumOfStudent.Name = "nudNumOfStudent";
            this.nudNumOfStudent.Size = new System.Drawing.Size(329, 34);
            this.nudNumOfStudent.TabIndex = 63;
            // 
            // AddNewClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 760);
            this.Controls.Add(this.nudNumOfStudent);
            this.Controls.Add(this.btnRemoveClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btnAddNewClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.dtgAddNewClass);
            this.Name = "AddNewClass_Form";
            this.Text = "AddNewClass_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddNewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.DataGridView dtgAddNewClass;
        private System.Windows.Forms.Button btn_refresh;
        internal System.Windows.Forms.Button btnRemoveClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.NumericUpDown nudNumOfStudent;
    }
}