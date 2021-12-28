namespace BookStore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String PublicationYear { get; set; }
        public bool IsAvalable { get; set; }
        public String CallNumber { get; set; }
     
    }
}
