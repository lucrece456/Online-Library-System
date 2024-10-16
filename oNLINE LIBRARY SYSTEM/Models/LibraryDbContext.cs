using oNLINE_LIBRARY_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oNLINE_LIBRARY_SYSTEM.Models
{
    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

public DbSet<Book> Books { get; set; }
}
}