using Microsoft.VisualBasic.ApplicationServices;
using std_Management;
using std_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = std_Management.Models.User;

namespace Student_Management
{
    public partial class UpdateRemoveStudent_Form : Form
    {

        public UpdateRemoveStudent_Form()
        {
            InitializeComponent();
        }

        public bool checkObject()
        {
            var repo = new RepositoryBase<User>();


            if (String.IsNullOrWhiteSpace(txt_userid.Text) || txt_userid.Text.Length != 8)
            {
                MessageBox.Show("Please input your user Id (Max length 8)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userid.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txt_firstname.Text) || txt_firstname.Text.Length > 50)
            {
                MessageBox.Show("Please input your frist name (Max length 50)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_firstname.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_lastname.Text) || txt_lastname.Text.Length > 50)
            {
                MessageBox.Show("Please input your last name (Max length 50)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_lastname.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(dtp_birthdate.Text))
            {
                MessageBox.Show("Please input your brith date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_birthdate.Focus();
                return false;
            }
            int bornYear = dtp_birthdate.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - bornYear) < 17 || (this_year - bornYear) > 100)
            {
                MessageBox.Show("Age should be between 17 and 100 year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (String.IsNullOrWhiteSpace(rdo_female.Text) || String.IsNullOrWhiteSpace(rdo_male.Text))
            {
                MessageBox.Show("Please choise your gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox1.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_phone.Text) || txt_phone.Text.Length != 10)
            {
                MessageBox.Show("Please input your phone number (Length 10)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phone.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please input your email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (!txt_email.Text.Contains("@"))
            {
                MessageBox.Show(txt_email.Text + " is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please input your address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            //upload ảnh từ máy tính
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }


        private void btn_findId_Click(object sender, EventArgs e)
        {         
            StudentList_Form stdListF = new StudentList_Form();
            this.Close();
            stdListF.Show();
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }

            var repo = new RepositoryBase<User>();
            String _UserId = txt_userid.Text;
            txt_userid.Enabled = false;
            string _FirstName = txt_firstname.Text;
            string _LastName = txt_lastname.Text;
            DateTime _BirthDate = dtp_birthdate.Value;
            bool _Gender;
            if (rdo_female.Checked)
            {
                _Gender = true;
            }
            else
            {
                _Gender = false;
            }
            string _Phone = txt_phone.Text;
            string _Email = txt_email.Text;
            string _Address = txt_address.Text;
            String _Picture = pictureBoxStudentImage.Text;

            var CheckId = repo.GetAll().Where(p => p.UserId.Trim().Equals(_UserId.Trim())).FirstOrDefault();
            if (CheckId != null)
            {
                CheckId.FirstName = _FirstName;
                CheckId.LastName = _LastName;
                CheckId.BirthDate = _BirthDate;
                CheckId.Gender = _Gender;
                CheckId.Phone = _Phone;
                CheckId.Email = _Email;
                CheckId.Address = _Address;
                //CheckId.Picture = _Picture;


                repo.Update(CheckId);

                
                MessageBox.Show("Update user successfully.", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Update user Unsuccessfully.", "Notification", MessageBoxButtons.OK);
            }
           

        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            btn_deleteUser.Enabled = false;
            var _UserId = txt_userid.Text;
            var repo = new RepositoryBase<User>();
            var obj = repo.GetAll().Where(p => p.UserId.Trim().Equals(_UserId.Trim())).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Delete ", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.Delete(obj);
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
