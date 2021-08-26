using PortalGroupAssesment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.Services.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckNationalID(Customer customer);
    }
}
