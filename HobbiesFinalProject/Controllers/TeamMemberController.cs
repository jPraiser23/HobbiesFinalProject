using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Controllers
{
    public class TeamMemberController : Controller
    {
        // GET: TeamMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
