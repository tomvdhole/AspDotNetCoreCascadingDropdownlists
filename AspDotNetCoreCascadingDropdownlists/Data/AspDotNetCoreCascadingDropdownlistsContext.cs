using Microsoft.EntityFrameworkCore;

namespace AspDotNetCoreCascadingDropdownlists.Models
{
    public class AspDotNetCoreCascadingDropdownlistsContext : DbContext
    {
        public AspDotNetCoreCascadingDropdownlistsContext(DbContextOptions<AspDotNetCoreCascadingDropdownlistsContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
