using Microsoft.EntityFrameworkCore;
using Issue_Tracking_System.Models.Entities;
using System;

namespace Issue_Tracking_System.Contexts
{
    internal class IssueTrackingDataContext : DbContext
    {
        public IssueTrackingDataContext() { }

        public IssueTrackingDataContext(DbContextOptions<IssueTrackingDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Diana\OneDrive\Documents\Issues_Tracking_System.mdf; Integrated Security = True; Connect Timeout = 30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CaseEntity> Cases { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
    }
}
