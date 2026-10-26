using EFCoreSession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession01
{
    // Connection string for the database ? Build it in the constructor
    // Generate object from child Constructor => Constructor chaining Parent
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BOOKSTORE;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
