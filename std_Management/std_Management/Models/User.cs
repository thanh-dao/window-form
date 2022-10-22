using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace std_Management.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
            ClassStudents = new HashSet<ClassStudent>();
            Marks = new HashSet<Mark>();
            SubjectTeachers = new HashSet<SubjectTeacher>();
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool? Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
        public bool? Status { get; set; }
        public string RoleId { get; set; }
        public string MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection <Account> Accounts { get; set; }
        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
