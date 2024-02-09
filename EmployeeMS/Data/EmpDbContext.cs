using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeMS.Models;

namespace EmployeeMS.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMS.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
