using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTestSQL.ViewModels
{
    public class LoginViewModel
    {
        [HiddenInput]
        public string UrlRetorno { get; set; }
        [Required(ErrorMessage = "Informe o login")]
        public string login { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Aumenta isso ae parcero")]
        public string senha { get; set; }

    }
}