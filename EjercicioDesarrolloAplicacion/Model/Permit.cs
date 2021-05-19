using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDesarrolloAplicacion.Model
{
    public class Permit
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeLastName { get; set; }
        public PermitType PermitType { get; set; }
        [ForeignKey("PermitType")]
        public int PermitTypeId { get; set; }
        [Required]
        public DateTime PermitDate { get; set; }
    }
}
