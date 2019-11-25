using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Common.Interfaces;
using Portfolio.Domain.Entities;

namespace Persistence
{
    public class PortfolioDbContext : DbContext, IPortfolioDbContext
    {
        private readonly IDateTime _dateTime;

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) {  }

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Value> Values { get; set; }


        /// <summary>
        /// Applies all Entity Configurations
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);
        }
    }
}