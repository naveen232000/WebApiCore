using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

namespace WebApiCore.Data
{
    public class EmpApiDbContext : DbContext
    {
        public EmpApiDbContext (DbContextOptions<EmpApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCore.Models.Employee> Employee { get; set; } = default!;
    }
}
