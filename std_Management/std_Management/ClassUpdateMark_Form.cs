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

        private void dtg_studentList_DoubleClick(object sender, EventArgs e)
        {
            MarkManagement MarkManagement = new MarkManagement();
            //UpdateRemoveSubject.txtSubjectID.Text = dtgSujectList.CurrentRow.Cells[0].Value.ToString();
            var classId = dtgClassUpdateMark.CurrentRow.Cells[0].Value.ToString();

            var roles = new RepositoryBase<Role>().GetAll().ToList();
            var studentRepo = new RepositoryBase<User>();

            var studentList = studentRepo.GetAll().Select(i => new
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
                Role = roles.Where(item => item.RoleId.Equals(i.RoleId)).FirstOrDefault().RoleName,
            }).Where(p => p.Role.Equals("Student")).OrderBy(i => i.Role).ToList();


            var classRepo = new RepositoryBase<Class>();
            var classes = classRepo.GetAll().Where(p => p.ClassStudents.Equals(classId)).ToList();
            List<User> list = new List<User>();
            var classStudentRepo = new RepositoryBase<ClassStudent>();
            classes.ForEach(item =>
            {
                classStudentRepo.GetAll().Where(p => p.ClassId.Equals(classId)).ToList().ForEach(i => list.Add(i.Student));
            });



            MarkManagement.dtgMarkManagement.DataSource = studentList;
            MarkManagement.dtgMarkManagement.DataSource = roles;
            MarkManagement.dtgMarkManagement.DataSource = list;
            MarkManagement.txtAccountId.Text = classId;
            MarkManagement.Show();
        }
    }
}
