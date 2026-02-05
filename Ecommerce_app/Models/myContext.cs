using Microsoft.EntityFrameworkCore;
namespace Ecommerce_app.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        {
            
        }
        public DbSet<Admin> tbl_admin { get; set; }
        public DbSet<Customer> tbl_customer { get; set; }
        public DbSet<category> tbl_category { get; set; }
        public DbSet<product> tbl_product { get; set; }

        public DbSet<cart> tbl_cart { get; set; }

        public DbSet<Feedback> tbl_feedback { get; set; }

        public DbSet<Faqs> tbl_faq { get; set; }
    }
}
