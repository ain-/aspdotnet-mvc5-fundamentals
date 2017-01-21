using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Books.Web.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}