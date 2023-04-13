using Microsoft.EntityFrameworkCore;
using EC.Model.Entity.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace EC.Infrastructure
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            var customer=modelBuilder.Entity<Customer>();
            customer.HasKey(s=>s.Id).IsClustered();
            customer.Property(s=>s.Name).IsRequired().HasMaxLength(50);
            customer.Property(s => s.DOB).IsRequired();
            customer.Property(s=>s.Address).IsRequired().HasMaxLength(200);
            customer.Property(s=>s.City).IsRequired().HasMaxLength(50);
            customer.Property(s=>s.MobileNumber).IsRequired().HasMaxLength(10);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
