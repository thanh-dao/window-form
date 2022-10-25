﻿using std_Management.Models;
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
    public partial class StudentProfile_Form : Form
    {
        public StudentProfile_Form()
        {
            InitializeComponent();
        }

        public bool checkObject()
        {

            if (String.IsNullOrWhiteSpace(txt_userid.Text))
            {
                MessageBox.Show("Please input your user student Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                return true;
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!checkObject())
            {
                return;
            }

            var repo = new RepositoryBase<User>();

            string _UserId = txt_userid.Text;
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
                CheckId.UserId = _UserId;
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
        }
    }
}
