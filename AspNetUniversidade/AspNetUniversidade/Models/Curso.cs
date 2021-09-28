using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetUniversidade.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string nome { get; set; }
        public int UniversidadeId { get; set; }
        [ForeignKey("UniversidadeId")]
        public virtual Universidade Universidade { get; set; }
    }
}