using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorApp.Models
{
	public class Trainer
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public string ImgSrc { get; set; }
		public string Name { get; set; }
		public int FollowCount { get; set; }
		public int LikeCount { get; set; }
		public string Work { get; set; }
		[ForeignKey(nameof(SocialAccount))]
		public int SocialAccountId { get; set; }
		public SocialAccount SocialAccount { get; set; }
        public List<CourseTrainer> CourseTrainers { get; set; }
        
	}
}

