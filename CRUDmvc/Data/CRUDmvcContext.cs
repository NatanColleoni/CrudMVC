using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDmvc.Models
{
    public class CRUDmvcContext : DbContext
    {
        public CRUDmvcContext (DbContextOptions<CRUDmvcContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDmvc.Models.Department> Department { get; set; }
    }
}
