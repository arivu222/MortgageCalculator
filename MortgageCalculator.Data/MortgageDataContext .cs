using System.Data.Entity;
using MortgageCalculator.Data.Entities;

namespace MortgageCalculator.Data
{
    public class MortgageDataContext : DbContext
    {
        public MortgageDataContext() : base("name=MortgageCalculatorDb")
        {

        }
        public DbSet<MortgageEntity> Mortgages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MortgageEntity>().HasKey(m => m.MortgageId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
