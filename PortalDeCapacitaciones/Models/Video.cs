namespace PortalDeCapacitaciones.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class PDF
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
