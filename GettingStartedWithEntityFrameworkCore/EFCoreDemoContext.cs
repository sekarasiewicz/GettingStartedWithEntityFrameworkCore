using Microsoft.EntityFrameworkCore;

namespace GettingStartedWithEntityFrameworkCore
{
    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=EFCoreDemo;Integrated Security=False;User Id=sa;Password=Your_password123;MultipleActiveResultSets=True");
        }
    }
}