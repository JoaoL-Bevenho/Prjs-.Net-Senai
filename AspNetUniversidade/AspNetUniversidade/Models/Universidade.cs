using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetUniversidade.Models
{
    public class Universidade
    {
        public int UniversidadeId { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}