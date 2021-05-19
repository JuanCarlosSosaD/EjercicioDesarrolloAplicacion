using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDesarrolloAplicacion.Model
{
    public class PermitType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Permit> Permits { get; set; }
    }
}
