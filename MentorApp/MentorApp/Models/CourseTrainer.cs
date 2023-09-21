using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorApp.Models
{
	public class CourseTrainer
	{
		public int Id { get; set; }		
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
		public Course Course { get; set; }
		[ForeignKey(nameof(Trainer))]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
		
		public CourseTrainer()
		{
		}
	}
}

