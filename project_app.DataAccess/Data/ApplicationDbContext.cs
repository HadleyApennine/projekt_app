using Microsoft.Build.Framework.XamlTypes;
using Microsoft.EntityFrameworkCore;
using project_app.Models;
using projekt_app.Models;

namespace projekt_app.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //
        }

        public DbSet<Category> Categories { get; set; }
    }
}
