using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class MajorSubject
    {
        public int MajorSubjectId { get; set; }
        public string SubjectId { get; set; }
        public string MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
