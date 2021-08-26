using Microsoft.EntityFrameworkCore;
using PortalGroupAssesment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalGroupAssesment.DataAccessLayer.EntityFramework
{
    public class PortalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PT432LC\LOCAL;Database=MyDb;Trusted_Connection=True;");
        }
        public DbSet<Customer> Customers{ get; set; }
    }
}
