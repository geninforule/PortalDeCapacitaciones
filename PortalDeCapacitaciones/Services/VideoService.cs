// Services/VideoService.cs
using System.Collections.Generic;
using System.Linq;
//using .Models; // Cambia 'YourNamespace' por el nombre de tu espacio de nombres
//using .Data; // Asegúrate de incluir el espacio de nombres de tu contexto de base de datos


using PortalDeCapacitaciones.Models;

namespace PortalDeCapacitaciones.Services
{
    public class VideoService : IVideoService
    {
        //private readonly ApplicationDbContext _context;

        //public VideoService(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public IEnumerable<Video> GetAllVideos()
        //{
        //    return _context.Videos.ToList();
        //}

        //public Video GetVideoById(int id)
        //{
        //    return _context.Videos.Find(id);
        //}

        //public IEnumerable<Video> SearchVideos(string query)
        //{
        //    if (string.IsNullOrWhiteSpace(query))
        //        return GetAllVideos();

        //    return _context.Videos
        //        .Where(v => v.Title.Contains(query) || v.Description.Contains(query))
        //        .ToList();
        //}
    }
}