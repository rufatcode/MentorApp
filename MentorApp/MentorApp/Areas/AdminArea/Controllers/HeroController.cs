using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorApp.Areas.AdminArea.ViewModels.HeroViewModel;
using MentorApp.DAL;
using MentorApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentorApp.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class HeroController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;
        public HeroController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Heroes.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateHeroVM createHeroVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Heroes.Any(h=>h.Title.ToLower()==createHeroVM.Title.ToLower()))
            {
                ModelState.AddModelError("Title", "exist Title");
                return View();
            }
            _context.Heroes.Add(new Hero { Title = createHeroVM.Title, Content = createHeroVM.Content });
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Hero");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Hero hero = _context.Heroes.FirstOrDefault(h => h.Id == id);
            if (hero==null)
            {
                return NotFound();
            }
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Hero");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return BadRequest("Hero Not found");
            }
            Hero existHero = _context.Heroes.FirstOrDefault(p => p.Id == id);
            if (existHero==null)
            {
                return NotFound("Hero not found");
            }

            return View(new UpdateHeroVM { Title=existHero.Title,Content=existHero.Content});
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int id,UpdateHeroVM updateHeroVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Hero existHero = _context.Heroes.FirstOrDefault(h => h.Id == id);
            if (_context.Heroes.Any(h=>h.Title==updateHeroVM.Title&updateHeroVM.Title!=existHero.Title))
            {
                ModelState.AddModelError("Title", "Exist Title");
                return View();
            }
            existHero.Title = updateHeroVM.Title;
            existHero.Content = updateHeroVM.Content;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Hero");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return BadRequest("Hero is not exist");
            }
            Hero hero = _context.Heroes.FirstOrDefault(h => h.Id == id);
            if (hero==null)
            {
                return NotFound("Hero Not found");
            }
            return View(new DetailHeroVM { Content=hero.Content,Title=hero.Title});
        }
    }
}

