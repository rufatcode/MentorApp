using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorApp.DAL;
using MentorApp.Models;
using MentorApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly HomeVM _homeVM;
        public HomeController(AppDbContext context)
        {
            _context = context;
            _homeVM = new();
        }
        public IActionResult Index()
        {
            _homeVM.Heroes = _context.Heroes.ToList();
            _homeVM.About = _context.Abouts
                .Include(a=>a.AboutContidions)
                .FirstOrDefault();
            _homeVM.Why_Us = _context.Why_Us.FirstOrDefault();
            _homeVM.IconBoxes = _context.IconBoxes.ToList();
            _homeVM.Features = _context.Features.ToList();
            return View(_homeVM);
        }
    }
}

