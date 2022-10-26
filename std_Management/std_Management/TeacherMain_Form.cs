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

        private void subjectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();

            TeacherListSubject_Form teacherListSubject = new TeacherListSubject_Form(user);

            teacherListSubject.txtTeacherId.Text = user.UserId;
            teacherListSubject.txtTeacherId.Enabled = false;
            teacherListSubject.txtFirstName.Text = user.FirstName;
            teacherListSubject.txtFirstName.Enabled = false;
            teacherListSubject.txtLastName.Text = user.LastName;
            teacherListSubject.txtLastName.Enabled = false;

            var repoSubjectTeacher = new RepositoryBase<SubjectTeacher>();
            var subjectList = repoSubjectTeacher.GetAll().Where(p => p.TeacherId.Equals(user.UserId)).Select(p => new { p.TeacherId, p.SubjectId }).ToList();

            teacherListSubject.dtgSujectList.DataSource = subjectList;


            teacherListSubject.Show();
        }


        private void classListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();

            TeacherListClass_Form TeacherListClass = new TeacherListClass_Form(user);

            TeacherListClass.txtTeacherId.Text = user.UserId;
            TeacherListClass.txtTeacherId.Enabled = false;
            TeacherListClass.txtFirstName.Text = user.FirstName;
            TeacherListClass.txtFirstName.Enabled = false;
            TeacherListClass.txtLastName.Text = user.LastName;
            TeacherListClass.txtLastName.Enabled = false;


            var repoSubjectTeacher = new RepositoryBase<SubjectTeacher>().GetAll().Where(p => p.TeacherId.Equals(user.UserId)).ToList();
            var repoClassSubject = new RepositoryBase<ClassSubject>().GetAll().ToList();

            var subjects = new List<ClassSubject>();

            foreach (var SubjectTeacher in repoSubjectTeacher)
            {
                foreach (var classSubject in repoClassSubject)
                {
                    if (classSubject.SubjectTeacherId.Equals(SubjectTeacher.SubjectTeacherId))
                    {
                        subjects.Add(classSubject);
                    }
                }
            }

            var subjectClass = subjects.Select(i => new
            {
                i.ClassId,
                i.SubjectTeacherId,

            }).ToList();

            TeacherListClass.dtgSujectList.DataSource = subjectClass;

            TeacherListClass.Show();
        }
    }
}
