using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PortalDeCapacitaciones.Controllers
{
    public class SearchController : Controller
    {
        // Mock data for videos
        private static List<Video> GetVideosByCategory(string category)
        {
            var allVideos = new List<Video>
            {
                new Video { Title = "Video 1", Category = "category1" },
                new Video { Title = "Video 2", Category = "category2" },
                new Video { Title = "Video 3", Category = "category3" }
            };
            return allVideos.Where(v => v.Category == category).ToList();
        }

        // Mock data for PDFs
        private static List<PDF> GetAvailablePDFs()
        {
            // In a real application, you'd fetch this data from a database or file system
            return new List<PDF>
            {
                new PDF { Name = "Document 1", FilePath = "/files/doc1.pdf" },
                new PDF { Name = "Document 2", FilePath = "/files/doc2.pdf" }
            };
        }

        [HttpGet("search")]
        public IActionResult Index(string category, string query)
        {
            var videos = GetVideosByCategory(category);

            if (!string.IsNullOrEmpty(query))
            {
                videos = videos.Where(v => v.Title.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var pdfs = GetAvailablePDFs(); // Fetch PDFs

            ViewData["Category"] = category;
            ViewData["Query"] = query;
            ViewData["Videos"] = videos;
            ViewData["PDFs"] = pdfs; // Pass PDFs to view

            return View();
        }
    }

    // Model for Video
    public class Video
    {
        public string Title { get; set; }
        public string Category { get; set; }
    }

    // Model for PDF
    public class PDF
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
