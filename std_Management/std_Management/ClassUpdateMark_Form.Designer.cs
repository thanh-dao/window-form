namespace std_Management
{
    partial class ClassUpdateMark_Form
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
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dtgClassUpdateMark = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassUpdateMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(730, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search by ID:";
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassId.Location = new System.Drawing.Point(894, 21);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(142, 34);
            this.txtClassId.TabIndex = 10;
            this.txtClassId.TextChanged += new System.EventHandler(this.txt_userId_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Location = new System.Drawing.Point(56, 679);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(231, 60);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dtgClassUpdateMark
            // 
            this.dtgClassUpdateMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClassUpdateMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClassUpdateMark.Location = new System.Drawing.Point(56, 77);
            this.dtgClassUpdateMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgClassUpdateMark.Name = "dtgClassUpdateMark";
            this.dtgClassUpdateMark.RowHeadersWidth = 51;
            this.dtgClassUpdateMark.RowTemplate.Height = 24;
            this.dtgClassUpdateMark.Size = new System.Drawing.Size(980, 580);
            this.dtgClassUpdateMark.TabIndex = 8;
            this.dtgClassUpdateMark.DoubleClick += new System.EventHandler(this.dtgClassUpdateMark_DoubleClick);
            // 
            // ClassUpdateMark_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dtgClassUpdateMark);
            this.Name = "ClassUpdateMark_Form";
            this.Text = "ClassUpdateMark_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassUpdateMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dtgClassUpdateMark;
    }
}