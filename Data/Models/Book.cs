namespace book_store_app.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Descripion { get; set; }
        public bool? IsRead { get; set; }
        public DateTime DateRead { get; set; }
        public int? Rate { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public String CoverPicUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
