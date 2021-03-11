using Leverage.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leverage.Data
{
    public class LgContext:DbContext
    {
        public LgContext(DbContextOptions<LgContext>options):base(options)
        {

        }
        public DbSet<Start> Start { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Services> Services{ get; set; }
    }
}
