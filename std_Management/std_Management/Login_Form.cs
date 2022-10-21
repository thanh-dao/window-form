using Microsoft.EntityFrameworkCore.Query.Internal;
using std_Management;
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

namespace Student_Management
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public bool checkObject()
        {
            if (String.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Please input your user name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please input your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return false;
            }
            return true;
        }
        void login()
        {
            if (checkObject())
            {
                var _username = txt_username.Text;
                var _password = txt_password.Text;

                var repo = new RepositoryBase<Account>();
                var _check = repo.GetAll().Where
                (p => p.Username.Equals(_username) 
                && p.Password.Equals(_password)).FirstOrDefault();
                if (_check != null) //ton tai user
                {
                    MainForm NewForm = new MainForm();
                    NewForm.Hide();
                    NewForm.Show();
                }
                else
                {
                    MessageBox.Show("User does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        void exit()
        {
            if (MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
