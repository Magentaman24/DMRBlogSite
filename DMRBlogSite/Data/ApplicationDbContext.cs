using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DMRBlogSite.Models;

namespace DMRBlogSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<DMRBlogSite.Models.Comment> Comment { get; set; }
    }
}