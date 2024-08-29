using Microsoft.AspNetCore.Mvc;
using PortalDeCapacitaciones.Models;
using System.Diagnostics;

namespace PortalDeCapacitaciones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewData["ShowCarousel"] = true;
            ViewData["ShowVideoSection"] = true;
            ViewData["ShowPDFSection"] = true;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["ShowCarousel"] = false;
            ViewData["ShowVideoSection"] = false;
            return View();
        }

        public IActionResult Reproduccion(string id)
        {
            ViewData["ShowCarousel"] = false;
            ViewData["ShowVideoSection"] = false;
            ViewBag.VideoId = id;
            return View();

            //var video = _videoService.GetVideoById(id);
            //return View(video); // Devuelve una vista para reproducir un video específico

            //var videos = _videoService.SearchVideos(query);
            //return View(videos);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
