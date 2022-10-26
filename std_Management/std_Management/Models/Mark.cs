using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class Mark
    {
        public int MarkId { get; set; }
        public string StudentId { get; set; }
        public int SubjectTeacherId { get; set; }
        public double? Score { get; set; }
        public bool Status { get; set; }

        public virtual User Student { get; set; }
        public virtual SubjectTeacher SubjectTeacher { get; set; }
    }
}
