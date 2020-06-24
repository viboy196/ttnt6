using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLNS.Models
{
    public class LoginModel
    {
        [Required]
        public string Nameaccount { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}