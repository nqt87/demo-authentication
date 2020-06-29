using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models.Users
{
    public class RegisterModel
    {
        //[Required]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        //[Required]
        public string Username { get; set; }

        //[Required]
        public string Password { get; set; }

    }
}
