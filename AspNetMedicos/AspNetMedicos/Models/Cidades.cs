using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMedicos.Models
{
    public class Cidades
    {
        public int CidadesId { get; set; }
        public string nome { get; set; }
        public int EstadosId { get; set; }
        [ForeignKey("EstadosId")]
        public virtual Estados Estado { get; set; }
    }
}