namespace Perpustakaan.Models
{
    public class BookClass
    {
        public int id { get; set; }
        public string judul { get; set; } = string.Empty;
        public string penerbit { get; set; } = string.Empty;
        public string penulis { get; set; } = string.Empty;
        public string genre { get; set; } = string.Empty;
    }
}
