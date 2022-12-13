using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotlight.Persistence
{
    public class SpotlightContextFactory : IDesignTimeDbContextFactory<SpotlightContext>
    {
        public SpotlightContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SpotlightContext>();
            optionsBuilder.UseSqlite("Data Source=Spotlight.db");

            return new SpotlightContext(optionsBuilder.Options);
        }
    }
}
