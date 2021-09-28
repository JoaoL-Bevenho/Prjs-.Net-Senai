using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetUniversidade.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string nome { get; set; }
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public virtual Curso Curso { get; set; }
    }
}