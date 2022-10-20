using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class UpdateRemoveStudent_Form : Form
    {
        public UpdateRemoveStudent_Form()
        {
            InitializeComponent();
        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            //upload ảnh từ máy tính
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
