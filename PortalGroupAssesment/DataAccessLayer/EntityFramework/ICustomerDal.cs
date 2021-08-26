using PortalGroupAssesment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.DataAccessLayer.EntityFramework
{
    public interface ICustomerDal
    {
        void Add(Customer customer);
    }
}
