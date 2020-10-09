using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorldOmeterAPI.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<SummaryTotal> summaryTotals { get; set; }
        
        public DbSet<SummmaryCases> summaryCases { get; set; }

        public DbSet<CountryView> countryViews { get; set; }

    }
}
