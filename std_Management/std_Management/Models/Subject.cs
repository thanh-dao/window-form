using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class Subject
    {
        public Subject()
        {
            MajorSubjects = new HashSet<MajorSubject>();
            SubjectTeachers = new HashSet<SubjectTeacher>();
        }

        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }

        public virtual ICollection<MajorSubject> MajorSubjects { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
