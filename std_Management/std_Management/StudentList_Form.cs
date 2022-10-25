using std_Management;
using std_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Student_Management
{
    public partial class StudentList_Form : Form
    {
        String _prevColName = "";
        bool _isAsc = true;
        public StudentList_Form()
        {
            InitializeComponent();
            var repo = new RepositoryBase<User>();
            var roles = new RepositoryBase<Role>().GetAll().ToList();
            var studentList = repo.GetAll().Select(i => new
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
            }).OrderBy(i => i.Role).ToList();
            dtg_studentList.DataSource = studentList;
        }

        private void dtg_studentList_DoubleClick(object sender, EventArgs e)
        {
            //Display the selected student in the new form to edit/remove
            UpdateRemoveStudent_Form updateRemoveStdF = new UpdateRemoveStudent_Form();
            updateRemoveStdF.txt_userid.Text = dtg_studentList.CurrentRow.Cells[0].Value.ToString();
            updateRemoveStdF.txt_firstname.Text = dtg_studentList.CurrentRow.Cells[1].Value.ToString();
            updateRemoveStdF.txt_lastname.Text = dtg_studentList.CurrentRow.Cells[2].Value.ToString();
            updateRemoveStdF.dtp_birthdate.Value = (DateTime)dtg_studentList.CurrentRow.Cells[3].Value;

            if (dtg_studentList.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                updateRemoveStdF.rdo_male.Checked = true;
            }
            if (dtg_studentList.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateRemoveStdF.rdo_female.Checked = true;
            }
            updateRemoveStdF.txt_phone.Text = dtg_studentList.CurrentRow.Cells[5].Value.ToString();
            updateRemoveStdF.txt_email.Text = dtg_studentList.CurrentRow.Cells[6].Value.ToString();
            updateRemoveStdF.txt_address.Text = dtg_studentList.CurrentRow.Cells[7].Value.ToString();
            updateRemoveStdF.txt_userid.Enabled = false;
           /*updateRemoveStdF.pictureBoxStudentImage.ImageLocation = dtg_studentList.CurrentRow.Cells[8].Value.ToString();*/
           

            var repo = new RepositoryBase<User>();
            var account = repo.GetAll().Where(p => p.RoleId.Equals("AD") && p.UserId.Equals(dtg_studentList.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();

            if (account != null)
            {
                updateRemoveStdF.btn_deleteUser.Enabled = false;
            }


            this.Close();
            updateRemoveStdF.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<User>();
            var roles = new RepositoryBase<Role>().GetAll().ToList();
            var studentList = repo.GetAll().Select(i => new
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
            }).OrderBy(i => i.Role).ToList();    //.Select(p=>p.).ToList();
            dtg_studentList.DataSource = studentList;
            txt_userId.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var repo = new RepositoryBase<User>();
            var roles = new RepositoryBase<Role>().GetAll().ToList();
            var studentList = repo.GetAll().Select(i => new
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
            }).OrderBy(i => i.Role).ToList().Where(p => p.UserId.ToLower().Contains(txt_userId.Text.ToLower())).ToList();
            dtg_studentList.DataSource = studentList;
        }

        private void dtg_studentList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var colName = dtg_studentList.Columns[e.ColumnIndex].Name;
            MessageBox.Show("User does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (_prevColName.Equals(colName))
            {
                _isAsc = !_isAsc;
            }else
            {
                _isAsc = true;
                _prevColName = colName;
            }
            var repo = new RepositoryBase<User>();
            List<Role> _roles = new RepositoryBase<Role>().GetAll().ToList();
            var studentList = repo.GetAll().Select(i => new
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
                Role = _roles.Where(item => item.RoleId.Equals(i.RoleId)).FirstOrDefault().RoleName,
            });
            var sortedStudentList = studentList.ToList();

            switch (colName)
            {
                case "UserId":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.UserId).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.UserId).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "FirstName":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.FirstName).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.FirstName).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "LastName":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.LastName).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.LastName).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "BirthDate":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.BirthDate).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.BirthDate).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Gender":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Gender).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Gender).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Phone":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Phone).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Phone).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Email":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Email).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Email).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Address":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Address).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Address).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Status":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Status).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Status).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Role":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Role).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Role).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
            }
            Console.WriteLine(sortedStudentList);
            dtg_studentList.DataSource = sortedStudentList;
        }

        private List<dynamic> getSortedList(String colName, List<dynamic> studentList)
        {
            List<dynamic> sortedStudentList = null;
            switch (colName)
            {
                case "UserId":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.UserId).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.UserId).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "FirstName":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.FirstName).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.FirstName).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "LastName":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.LastName).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.LastName).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "BirthDate":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.BirthDate).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.BirthDate).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Gender":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Gender).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Gender).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Phone":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Phone).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Phone).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Email":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Email).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Email).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Address":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Address).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Address).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Status":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Status).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Status).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
                case "Role":
                    {
                        if (_isAsc)
                        {
                            sortedStudentList = studentList.OrderBy(i => i.Role).ToList();
                        }
                        else
                        {
                            sortedStudentList = studentList.OrderByDescending(i => i.Role).ToList();
                            //sortedStudentList = studentList.OrderByDescending(i => i.GetType().GetProperty(name)).ToList();
                        }
                        break;
                    }
            }
            return sortedStudentList;
        }
    }
}
