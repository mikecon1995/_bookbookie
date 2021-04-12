using Microsoft.EntityFrameworkCore;

namespace bookbookie.Data
{
    public class BookStoreContext : DbContext
    {
        

        public DbSet<Books> Books { get; set; }

    }
}
