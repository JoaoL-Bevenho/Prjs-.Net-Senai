//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMedicos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicosEspecialidade
    {
        public int MedicosEspecialidadesId { get; set; }
        public int MedicosId { get; set; }
        public int EspecialidadesId { get; set; }
    
        public virtual Especialidade Especialidade { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
