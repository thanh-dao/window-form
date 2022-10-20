using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class StudentList_Form : Form
    {
        public StudentList_Form()
        {
            InitializeComponent();
        }

        private void dtg_studentList_DoubleClick(object sender, EventArgs e)
        {
            //Display the selected student in the new form to edit/remove
            UpdateRemoveStudent_Form updateRemoveStdF = new UpdateRemoveStudent_Form();
            updateRemoveStdF.txt_studentid.Text = dtg_studentList.CurrentRow.Cells[0].Value.ToString();
            updateRemoveStdF.txt_firstname.Text = dtg_studentList.CurrentRow.Cells[1].Value.ToString();
            updateRemoveStdF.txt_lastname.Text = dtg_studentList.CurrentRow.Cells[2].Value.ToString();
            updateRemoveStdF.dtp_birthdate.Value = (DateTime)dtg_studentList.CurrentRow.Cells[3].Value;

            if(dtg_studentList.CurrentRow.Cells[4].Value.ToString() == "0")
            {
                updateRemoveStdF.rdo_male.Checked = true;
            }

            updateRemoveStdF.txt_phone.Text = dtg_studentList.CurrentRow.Cells[5].Value.ToString();
            updateRemoveStdF.txt_email.Text = dtg_studentList.CurrentRow.Cells[6].Value.ToString();
            updateRemoveStdF.txt_address.Text = dtg_studentList.CurrentRow.Cells[7].Value.ToString();

            byte[] pic;
            pic = (byte[])dtg_studentList.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateRemoveStdF.pictureBoxStudentImage.Image = Image.FromStream(picture);
            updateRemoveStdF.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //refresh the datagridview data
        }
    }
}
