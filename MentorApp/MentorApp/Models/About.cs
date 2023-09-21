using System;
using System.ComponentModel.DataAnnotations;

namespace MentorApp.Models
{
	public class About
	{
		[Key]
		public int Id { get; set; }
		public string ImgSrc { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string Info { get; set; }
		public List<AboutContidion> AboutContidions { get; set; }
		public About()
		{
		}
	}
}

