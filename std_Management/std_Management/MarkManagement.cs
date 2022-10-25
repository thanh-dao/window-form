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
    public partial class MarkManagement : Form
    {
        public String classId;
        public MarkManagement(String classId)
        {
            this.classId = classId;

            InitializeComponent();
            var subjectTeacherIds = new RepositoryBase<ClassSubject>().GetAll().Where(i => i.ClassId.Equals(classId))
                .Select(i => i.SubjectTeacherId.ToString()).ToList();
            List<String> subjectIds = new List<string>();
            new RepositoryBase<SubjectTeacher>().GetAll().ForEach(subjectTeacher =>
            {
                subjectTeacherIds.ForEach(id =>
                {
                    Console.WriteLine(id + " " + subjectTeacher.SubjectTeacherId);
                    Console.WriteLine(id.Equals(subjectTeacher.SubjectTeacherId.ToString()));
                    if (id.Equals(subjectTeacher.SubjectTeacherId.ToString()))
                    {
                        subjectIds.Add(subjectTeacher.SubjectId);
                    }
                });
            });
            cbSubject.DataSource = subjectIds;
        }

        public void clear ()
        {
            txtAccountId.Text = "";
            txtAccountName.Text = "";
            txtSearch.Text = "";
            nudMark.Value = 0;
            cbSubject.DataSource = null;
        }

        private void dtgMarkManagement_DoubleClick(object sender, EventArgs e)
        {
            txtAccountId.Text = dtgMarkManagement.CurrentRow.Cells[0].Value.ToString();
            txtAccountId.Enabled = false;
            txtAccountName.Text = dtgMarkManagement.CurrentRow.Cells[1].Value.ToString() + " " + dtgMarkManagement.CurrentRow.Cells[1].Value.ToString();
            txtAccountName.Enabled = false;

            var subjectTeacherIds = new RepositoryBase<ClassSubject>().GetAll().Where(i => i.ClassId.Equals(classId))
               .Select(i => i.SubjectTeacherId.ToString()).ToList();

            List<String> subjectIds = new List<string>();
            new RepositoryBase<SubjectTeacher>().GetAll().ForEach(subjectTeacher =>
            {
                subjectTeacherIds.ForEach(id =>
                {
                    if (id.Equals(subjectTeacher.SubjectTeacherId.ToString()))
                    {
                        subjectIds.Add(subjectTeacher.SubjectId);
                    }
                });
            });


            cbSubject.DataSource = subjectIds;
            String Subject = cbSubject.Text;
            Console.WriteLine(Subject);
            var repoMark = new RepositoryBase<Mark>();

            var SubjectTeacher = new RepositoryBase<SubjectTeacher>().GetAll()
                .FirstOrDefault(i => i.SubjectId.Equals(Subject));
            var StudentMark = repoMark.GetAll().FirstOrDefault(p => p.StudentId.Equals(txtAccountId.Text) 
            && p.SubjectTeacherId.Equals(SubjectTeacher.SubjectTeacherId));


            nudMark.Value = (decimal)StudentMark.Score;
            Console.WriteLine(StudentMark.Score);
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Mark>();

            string _Subject = cbSubject.Text;
            float _Mark = (float)nudMark.Value;

            var SubjectTeacher = new RepositoryBase<SubjectTeacher>().GetAll()
                .FirstOrDefault(i => i.SubjectId.Equals(_Subject));

            var CheckId = repo.GetAll().Where(p => p.StudentId.Trim().Equals(txtAccountId.Text.Trim()) && p.SubjectTeacherId.Equals(SubjectTeacher.SubjectTeacherId)).FirstOrDefault();
            if (CheckId != null)
            {
                CheckId.Score = _Mark;

                repo.Update(CheckId);


                MessageBox.Show("Update Subject Successfully.", "Notification", MessageBoxButtons.OK);
                refresh();
                clear();
            }
            else
            {
                MessageBox.Show("Update Subject Unsuccessfully (Id not found).", "Notification", MessageBoxButtons.OK);
                refresh();
                clear();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            clear();

        }
        public void refresh ()
        {
            var studentRepo = new RepositoryBase<User>();
            var classRepo = new RepositoryBase<Class>();
            var classStudentRepo = new RepositoryBase<ClassStudent>();
            var classStudents = classStudentRepo.GetAll().Where(i => i.ClassId.Equals(classId)).ToList();
            var classSubject = new RepositoryBase<ClassSubject>().GetAll().Where(i => i.ClassId.Equals(classId))
                .Select(item => item.SubjectTeacherId).FirstOrDefault();

            var students = new List<User>();
            var markRepo = new RepositoryBase<Mark>();

            classStudents.ForEach(i =>
            {
                Console.WriteLine(i.StudentId);
                User student = studentRepo.GetAll().FirstOrDefault(student => student.UserId == i.StudentId);
                students.Add(student);
            });
            List<object> stuList = new List<object>();
            var studentList = students.Select(i => new
            {
                i.UserId,
                i.FirstName,
                i.LastName,
                i.BirthDate,
                Gender = !i.Gender.Value ? "Male" : "Female",
                i.Phone,
                i.Email,
                i.Address,
                i.Picture,
                Status = i.Status.Value ? "Active" : "Suspend",
            });
            dtgMarkManagement.DataSource = students;
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var studentRepo = new RepositoryBase<User>();
            var classRepo = new RepositoryBase<Class>();
            var classStudentRepo = new RepositoryBase<ClassStudent>();
            var classStudents = classStudentRepo.GetAll().Where(i => i.ClassId.Equals(classId)).ToList();
            var classSubject = new RepositoryBase<ClassSubject>().GetAll().Where(i => i.ClassId.Equals(classId))
                .Select(item => item.SubjectTeacherId).FirstOrDefault();

            var students = new List<User>();
            var markRepo = new RepositoryBase<Mark>();

            classStudents.ForEach(i =>
            {
                Console.WriteLine(i.StudentId);
                User student = studentRepo.GetAll().FirstOrDefault(student => student.UserId == i.StudentId);
                students.Add(student);
            });      
            List<object> stuList = new List<object>();
            var studentList = students.Select(i => new
            {
                i.UserId,
                i.FirstName,
                i.LastName,
                i.BirthDate,
                Gender = !i.Gender.Value ? "Male" : "Female",
                i.Phone,
                i.Email,
                i.Address,
                i.Picture,
                Status = i.Status.Value ? "Active" : "Suspend",
            });
            var studentSearch = students.Where(p=>p.UserId.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim())).ToList();
            dtgMarkManagement.DataSource = studentSearch;
            
        }
    }
}
