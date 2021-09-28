using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MedicosMetaDados
    {
        [MetadataType(typeof(MedicosMetaDados))]
        public class MedicoMetadado
        {
            [Required(ErrorMessage = "obrigatorio informar crm")]
            [StringLength(30, ErrorMessage = "o crm deve possuir 30 caracteres")]
            public string CRM { get; set; }

            [Required(ErrorMessage = "obrigatorio informar nome")]
            [StringLength(30, ErrorMessage = "o nome deve possuir 30 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "obrigatorio informar crm")]
            [StringLength(30, ErrorMessage = "o crm deve possuir 30 caracteres")]
            public string Endereco { get; set; }

            [Required(ErrorMessage = "obrigatorio informar crm")]
            [StringLength(30, ErrorMessage = "o crm deve possuir 30 caracteres")]
            public string Email { get; set; }

            [Required(ErrorMessage = "obrigatorio informar crm")]
            [StringLength(30, ErrorMessage = "o crm deve possuir 30 caracteres")]
            public bool AtendePorConvenio { get; set; }

            [Required(ErrorMessage = "obrigatorio informar crm")]
            [StringLength(30, ErrorMessage = "o crm deve possuir 30 caracteres")]
            public bool TemClinica { get; set; }


        }


    }
}