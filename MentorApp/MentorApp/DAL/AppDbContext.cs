using System;
using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.DAL
{
	public class AppDbContext:DbContext
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
	}
}

