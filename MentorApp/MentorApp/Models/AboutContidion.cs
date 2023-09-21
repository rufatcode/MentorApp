using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorApp.Models
{
	public class AboutContidion
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public About About { get; set; }
		[ForeignKey(nameof(About))]
		public int AboutId { get; set; }
		public AboutContidion()
		{
		}
	}
}

