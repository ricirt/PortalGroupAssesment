using PortalGroupAssesment.Entites;
using PortalGroupAssesment.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.Services.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckNationalID(Customer customer)
        {
            MernisServiceChecker.      //'doesnt exist in the current context ' error
        }
    }
}
