using System;
using Microsoft.AspNetCore.Identity;

namespace MentorApp.Models
{
	public class AppUser:IdentityUser
	{
		public string FullName { get; set; }
		public AppUser()
		{
		}
	}
}

