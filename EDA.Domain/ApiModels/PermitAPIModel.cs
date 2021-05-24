using EDA.Domain.Entities;
using EDA.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDA.Domain.ApiModels
{
    public class PermitAPIModel : IConverter.IConvertModel<PermitAPIModel, Permit>
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public string PermitTypeDescription { get; set; }
        public int PermitTypeId { get; set; }
        public DateTime PermitDate { get; set; }


        public Permit Convert() =>
            new Permit
            {
                ID = ID,
                EmployeeName = EmployeeName,
                EmployeeLastName = EmployeeLastName,
                PermitTypeId = PermitTypeId,
                PermitDate = PermitDate
            };
    }
}
