using EDA.Domain.Entities;
using EDA.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EDA.Domain.ApiModels
{
    public class PermitTypeApiModel : IConverter.IConvertModel<PermitTypeApiModel, PermitType>
    {
        public int ID { get; set; }

        public string Description { get; set; }
        public ICollection<PermitAPIModel> Permits { get; set; }
        public PermitType Convert() => new PermitType
        {
            ID = ID,
            Description = Description
        };
    }
}
