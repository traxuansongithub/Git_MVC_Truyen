using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fist_Hello.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Mởi Nhập User Name ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mởi Nhập PassWord ")]
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }

    }
}