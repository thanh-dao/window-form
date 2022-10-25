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
    public partial class ClassUpdateMark_Form : Form
    {
        public ClassUpdateMark_Form()
        {
            InitializeComponent();
            var repo = new RepositoryBase<Class>();
            dtgClassUpdateMark.DataSource = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent }).ToList();
        }

        private void txt_userId_TextChanged(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Class>();
            var data = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent })
                .Where(p => p.ClassId.ToLower().Contains(txtClassId.Text.ToLower())).ToList();
            dtgClassUpdateMark.DataSource = data;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Class>();
            dtgClassUpdateMark.DataSource = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent }).ToList();
            txtClassId.Text = "";
        }

        private void dtgClassUpdateMark_DoubleClick(object sender, EventArgs e)
        {
            //UpdateRemoveSubject.txtSubjectID.Text = dtgSujectList.CurrentRow.Cells[0].Value.ToString();
            var classId = dtgClassUpdateMark.CurrentRow.Cells[0].Value.ToString();
            MarkManagement MarkManagement = new MarkManagement(classId);
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
            MarkManagement.dtgMarkManagement.DataSource = students;
            MarkManagement.ShowDialog();
        }
    }
}
