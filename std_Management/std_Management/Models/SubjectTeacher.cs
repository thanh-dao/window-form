using System;
using System.Collections.Generic;
using System.Text.Json;

#nullable disable

namespace std_Management.Models
{
    public partial class SubjectTeacher
    {
        public SubjectTeacher()
        {
            ClassSubjects = new HashSet<ClassSubject>();
            Marks = new HashSet<Mark>();
        }

        public int SubjectTeacherId { get; set; }
        public string TeacherId { get; set; }
        public string SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual User Teacher { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
