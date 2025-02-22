using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusiCodeWebApp.Areas.ManagerPanel.Data
{
    public class ManagerLoginViewModel
    {
        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 200, MinimumLength = 5, ErrorMessage = "Bu alan en az 5, en fazla 200 karakter olabilir.")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 30, MinimumLength = 5, ErrorMessage = "Bu alan en az 5, en fazla 30 karakter olabilir.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}