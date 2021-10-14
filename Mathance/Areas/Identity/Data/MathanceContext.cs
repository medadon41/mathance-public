using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathance.Areas.Identity.Data;
using Mathance.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mathance.Data
{
    public class MathanceContext : IdentityDbContext<MathanceUser>
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Answer> RightAnswers { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Dislike> Dislikes { get; set; }


        public MathanceContext(DbContextOptions<MathanceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MathanceUser>()
                .Ignore(c => c.AccessFailedCount)
                .Ignore(c => c.EmailConfirmed)
                .Ignore(c => c.PhoneNumber)
                .Ignore(c => c.PhoneNumberConfirmed)
                .Ignore(c => c.NormalizedEmail)
                .Ignore(c => c.AccessFailedCount)
                .Ignore(c => c.TwoFactorEnabled)
                .HasMany(p => p.Posts)
                .WithOne(a => a.Author)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MathanceUser>()
                .HasMany(ar => ar.RightAnswers);

            builder.Entity<Post>()
                .HasMany(t => t.Tags)
                .WithOne(e => e.Post)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Post>()
                .HasMany(c => c.Comments)
                .WithOne(e => e.Post)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Post>()
                .HasMany(i => i.Images)
                .WithOne(e => e.Post)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Post>()
                .HasMany(ar => ar.RightAnswers)
                .WithOne(e => e.Post)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Comment>()
                .HasMany(l => l.Likes)
                .WithOne(c => c.Comment)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
