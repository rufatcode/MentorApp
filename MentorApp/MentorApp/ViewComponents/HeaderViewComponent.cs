using System;
using MentorApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace MentorApp.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;
		public async Task<IViewComponentResult> InvokeAsync()
		{
			Dictionary<string, string> data = _context.Settings.ToDictionary(s => s.Key, s => s.Value);
			return View(await Task.FromResult(data));
		}
		public HeaderViewComponent(AppDbContext context)
		{
			_context = context;
		}
	}
}

