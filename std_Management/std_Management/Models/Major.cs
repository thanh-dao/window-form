using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{
    public partial class Major
    {
        public Major()
        {
            MajorSubjects = new HashSet<MajorSubject>();
            Users = new HashSet<User>();
        }

        public string MajorId { get; set; }
        public string MajorName { get; set; }

        public virtual ICollection<MajorSubject> MajorSubjects { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
