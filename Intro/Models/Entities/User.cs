using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intro.Models.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool isEmailConfirmed { get; set; }
    }
}