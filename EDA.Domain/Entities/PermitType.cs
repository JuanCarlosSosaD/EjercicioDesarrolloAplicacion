using EDA.Domain.ApiModels;
using EDA.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace EDA.Domain.Entities
{
    public class PermitType : IConverter.IConvertModel<PermitType, PermitTypeApiModel>
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Description { get; set; }
        public ICollection<Permit> Permits { get; set; }

        public PermitTypeApiModel Convert() => new PermitTypeApiModel
        {
            ID = ID,
            Description = Description
        };
    }
}
