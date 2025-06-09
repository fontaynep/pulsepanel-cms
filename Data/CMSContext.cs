using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CustomCMS.Models;

namespace CustomCMS.Data
    {
    public class CMSContext : IdentityDbContext
        {
        public CMSContext(DbContextOptions<CMSContext> options)
            : base(options) { }

        public DbSet<PageContent> PageContents
            {
            get; set;
            }
        }
    }
