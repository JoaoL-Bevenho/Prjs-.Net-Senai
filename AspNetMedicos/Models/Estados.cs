using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMedicos.Models
{
    public class Estados
    {
        public int EstadosId { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public int PaisesId { get; set; }
        [ForeignKey("PaisesId")]
        public virtual Paises Pais { get; set; }
    }
}