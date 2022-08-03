using ExLib.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Infrastructure.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }
        public DbSet<BookLocation> BookLocation { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<BookStatus> BookStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region StatusSeed
            modelBuilder.Entity<BookStatus>().HasData(
                new BookStatus { Id = 1, Status = "Available", IsActive = true },
                new BookStatus { Id = 2, Status = "Checked Out", IsActive = true },
                new BookStatus { Id = 3, Status = "Damaged", IsActive = true },
                new BookStatus { Id = 4, Status = "Lost", IsActive = true });

            #endregion

            #region TypeSeed
            modelBuilder.Entity<BookType>().HasData(
                new BookType { Id = 1, Type = "Hardcover", IsActive = true },
                new BookType { Id = 2, Type = "Paperback", IsActive = true },
                new BookType { Id = 3, Type = "Digital Copy", IsActive = true });

            #endregion

            #region LocationSeed
            modelBuilder.Entity<BookLocation>().HasData(
                new BookLocation { Id = 1, Location = "Exactus Office", IsActive = true },
                new BookLocation { Id = 2, Location = "Owner's Home", IsActive = true },
                new BookLocation { Id = 3, Location = "In the Matrix", IsActive = true });
            #endregion

        }

    }
}
