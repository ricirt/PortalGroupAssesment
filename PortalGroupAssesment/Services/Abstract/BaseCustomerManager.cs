using PortalGroupAssesment.DataAccessLayer.EntityFramework;
using PortalGroupAssesment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.Services.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public virtual void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }
    }
}
