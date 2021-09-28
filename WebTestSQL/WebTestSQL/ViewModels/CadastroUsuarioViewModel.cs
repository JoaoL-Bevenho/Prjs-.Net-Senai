using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebTestSQL.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [MaxLength(255, ErrorMessage = "Diminui isso ae parcero")]
        [MinLength(8, ErrorMessage = "Aumenta isso ae parcero")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(255, ErrorMessage = "Diminui isso ae parcero")]
        [MinLength(8, ErrorMessage = "Aumenta isso ae parcero")]
        public string login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MaxLength(255, ErrorMessage = "Diminui isso ae parcero")]
        [MinLength(8, ErrorMessage = "Aumenta isso ae parcero")]
        public string senha { get; set; }

        [Required(ErrorMessage = "Informe a senha confirmada")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirme a Senha")]
        [Compare(nameof(senha), ErrorMessage ="A senha e a confirmação não estão iguais")]
        [MaxLength(255, ErrorMessage = "Diminui isso ae parcero")]
        [MinLength(8, ErrorMessage = "Aumenta isso ae parcero")]
        public string confirmacaosenha { get; set; }
    }
}