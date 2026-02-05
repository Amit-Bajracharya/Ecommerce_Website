using Microsoft.EntityFrameworkCore;
namespace Ecommerce_app.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        {
            
        }
        public DbSet<Admin> tbl_admin { get; set; }
    }
}
