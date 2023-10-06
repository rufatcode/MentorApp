using System;
using MentorApp.Models;

namespace MentorApp.Areas.AdminArea.ViewModels.CourseViewModel
{
	public class CreateCourseVM
	{
		public IFormFile Image { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
        public List<CourseTrainer> CourseTrainers { get; set; }
        public CreateCourseVM()
		{
			CourseTrainers = new();
		}
	}
}

