using std_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace std_Management
{
    public partial class UpdateRemoveSubject_Form : Form
    {
        public UpdateRemoveSubject_Form()
        {
            InitializeComponent();
        }
        public bool checkObject()
        {

            if (String.IsNullOrWhiteSpace(txtSubjectID.Text))
            {
                MessageBox.Show("Please input subject id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectID.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please input subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectName.Focus();
                return false;
            }


            else
            {
                return true;
            }
        }
        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }

            var repo = new RepositoryBase<Subject>();

            string _SubjectId = txtSubjectID.Text;
            string _SujectName = txtSubjectName.Text;
            int _NumOfCredits = (int) nudNumOfCredits.Value;

           var CheckId = repo.GetAll().Where(p=>p.SubjectId.Trim().Equals(_SubjectId.Trim())).FirstOrDefault();
            if (CheckId != null)
            {
                CheckId.SubjectId = _SubjectId;
                CheckId.SubjectName = _SujectName;
                CheckId.NumberOfCredits = _NumOfCredits;
                repo.Update(CheckId);


                MessageBox.Show("Update Subject Successfully.", "Notification", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Update Subject Unsuccessfully (Id not found).", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btn_deleteSubject_Click(object sender, EventArgs e)
        {
            string _SubjectId = txtSubjectID.Text;

            var repo = new RepositoryBase<Subject>();

            var obj = repo.GetAll().Where(p => p.SubjectId.Trim().Equals(_SubjectId.Trim())).FirstOrDefault();

            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Delete ", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.Delete(obj);
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }

            this.Close();
        }
    }
}
