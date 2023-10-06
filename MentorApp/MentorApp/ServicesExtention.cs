using System;
using MentorApp.DAL;
using MentorApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MentorApp
{
	public static class ServicesExtention
	{

		public static void Registration(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllersWithViews();
			services.AddHttpContextAccessor();
			services.AddDbContext<AppDbContext>(option =>
			{
				option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
			});
			services.AddSession(option =>
			{
				option.IdleTimeout = TimeSpan.FromHours(1);
			});
			services.AddIdentity<AppUser, IdentityRole>(option =>
			{
				option.Password.RequireDigit = true;
				option.Password.RequiredLength = 8;
				option.Password.RequireLowercase = true;
				option.Password.RequireNonAlphanumeric = true;
				option.Password.RequireUppercase = true;
				option.Lockout.AllowedForNewUsers = true;
				option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
				option.Lockout.MaxFailedAccessAttempts = 5;
			}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
			
		}
	}
}

