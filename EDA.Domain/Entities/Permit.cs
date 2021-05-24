using EDA.Domain.ApiModels;
using EDA.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EDA.Domain.Entities
{
    public class Permit : IConverter.IConvertModel<Permit, PermitAPIModel>
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

        public PermitAPIModel Convert() => new PermitAPIModel
        {
            ID = ID,
            EmployeeName = EmployeeName,
            EmployeeLastName = EmployeeLastName,
            PermitDate = PermitDate,
            PermitTypeId = PermitTypeId,
            PermitTypeDescription = PermitType == null ? null : PermitType.Description
        };
    }
}
