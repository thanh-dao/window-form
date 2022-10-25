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

namespace std_Management
{
    public partial class TeacherMain_Form : Form
    {
        public Account acc;
        public TeacherMain_Form(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void yourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherProfile_Form TeacherForm = new TeacherProfile_Form();

            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();

            TeacherForm.txt_userid.Text = user.UserId;
            TeacherForm.txt_userid.Enabled = false;
            TeacherForm.txt_firstname.Text = user.FirstName;
            TeacherForm.txt_lastname.Text = user.LastName;
            TeacherForm.dtp_birthdate.Value = user.BirthDate;

            if (user.Gender == true)
            {
                TeacherForm.rdo_female.Checked = true;
            }
            if (user.Gender == false)
            {
                TeacherForm.rdo_male.Checked = true;
            }
            TeacherForm.txt_phone.Text = user.Phone;
            TeacherForm.txt_email.Text = user.Email;
            TeacherForm.txt_email.Enabled = false;
            TeacherForm.txt_address.Text = user.Address;
            TeacherForm.Show();
        }
    }
}
