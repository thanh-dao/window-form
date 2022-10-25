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
    public partial class MarkManagement : Form
    {
        public MarkManagement(String classId)
        {
            InitializeComponent();
            var subjectTeacherIds = new RepositoryBase<ClassSubject>().GetAll().Where(i => i.ClassId.Equals(classId)).Select(i => i.SubjectTeacherId.ToString()).ToList();
            List<String> subjectIds = new List<string>();
            new RepositoryBase<SubjectTeacher>().GetAll().ForEach(subjectTeacher =>
            {
                subjectTeacherIds.ForEach(id =>
                {
                    Console.WriteLine(id + " " + subjectTeacher.SubjectTeacherId);
                    Console.WriteLine(id.Equals(subjectTeacher.SubjectTeacherId.ToString()));
                    if (id.Equals(subjectTeacher.SubjectTeacherId.ToString()))
                    {
                        subjectIds.Add(subjectTeacher.SubjectId);
                    }
                });
            });
            cbSubject.DataSource = subjectIds;
        }
    }
}
