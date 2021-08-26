using PortalGroupAssesment.Entites;
using PortalGroupAssesment.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.Services.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager, ICustomerCheckService
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckNationalID(customer))
            {
                base.Add(customer);
            }
            else
                throw new Exception("Invalid User");
        }

        public bool CheckNationalID(Customer customer)
        {
            
        }
    }
}
