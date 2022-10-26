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
    public partial class TeacherListSubject_Form : Form
    {
        public User user;
        public TeacherListSubject_Form(User u)
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

            var repoSubjectTeacher = new RepositoryBase<SubjectTeacher>();
            var subjectList = repoSubjectTeacher.GetAll().Where(p => p.TeacherId.Equals(user.UserId)).Select(p => new { p.TeacherId, p.SubjectId }).ToList();

            dtgSujectList.DataSource = subjectList;

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

            var repoSubjectTeacher = new RepositoryBase<SubjectTeacher>();
            var subjectList = repoSubjectTeacher.GetAll().Where(p => p.TeacherId.Equals(user.UserId) && p.SubjectId.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim())).Select(p => new { p.TeacherId, p.SubjectId }).ToList();

            dtgSujectList.DataSource = subjectList;

        }
    }
}
