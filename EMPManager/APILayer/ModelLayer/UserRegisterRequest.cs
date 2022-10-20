using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class UserRegisterRequest
    {
        [Required]
        public string UserName { get; set; }= string.Empty;

        [Required, MinLength(8)]
        public string Password { get; set; }=string.Empty;

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty; 
    }
}
