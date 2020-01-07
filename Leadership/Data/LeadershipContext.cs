using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Leadership.Models
{
    public class LeadershipContext : DbContext
    {
        public LeadershipContext (DbContextOptions<LeadershipContext> options)
            : base(options)
        {
        }

        public DbSet<Leadership.Models.Department> Department { get; set; }
    }
}
