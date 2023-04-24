using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalExam.Models;

namespace FinalExam.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<FinalExam.Models.Author> Author { get; set; } = default!;

        public DbSet<FinalExam.Models.Book> Book { get; set; }
        public DbSet<BookStore> BookStores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<BookStore>().ToTable("BookStore");
            modelBuilder.Entity<Book>().ToTable("Book");
        }
    }
}
