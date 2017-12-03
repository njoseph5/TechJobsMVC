using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        public IActionResult Results(string searchType, string searchTerm)

        {
            List<Dictionary<string, string>> jobs;
            if (searchType.Equals("all"))
            {
                jobs = JobData.FindAll();
                ViewBag.columns = ListController.columnChoices;
                //ViewBag.title = "Search";
                ViewBag.jobs = jobs;
                return View("Index");
            }
            else
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                ViewBag.columns = ListController.columnChoices;
                //ViewBag.title = "Search";
                ViewBag.jobs = jobs;
                return View("Index");
            }
        }
    }
}
