using System;
using MentorApp.DAL;
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
			return View(await Task.FromResult(data));
		}
	}
}

