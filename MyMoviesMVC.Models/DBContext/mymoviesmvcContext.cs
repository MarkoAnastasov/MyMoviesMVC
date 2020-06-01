using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyMoviesMVC.Models
{
    public partial class mymoviesmvcContext : IdentityDbContext<User,UserRole,int>
    {
        public mymoviesmvcContext(DbContextOptions<mymoviesmvcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserMovies> UserMovies { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NormalizedEmail)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PasswordHash)
                    .IsRequired();

            });


            modelBuilder.Entity<User>()
                .Ignore(x => x.EmailConfirmed)
                .Ignore(x => x.LockoutEnabled)
                .Ignore(x => x.LockoutEnd)
                .Ignore(x => x.PhoneNumber)
                .Ignore(x => x.PhoneNumberConfirmed)
                .Ignore(x => x.AccessFailedCount)
                .Ignore(x => x.TwoFactorEnabled);
        }
    }
}
