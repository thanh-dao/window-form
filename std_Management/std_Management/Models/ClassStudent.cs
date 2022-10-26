using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class ClassStudent
    {
        public int ClassStudentId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User Student { get; set; }
    }
}
