using System;
using MentorApp.Models;

namespace MentorApp.ViewModel
{
	public class HomeVM
	{
		public List<Hero> Heroes { get; set; }
		public About About { get; set; }
		public Why_us Why_Us { get; set; }
		public List<IconBox> IconBoxes { get; set; }
		public List<Feature> Features { get; set; }
	 	public List<Course> Courses { get; set; }
		public List<Trainer> Trainers { get; set; }
		public List<OurService> OurServices { get; set; }
		public List<UsefulLink> UsefulLinks { get; set; }
		public HomeVM()
		{
			Heroes = new();
			IconBoxes = new();
			Features = new();
			Courses = new();
			Trainers = new();
			OurServices = new();
			UsefulLinks = new();
		}
	}
}

