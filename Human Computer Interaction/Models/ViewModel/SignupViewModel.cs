using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Human_Computer_Interaction.Models.ViewModel
{
    public class SignupViewModel
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmedPassword { get; set; }
        public string UserName { get; set; }

    }
}