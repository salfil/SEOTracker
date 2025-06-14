using System.Diagnostics;
using InfoTrackSEOTracker.Models;
using Microsoft.AspNetCore.Mvc;
using SEOChecker.Services;

namespace InfoTrackSEOTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly GoogleSearchService _searchService = new GoogleSearchService();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Results(SearchInputModel model)
        {
            var result = _searchService.PerformSearch(model.SearchTerm, model.TargetUrl);
            return View(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
