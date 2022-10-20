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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudent_Form addStdF = new AddNewStudent_Form();
            addStdF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList_Form stdListF = new StudentList_Form();
            stdListF.Show(this);
        }

        private void updateStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRemoveStudent_Form updateRemoveStdF = new UpdateRemoveStudent_Form();
            updateRemoveStdF.Show(this);
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Static_Form staticF = new Static_Form();
            staticF.Show(this);
        }

        private void lECTUREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTeacherForm changeTeacherF = new ChangeTeacherForm();
            changeTeacherF.Show(this);
        }

        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeleteStdInClassForm addDeleteStdInClassF = new AddDeleteStdInClassForm();
            addDeleteStdInClassF.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
