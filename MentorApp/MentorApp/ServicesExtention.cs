using System;
using MentorApp.DAL;
using Microsoft.EntityFrameworkCore;

namespace MentorApp
{
	public static class ServicesExtention
	{
		
		public  static void Registration(this IServiceCollection services,IConfiguration configuration)
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
		}
	}
}

