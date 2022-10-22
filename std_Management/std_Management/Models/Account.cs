using System;
using System.Collections.Generic;

#nullable disable

namespace std_Management.Models
{

    public partial class Account
    {
        public string AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
