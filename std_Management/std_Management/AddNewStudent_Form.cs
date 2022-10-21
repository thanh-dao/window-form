using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using std_Management;
using std_Management.Models;

namespace Student_Management
{
    public partial class AddNewStudent_Form : Form
    {
        public AddNewStudent_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        public bool checkObject()
        {
            var repo = new RepositoryBase<User>();


            if (String.IsNullOrWhiteSpace(txt_userid.Text))
            {
                MessageBox.Show("Please input your user student Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userid.Focus();
                return false;
            }

            if((repo.Get(txt_userid.Text)) != null)
            {
                Console.WriteLine(repo.Get(txt_userid.Text));
                MessageBox.Show("Id already exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userid.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txt_firstname.Text))
            {
                MessageBox.Show("Please input your frist name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_firstname.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_lastname.Text))
            {
                MessageBox.Show("Please input your last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_lastname.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(dtp_birthdate.Text))
            {
                MessageBox.Show("Please input your brith date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_birthdate.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(rdo_female.Text) || String.IsNullOrWhiteSpace(rdo_male.Text))
            {
                MessageBox.Show("Please choise your gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox1.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Please input your phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phone.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please input your email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please input your address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return false;
            }
            
            return true;
        }

        Boolean addStudent()
        {

            if (checkObject())
            {
                string UserId  = txt_userid.Text;
                string FirstName = txt_firstname.Text;
                string LastName = txt_lastname.Text;
                DateTime BirthDate = dtp_birthdate.Value;
                bool Gender;
                if (rdo_female.Text.Equals("Female"))
                {
                     Gender = true;
                }
                else
                {
                     Gender = false;
                }
                string Phone = txt_phone.Text;
                string Email = txt_email.Text;
                string Address = txt_address.Text;
                String Picture = pictureBoxStudentImage.Text;



        User user = new User () 
        {UserId = UserId, FirstName = FirstName, LastName = LastName, BirthDate = BirthDate, 
            Gender = Gender, Phone = Phone, Email= Email, Address = Address, Picture = Picture, RoleId = "ST"};
                var repo = new RepositoryBase<User>();
                repo.Create(user);
                return true;
            }
                
            return false;
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            if (addStudent())
            {
                MessageBox.Show("Add successfully", "notification", MessageBoxButtons.OK);
            }
        }

        private void btn_cancelAddStudent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
