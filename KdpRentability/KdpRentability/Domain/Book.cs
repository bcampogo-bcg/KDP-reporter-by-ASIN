namespace KdpRentability.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string ASIN { get; set; }

    }
}
