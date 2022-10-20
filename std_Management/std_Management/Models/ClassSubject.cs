using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class ClassSubject
    {
        public int ClassSubjectId { get; set; }
        public string ClassId { get; set; }
        public int? SubjectTeacherId { get; set; }

        public virtual Class Class { get; set; }
        public virtual SubjectTeacher SubjectTeacher { get; set; }
    }
}
