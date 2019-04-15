using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMedicos.Models
{
    public class Medicos
    {
        public int MedicosId { get; set; }
        public string crm { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string email { get; set; }
        public bool atendeporconvenio { get; set; }
        public bool temclinica { get; set; }
        public string websiteblog { get; set; }
        public int CidadesId { get; set; }
        [ForeignKey("CidadesId")]
        public virtual Cidades Cidade { get; set; }
    }
}