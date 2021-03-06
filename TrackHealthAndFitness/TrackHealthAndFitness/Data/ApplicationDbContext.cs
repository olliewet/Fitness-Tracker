using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
     
        public DbSet<ExerciseTracker> ExecriseTracker { get; set; }
        public DbSet<DifferentExercise> DifferentExercises { get; set; }
        public DbSet<FavExercise> FavExercises { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            builder.Entity<ExerciseTracker>(entity =>
            {
                entity.ToTable(name: "ExerciseTracker").HasKey(b => b.InputID)
        .HasName("PrimaryKey_InputID");
            });
            builder.Entity<DifferentExercise>(entity =>
            {
                entity.ToTable(name: "DifferentExercise");
            });
            builder.Entity<FavExercise>(entity =>
            {
                entity.ToTable(name: "FavExercise");
          
            });

        }
    }


}
