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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace std_Management
{
    public partial class AddSubject_Form : Form
    {
        public AddSubject_Form()
        {
            InitializeComponent();
        }

        public bool checkObject()
        {

            if (String.IsNullOrWhiteSpace(txtSubjectID.Text) || txtSubjectID.Text.Length != 6)
            {
                MessageBox.Show("Please input subject id (Max length 6)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectID.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtSubjectName.Text) || txtSubjectName.Text.Length > 100)
            {
                MessageBox.Show("Please input subject name (Max length 100)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectName.Focus();
                return false;
            }

            if (nudNumOfCredits.Value > 0 || nudNumOfCredits.Value < 100)
            {
                MessageBox.Show("Number of credits must be between 1-99.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNumOfCredits.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }
        private void ResetForm()
        {
            txtSubjectID.Text = "";
            txtSubjectName.Text = "";
            nudNumOfCredits.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
            }
        }


        private void btnAddNewSubject_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }
            var repo = new RepositoryBase<Subject>();

            string _SubjectId = txtSubjectID.Text;
            string _SujectName = txtSubjectName.Text;
            int _NumOfCredits = (int)nudNumOfCredits.Value;


            var CheckId = repo.GetAll().Where(p => p.SubjectId.Trim().Equals(_SubjectId.Trim())).FirstOrDefault();
            if (CheckId != null)
            {
                Console.WriteLine(repo.Get(txtSubjectID.Text));
                MessageBox.Show("Id " + txtSubjectID.Text + " already exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectID.Focus();
                return;
            }

            Subject subject = new Subject()
            {
                SubjectId = _SubjectId,
                SubjectName = _SujectName,
                NumberOfCredits = _NumOfCredits,

            };

            repo.Create(subject);
            ResetForm();
            MessageBox.Show("Add new subject successfully.", "Notification", MessageBoxButtons.OK);
        }
    }
}
