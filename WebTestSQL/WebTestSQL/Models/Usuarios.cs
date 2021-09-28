using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTestSQL.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        public int UsuariosId { get; set; }
        [Required]
        [MaxLength(255)]
        public string nome { get; set; }
        [Required]
        [MaxLength(255)]
        public string login { get; set; }
        [Required]
        [MaxLength(255)]
        public string senha { get; set; }
    }
}