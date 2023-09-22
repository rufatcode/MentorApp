using System;
using MentorApp.DAL;
using MentorApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MentorApp.ViewComponents
{
	public class FooterViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;
		public FooterViewComponent(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			Dictionary<string, string> data = _context.Settings.ToDictionary(s => s.Key, s => s.Value);
			TempData["Services"]= _context.OurServices.ToList();
			TempData["Links"]= _context.UsefulLinks.ToList();
            return View(await Task.FromResult(data));
		}
	}
}

