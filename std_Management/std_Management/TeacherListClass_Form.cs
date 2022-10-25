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
    public partial class TeacherListClass_Form : Form
    {
        public User user;
        public TeacherListClass_Form(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

            txtTeacherId.Text = user.UserId;
            txtTeacherId.Enabled = false;
            txtFirstName.Text = user.FirstName;
            txtFirstName.Enabled = false;
            txtLastName.Text = user.LastName;
            txtLastName.Enabled = false;


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

            dtgSujectList.DataSource = subjectClass;


            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtTeacherId.Text = user.UserId;
            txtTeacherId.Enabled = false;
            txtFirstName.Text = user.FirstName;
            txtFirstName.Enabled = false;
            txtLastName.Text = user.LastName;
            txtLastName.Enabled = false;


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

            }).Where(p => p.ClassId.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();

            
            dtgSujectList.DataSource = subjectClass;

        }
    }
}
