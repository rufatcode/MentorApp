using System;
namespace MentorApp.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string ImgSrc { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public List<CourseTrainer> CourseTrainers{get;set;}
		public Course()
		{
			CourseTrainers = new();

        }
	}
}

