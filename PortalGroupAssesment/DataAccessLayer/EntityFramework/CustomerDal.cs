using Microsoft.EntityFrameworkCore;
using PortalGroupAssesment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.DataAccessLayer.EntityFramework
{
    public class CustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            using (PortalContext context = new PortalContext())
            {
                var addedEntity = context.Entry(customer);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
