using System;
using MentorApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.DAL
{
	public class AppDbContext:IdentityDbContext<AppUser>
	{
	 	public DbSet<Hero> Heroes { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<AboutContidion> AboutContidions { get; set; }
		public DbSet<Why_us> Why_Us { get; set; }
		public DbSet<IconBox> IconBoxes { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Trainer> Trainers { get; set; }
		public DbSet<CourseTrainer> CourseTrainers { get; set; }
		public DbSet<SocialAccount> SocialAccounts { get; set; }
		public DbSet<Setting> Settings { get; set; }
		public DbSet<OurService> OurServices { get; set; }
	 	public DbSet<UsefulLink> UsefulLinks { get; set; }
		public AppDbContext(DbContextOptions context):base(context)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",

                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new AppUser
            {
                Id = ADMIN_ID,
                Email = "frankofoedu@gmail.com",
                FullName="sasaas",
                UserName = "frankofoedu@gmail.com",
             NormalizedUserName = "FRANKOFOEDU@GMAIL.COM"
            };

            //set user password
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "mypassworDDDDDDDD_12?");

            //seed user
            builder.Entity<AppUser>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            base.OnModelCreating(builder);
        }
    }
}

