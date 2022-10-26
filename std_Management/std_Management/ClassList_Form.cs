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
    public partial class ClassList_Form : Form
    {
        public ClassList_Form()
        {
            InitializeComponent();
            var repo = new RepositoryBase<Class>();
            dtgClassList.DataSource = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent }).ToList();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Class>();
            dtgClassList.DataSource = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent }).ToList();
            txt_classId.Text = "";
        }

        private void dtgClassList_DoubleClick(object sender, EventArgs e)
        {
            /* UpdateRemoveSubject_Form UpdateRemoveSubject = new UpdateRemoveSubject_Form();
             UpdateRemoveSubject.txtSubjectID.Text = dtgClassList.CurrentRow.Cells[0].Value.ToString();
             UpdateRemoveSubject.txtSubjectName.Text = dtgClassList.CurrentRow.Cells[1].Value.ToString();
             UpdateRemoveSubject.nudNumOfCredits.Value = Decimal.Parse(dtgClassList.CurrentRow.Cells[2].Value.ToString());

             UpdateRemoveSubject.Show();*/
            var classId = dtgClassList.CurrentRow.Cells[0].Value.ToString();
            var className = dtgClassList.CurrentRow.Cells[1].Value.ToString();
            var classStudentNumber = dtgClassList.CurrentRow.Cells[2].Value.ToString();

            DefineClass_Form defineClass_Form = new DefineClass_Form(classId, className, classStudentNumber);
            defineClass_Form.ShowDialog();


        }

        private void txt_classId_TextChanged(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Class>();
            var data = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent })
                .Where(p => p.ClassId.ToLower().Contains(txt_classId.Text.ToLower())).ToList();
            dtgClassList.DataSource = data;
        }
    }
}
