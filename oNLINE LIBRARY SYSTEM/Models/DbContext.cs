namespace oNLINE_LIBRARY_SYSTEM.Models
{
    public class DbContext
    {
        private DbContextOptions<LibraryDbContext> options;

        public DbContext(DbContextOptions<LibraryDbContext> options)
        {
            this.options = options;
        }
    }
}