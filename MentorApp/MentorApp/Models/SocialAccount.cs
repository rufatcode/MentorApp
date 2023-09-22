using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorApp.Models
{
	public class SocialAccount
	{
		public int Id { get; set; }
		public string Twitter { get; set; }
		public string Facebook { get; set; }
		public string Instagram { get; set; }
		public string Linkedin { get; set; }
        public SocialAccount()
		{
		}
	}
}

