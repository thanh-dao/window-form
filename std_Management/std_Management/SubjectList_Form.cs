using std_Management.Models;
using Student_Management;
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
    public partial class subjectList_Form : Form
    {
        public subjectList_Form()
        {
            InitializeComponent();
            var repo = new RepositoryBase<Subject>();
            dtgSujectList.DataSource = repo.GetAll().Select(i=> new{i.SubjectId , i.SubjectName, i.NumberOfCredits}).ToList();
        }

        private void txt_subjectId_TextChanged(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Subject>();
            var data = repo.GetAll().Select(i => new
            {
                i.SubjectId,
                i.SubjectName,
                i.NumberOfCredits
            }).Where(p => p.SubjectId.ToLower().Contains(txt_subjectId.Text.ToLower())).ToList();
            dtgSujectList.DataSource = data;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Subject>();
            dtgSujectList.DataSource = repo.GetAll().Select(i => new { i.SubjectId, i.SubjectName, i.NumberOfCredits }).ToList();
            txt_subjectId.Text = "";
        }

        private void dtgSujectList_DoubleClick(object sender, EventArgs e)
        {
            UpdateRemoveSubject_Form UpdateRemoveSubject = new UpdateRemoveSubject_Form();
            UpdateRemoveSubject.txtSubjectID.Text = dtgSujectList.CurrentRow.Cells[0].Value.ToString();
            UpdateRemoveSubject.txtSubjectName.Text = dtgSujectList.CurrentRow.Cells[1].Value.ToString();
            UpdateRemoveSubject.nudNumOfCredits.Value = Decimal.Parse(dtgSujectList.CurrentRow.Cells[2].Value.ToString());

            UpdateRemoveSubject.Show();
        }
    }
}
