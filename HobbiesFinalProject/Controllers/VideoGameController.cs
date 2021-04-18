using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Controllers
{
    public class VideoGameController : Controller
    {
        // GET: VideoGameController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VideoGameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoGameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoGameController/Create
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

        // GET: VideoGameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoGameController/Edit/5
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

        // GET: VideoGameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoGameController/Delete/5
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
