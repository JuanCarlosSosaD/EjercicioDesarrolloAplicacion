using EDA.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDA.Domain.Supervisor
{
    public partial class EDASupervisor : IEDASupervisor
    {
        private readonly IPermitTypeRepository _permitTypeRepository;
        private readonly IPermitRepository _permitRepository;

        public EDASupervisor()
        {

        }
        public EDASupervisor(IPermitRepository permitRepository, IPermitTypeRepository permitTypeRepository)
        {
            _permitTypeRepository = permitTypeRepository;
            _permitRepository = permitRepository;
        }
    }
}
