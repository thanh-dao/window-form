using Microsoft.VisualBasic.ApplicationServices;
using std_Management;
using std_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = std_Management.Models.User;

namespace Student_Management
{
    public partial class MainForm : Form
    {
        public Account acc;
        public MainForm(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            //AllocConsole();
        }
        /*[DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();*/
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
            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();

            updateRemoveStdF.txt_userid.Text = user.UserId;
            updateRemoveStdF.txt_userid.Enabled = false;
            updateRemoveStdF.txt_firstname.Text = user.FirstName;
            updateRemoveStdF.txt_lastname.Text = user.LastName;
            updateRemoveStdF.dtp_birthdate.Value = user.BirthDate;

            if (user.Gender == true)
            {
                updateRemoveStdF.rdo_female.Checked = true;
            }
            if (user.Gender == false)
            {
                updateRemoveStdF.rdo_male.Checked = true;
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

        private void sUBJECTSLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           subjectList_Form subjectList_Form = new subjectList_Form();
            subjectList_Form.Show(this);
        }

        private void aDDSUBJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject_Form AddSubject_Form = new AddSubject_Form();
            AddSubject_Form.Show(this);
        }

        private void classListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassUpdateMark_Form ClassUpdateMark = new ClassUpdateMark_Form();
            ClassUpdateMark.Show(this);
        }

        private void aDDCLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassList_Form ClassList = new ClassList_Form();
            ClassList.Show(this);
        }
        private void uPDATECLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewClass_Form addNewClass = new AddNewClass_Form();
            addNewClass.Show(this);
        }

        private void dEFINETECHERSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
