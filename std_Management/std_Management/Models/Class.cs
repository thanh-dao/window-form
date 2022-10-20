using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
            ClassSubjects = new HashSet<ClassSubject>();
        }

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public int NumberOfStudent { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
