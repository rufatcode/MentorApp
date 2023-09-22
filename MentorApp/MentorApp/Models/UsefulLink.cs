using System;
using System.ComponentModel.DataAnnotations;

namespace MentorApp.Models
{
	public class UsefulLink
	{
		[Key]
		public int Id { get; set; }
		public string Link { get; set; }
		
	}
}

