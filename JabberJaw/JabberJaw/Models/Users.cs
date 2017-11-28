using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JabberJaw.Models
{
    public class Users
    {
        public string id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUTC { get; set; }
        public bool LockoutEnabled  { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public int Value { get; set; }
       
    }
}