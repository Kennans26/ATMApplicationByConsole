using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterATMUsers.Users
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public long AccountNumber { get; set; }
        public long CardNumber { get; set; }
        public int CardPin { get; set; }
        public decimal AccountBalance { get; set; }

        //we need not a user's total login, cause there are in main ATM App we can set it.
        //public int TotalLogin { get; set; }

        public bool IsLocked { get; set; }
    }
}
