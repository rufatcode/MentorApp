using System;
using System.ComponentModel.DataAnnotations;

namespace MentorApp.Models
{
	public class OurService
	{
		[Key]
		public int Id { get; set; }
		public string Services { get; set; }
		
	}
}

