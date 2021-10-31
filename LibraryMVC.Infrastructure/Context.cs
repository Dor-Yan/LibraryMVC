using LibraryMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTag> BookTag { get; set; }
        public DbSet<BookWriter> BookWriter { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Domain.Model.Type> Types { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Many to many
            builder.Entity<BookTag>()
                .HasKey(it => new { it.BookId, it.TagId });

            builder.Entity<BookTag>()
                .HasOne<Book>(it => it.Book)
                .WithMany(i => i.BookTags)
                .HasForeignKey(it => it.BookId);

            builder.Entity<BookTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.BookTags)
                .HasForeignKey(it => it.TagId);


            builder.Entity<BookWriter>()
                .HasKey(it => new { it.BookId, it.WriterId });

            builder.Entity<BookWriter>()
                .HasOne<Book>(it => it.Book)
                .WithMany(i => i.BookWriters)
                .HasForeignKey(it => it.BookId);

            builder.Entity<BookWriter>()
                .HasOne<Writer>(it => it.Writer)
                .WithMany(t => t.BookWriters)
                .HasForeignKey(it => it.WriterId);
        }
    }
}
