using Books.Entities;
using System.Data.Entity;
using System.Diagnostics;

namespace Books.Web.DataContext
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Book> Books { get; set; }
    }
}