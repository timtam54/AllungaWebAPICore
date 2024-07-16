using System.Collections.Generic;
using AllungaWebAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ChartDteTme> chrtdtetme { get; set; }
        public DbSet<ReportParam> reportparam { get; set; }

        public DbSet<Report> report { get; set; }
        public DbSet<ChartKey> chartKey { get; set; }
    }
}
