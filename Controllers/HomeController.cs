using FinalPracticeSkaffold1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeSkaffold1.Controllers
{
    public class HomeController : Controller
    {

        private IFinalPracticeSkaffold1Repository repo { get; set; }

        public HomeController(IFinalPracticeSkaffold1Repository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]

        public IActionResult AddMoviePage()
        {
            return View();
        }


        [HttpPost]

        public IActionResult AddMoviePage(Responses ar)
        {
            if (ModelState.IsValid)
            {
                repo.InsertResponse(ar);
                repo.Save();
                return RedirectToAction("ViewMoviePage");

            }
            else
            {
                return View(ar);
            }


        }

        public IActionResult ViewMoviePage()
        {
            var blah = repo.Responses
                .OrderBy(x => x.Title)
                .ToList();
            return View(blah);
        }
        [HttpGet]
        public IActionResult Edit(int movieforumid)
        {
            var application = repo.Responses.Single(x => x.MovieForumId == movieforumid);
            return View("AddMoviePage", application);
        }

        [HttpPost]
        public IActionResult Edit(Responses blah)
        {
            repo.UpdateResponse(blah);
            repo.Save();

            return RedirectToAction("ViewMoviePage");


        }

        [HttpGet]
        public IActionResult Delete(int movieforumid)
        {
            var application = repo.Responses.Single(x => x.MovieForumId == movieforumid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(Responses blah)
        {
            repo.DeleteOneResponse(blah);
            repo.Save();


            return RedirectToAction("ViewMoviePage");
        }













        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
