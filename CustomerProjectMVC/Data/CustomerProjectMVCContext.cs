using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerProjectMVC.Models;

namespace CustomerProjectMVC.Data
{
    public class CustomerProjectMVCContext : DbContext
    {
        public CustomerProjectMVCContext (DbContextOptions<CustomerProjectMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerProjectMVC.Models.Customer> Customer { get; set; } = default!;
    }
}
