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
    public partial class DefineClass_Form : Form
    {
        String _classId;
        String _className;
        String _classStudentNumber;
        public DefineClass_Form()
        {
            InitializeComponent();
        }

        public DefineClass_Form(String classId, String className, String classStudentNumber)
        {
            _classId = classId;
            _className = className;
            _classStudentNumber = classStudentNumber;
            InitializeComponent();
            txtClassId.Text = classId;
            txtClassName.Text = className;
            txtClassNumOfStudent.Text = classStudentNumber;

            RepositoryBase<ClassStudent> ClassStudentRepo = new RepositoryBase<ClassStudent>();
            
            RepositoryBase<User> StudentRepo = new RepositoryBase<User>();
            
            
            var StudentIds = ClassStudentRepo.GetAll().Where(i => i.ClassId.Equals(_classId)).Select(classStudent => classStudent.StudentId).ToList();
            RepositoryBase<Mark> markRepo = new RepositoryBase<Mark>();
            var markObjects = markRepo.GetAll().Where(mark => StudentIds.Contains(mark.StudentId)).Select(mark => new
            {
                mark.StudentId,
                mark.Score
            }).ToList();
            var studentList = StudentRepo.GetAll().Where(student => StudentIds.Contains(student.UserId)).Select(i => new
            {
                i.UserId,
                i.FirstName,
                i.LastName,
                i.BirthDate,
                Gender = !i.Gender.Value ? "Male" : "Female",
                i.Phone,
                i.Email,
                i.Address,
                Status = i.Status.Value ? "Active" : "Suspend",
                mark = markObjects.Where(mark => mark.StudentId.Equals(i.UserId)).FirstOrDefault().Score == null ? 0 : markObjects.Where(mark => mark.StudentId.Equals(i.UserId)).FirstOrDefault().Score,
            }).ToList();

            dataGridView1.DataSource = studentList;



            RepositoryBase<ClassSubject> ClassSubjectRepo = new RepositoryBase<ClassSubject>();
            var SubjectTeacherIds = ClassSubjectRepo.GetAll().Where(i => i.ClassId.Equals(_classId)).Select(classSubject => classSubject.SubjectTeacherId).ToList();

            RepositoryBase<SubjectTeacher> SubjectTeacherRepo = new RepositoryBase<SubjectTeacher>();
            var SubjectTeachers = SubjectTeacherRepo.GetAll().Where(i => SubjectTeacherIds.Contains(i.SubjectTeacherId));
            List<string> subjects = SubjectTeachers.Select(i => i.SubjectId).ToList();
            
            var teacherIds = SubjectTeachers.Select(i => i.TeacherId).ToList();

            RepositoryBase<User> userRepo = new();
            var teachers = userRepo.GetAll().Where(i => teacherIds.Contains(i.UserId)).Select(teacher => new
            {
                id = teacher.UserId,
                name = teacher.FirstName + " " + teacher.LastName,
            }).ToList();
            if (subjects != null)
            {
                var major = new RepositoryBase<MajorSubject>().GetAll().Where(i => i.SubjectId.Equals(subjects.FirstOrDefault())).FirstOrDefault();
                Console.WriteLine("major   " + major.MajorId);
                var studentAddLists = userRepo.GetAll().Where(i => i.UserId.ToUpper().Contains(major.MajorId.Trim())).Select(i => i.UserId).ToList();
                userRepo.GetAll().ForEach(i =>
                {
                    Console.WriteLine(i.UserId.ToUpper() + " "  + major.MajorId.Trim());
                    Console.WriteLine();
                    Console.WriteLine(i.UserId.ToUpper().Contains(major.MajorId.Trim()));
                });
                cbStudentID.DataSource = studentAddLists;
            }


            

            cbSubject.DataSource = subjects;

            cbTeacher.DataSource = teachers;
            cbTeacher.DisplayMember = "name";
            cbTeacher.ValueMember = "id";

            //cbStudentID.DataSource = studentAddList;
            //Console.WriteLine(studentAddList);

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {

        }

        private void lbClassID_Click(object sender, EventArgs e)
        {

        }
    }
}
