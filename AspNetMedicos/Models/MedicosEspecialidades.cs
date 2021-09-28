using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMedicos.Models
{
    public class MedicosEspecialidades
    {
        public int MedicosEspecialidadesId { get; set; }
        public int MedicosId { get; set; }
        [ForeignKey("MedicosId")]
        public virtual Medicos Medico { get; set; }
        public int EspecialidadesId { get; set; }
        [ForeignKey("EspecialidadesId")]
        public virtual Especialidades Especialidade { get; set; }
    }
}