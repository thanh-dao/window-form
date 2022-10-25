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
    public partial class StudentMain_Form : Form
    {
        public Account acc;
        public StudentMain_Form(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void yourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentProfile_Form studentForm = new StudentProfile_Form();
           
            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();

            studentForm.txt_userid.Text = user.UserId;
            studentForm.txt_userid.Enabled = false;
            studentForm.txt_firstname.Text = user.FirstName;
            studentForm.txt_lastname.Text = user.LastName;
            studentForm.dtp_birthdate.Value = user.BirthDate;

            if (user.Gender == true)
            {
                studentForm.rdo_female.Checked = true;
            }
            if (user.Gender == false)
            {
                studentForm.rdo_male.Checked = true;
            }
            studentForm.txt_phone.Text = user.Phone;
            studentForm.txt_email.Text = user.Email;
            studentForm.txt_email.Enabled = false;
            studentForm.txt_address.Text = user.Address;
            studentForm.Show();
        }
    }
}
