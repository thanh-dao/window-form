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

        private void subjectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<User>();
            var user = repo.GetAll().Where(i => i.UserId == acc.UserId).FirstOrDefault();
            StdSubjectList_Form stdSubjectList = new StdSubjectList_Form(user);
         
            stdSubjectList.txtStudenId.Text = user.UserId;
            stdSubjectList.txtStudenId.Enabled = false;
            stdSubjectList.txtFirstName.Text = user.FirstName;
            stdSubjectList.txtFirstName.Enabled = false;
            stdSubjectList.txtLastName.Text = user.LastName;
            stdSubjectList.txtLastName.Enabled = false;



            var classStudent = new RepositoryBase<ClassStudent>().GetAll().Where(i => i.StudentId.Equals(user.UserId)).ToList();

            var subjectClass = new RepositoryBase<ClassSubject>().GetAll().ToList();

            var listClass = new List<ClassSubject>();
              
            foreach (var subject in subjectClass)
                {
                    foreach (var student in classStudent)
                    {
                    if(student.ClassId.Equals(subject.ClassId))
                        {
                        listClass.Add(subject);
                    }
                 }
            }

            var subjects = new List<SubjectTeacher>();

            var repoSubject = new RepositoryBase<SubjectTeacher>().GetAll().ToList();

            foreach (var subjectTeacher in repoSubject)
            {
                foreach(var student in listClass)
                {
                    if (subjectTeacher.SubjectTeacherId.Equals(student.SubjectTeacherId))
                    {
                        subjects.Add(subjectTeacher);
                    }
                }    
            }

            var studentInfor = subjects.Select(i => new
            {
                i.SubjectId,
                i.SubjectTeacherId,
                i.TeacherId,
            }).ToList();



            stdSubjectList.dtgSujectList.DataSource = studentInfor;

            stdSubjectList.Show();

            /*  cbSubject.DataSource = subjectIds;

              var repo = new RepositoryBase<Subject>();
              stdSubjectList.dtgSujectList.DataSource = repo.GetAll()*/
        }
    }
}
