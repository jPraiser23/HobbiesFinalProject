using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HobbiesFinalProject.Data;
using HobbiesFinalProject.Models;
using HobbiesFinalProject.Models.Config;

namespace HobbiesFinalProject.Controllers
{
    public class TeamMembersController : Controller
    {
        private readonly HobbiesContext _context;
        private Repository<VideoGame> videoGames { get; set; }

        public TeamMembersController(HobbiesContext context)
        {
            videoGames = new Repository<VideoGame>(context);
            _context = context;
        }

        // GET: TeamMembers
        public async Task<IActionResult> Index()
        {
            ViewBag.VideoGames = videoGames.List();
            return View(await _context.TeamMembers.ToListAsync());
        }

        // GET: TeamMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamMember = await _context.TeamMembers
                .FirstOrDefaultAsync(m => m.MemberId == id);
            var videoGame = await _context.VideoGames
                .FirstOrDefaultAsync(g => g.GameId == id);
            if (teamMember == null)
            {
                return NotFound();
            }

            return View(teamMember);
        }

        // GET: TeamMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,FirstName,LastName,City,State,About,GameId")] TeamMember teamMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamMember);
        }

        // GET: TeamMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamMember = await _context.TeamMembers.FindAsync(id);
            if (teamMember == null)
            {
                return NotFound();
            }
            return View(teamMember);
        }

        // POST: TeamMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberId,FirstName,LastName,City,State,About,GameId")] TeamMember teamMember)
        {
            if (id != teamMember.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamMemberExists(teamMember.MemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(teamMember);
        }

        // GET: TeamMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamMember = await _context.TeamMembers
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (teamMember == null)
            {
                return NotFound();
            }

            return View(teamMember);
        }

        // POST: TeamMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamMember = await _context.TeamMembers.FindAsync(id);
            _context.TeamMembers.Remove(teamMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamMemberExists(int id)
        {
            return _context.TeamMembers.Any(e => e.MemberId == id);
        }
    }
}
