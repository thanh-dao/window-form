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
    public partial class AddNewClass_Form : Form
    {
        public AddNewClass_Form()
        {
            InitializeComponent();
            updateForm();
        }

        public bool checkObject()
        {

            if (String.IsNullOrWhiteSpace(txtClassId.Text))
            {
                MessageBox.Show("Please input subject id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassId.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Please input subject name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassName.Focus();
                return false;
            }


            else
            {
                return true;
            }
        }

        public void clearForm()
        {
            txtClassId.Text = "";
            txtClassName.Text = "";
            nudNumOfStudent.Value = 0;
        }

        public void updateForm()
        {
            var repo = new RepositoryBase<Class>();
            dtgAddNewClass.DataSource = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent }).ToList();
            txtSearch.Text = "";
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateForm();
        }

        private void dtgAddNewClass_DoubleClick(object sender, EventArgs e)
        {
            txtClassId.Text = dtgAddNewClass.CurrentRow.Cells[0].Value.ToString();
            txtClassName.Text = dtgAddNewClass.CurrentRow.Cells[1].Value.ToString();
            nudNumOfStudent.Value = Decimal.Parse(dtgAddNewClass.CurrentRow.Cells[2].Value.ToString());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Class>();
            var data = repo.GetAll().Select(i => new { i.ClassId, i.ClassName, i.NumberOfStudent })
                .Where(p => p.ClassId.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            dtgAddNewClass.DataSource = data;
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }

            var repo = new RepositoryBase<Class>();

            string _ClassId = txtClassId.Text;
            string _ClassName = txtClassName.Text;
            int _NumOfStudent = (int)nudNumOfStudent.Value;

            var CheckId = repo.GetAll().Where(p => p.ClassId.Trim().Equals(_ClassId.Trim())).FirstOrDefault();
            if (CheckId != null)
            {
                CheckId.ClassId = _ClassId;
                CheckId.ClassName = _ClassName;
                CheckId.NumberOfStudent = _NumOfStudent;
                repo.Update(CheckId);


                MessageBox.Show("Update class Successfully.", "Notification", MessageBoxButtons.OK);
                updateForm();
                clearForm();
            }
            else
            {
                MessageBox.Show("Update class Unsuccessfully (Id not found).", "Notification", MessageBoxButtons.OK);
                updateForm();
                clearForm();
            }
        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            string _ClassId = txtClassId.Text;

            var repo = new RepositoryBase<Class>();

            var obj = repo.GetAll().Where(p => p.ClassId.Trim().Equals(_ClassId.Trim())).FirstOrDefault();

            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Delete ", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.Delete(obj);
                    updateForm();
                    clearForm();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }
            var repo = new RepositoryBase<Class>();


            string _ClassId = txtClassId.Text;
            string _ClassName = txtClassName.Text;
            int _NumOfStudent = (int)nudNumOfStudent.Value;


            var CheckId = repo.GetAll().Where(p => p.ClassId.Trim().Equals(_ClassId.Trim())).FirstOrDefault();
            if (CheckId != null)
            {
                Console.WriteLine(repo.Get(txtClassId.Text));
                MessageBox.Show("Id " + txtClassId.Text + " already exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassId.Focus();
                return;
            }

            Class addClass = new Class()
            {
                ClassId = _ClassId,
                ClassName = _ClassName,
                NumberOfStudent = _NumOfStudent,

            };

            repo.Create(addClass);
            updateForm();
            clearForm();
            MessageBox.Show("Add new subject successfully.", "Notification", MessageBoxButtons.OK);
        }
    }
}
