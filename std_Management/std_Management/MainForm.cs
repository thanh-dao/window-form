using std_Management.Models;
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
    public partial class MainForm : Form
    {
        User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudent_Form addStdF = new AddNewStudent_Form();
            addStdF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList_Form stdListF = new StudentList_Form();
            stdListF.Show(this);
        }

        private void updateStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRemoveStudent_Form updateRemoveStdF = new UpdateRemoveStudent_Form();

            updateRemoveStdF.txt_userid.Text = user.UserId;
            updateRemoveStdF.txt_firstname.Text = user.FirstName;
            updateRemoveStdF.txt_lastname.Text = user.LastName;
            updateRemoveStdF.dtp_birthdate.Value = user.BirthDate;

            if (user.Gender == true)
            {
                updateRemoveStdF.rdo_male.Checked = true;
            }
            if (user.Gender == false)
            {
                updateRemoveStdF.rdo_female.Checked = true;
            }
            updateRemoveStdF.txt_phone.Text = user.Phone;
            updateRemoveStdF.txt_email.Text = user.Email;
            updateRemoveStdF.txt_address.Text = user.Address;
            updateRemoveStdF.btn_deleteUser.Enabled = false;
            updateRemoveStdF.Show(this);
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Static_Form staticF = new Static_Form();
            staticF.Show(this);
        }

        private void lECTUREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTeacherForm changeTeacherF = new ChangeTeacherForm();
            changeTeacherF.Show(this);
        }

        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeleteStdInClassForm addDeleteStdInClassF = new AddDeleteStdInClassForm();
            addDeleteStdInClassF.Show(this);
        }
    }
}
