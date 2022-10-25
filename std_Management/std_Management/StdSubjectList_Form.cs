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
    public partial class StdSubjectList_Form : Form
    {
        public User user;
        public StdSubjectList_Form(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

            txtStudenId.Text = user.UserId;
            txtStudenId.Enabled = false;
            txtFirstName.Text = user.FirstName;
            txtFirstName.Enabled = false;
            txtLastName.Text = user.LastName;
            txtLastName.Enabled = false;



            var classStudent = new RepositoryBase<ClassStudent>().GetAll().Where(i => i.StudentId.Equals(user.UserId)).ToList();

            var subjectClass = new RepositoryBase<ClassSubject>().GetAll().ToList();

            var listClass = new List<ClassSubject>();

            foreach (var subject in subjectClass)
            {
                foreach (var student in classStudent)
                {
                    if (student.ClassId.Equals(subject.ClassId))
                    {
                        listClass.Add(subject);
                    }
                }
            }

            var subjects = new List<SubjectTeacher>();

            var repoSubject = new RepositoryBase<SubjectTeacher>().GetAll().ToList();

            foreach (var subjectTeacher in repoSubject)
            {
                foreach (var student in listClass)
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

            dtgSujectList.DataSource = studentInfor;
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            txtStudenId.Text = user.UserId;
            txtStudenId.Enabled = false;
            txtFirstName.Text = user.FirstName;
            txtFirstName.Enabled = false;
            txtLastName.Text = user.LastName;
            txtLastName.Enabled = false;



            var classStudent = new RepositoryBase<ClassStudent>().GetAll().Where(i => i.StudentId.Equals(user.UserId)).ToList();

            var subjectClass = new RepositoryBase<ClassSubject>().GetAll().ToList();

            var listClass = new List<ClassSubject>();

            foreach (var subject in subjectClass)
            {
                foreach (var student in classStudent)
                {
                    if (student.ClassId.Equals(subject.ClassId))
                    {
                        listClass.Add(subject);
                    }
                }
            }

            var subjects = new List<SubjectTeacher>();

            var repoSubject = new RepositoryBase<SubjectTeacher>().GetAll().ToList();

            foreach (var subjectTeacher in repoSubject)
            {
                foreach (var student in listClass)
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
            }).Where(p => p.SubjectId.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            dtgSujectList.DataSource = studentInfor;

        }
    }
}
