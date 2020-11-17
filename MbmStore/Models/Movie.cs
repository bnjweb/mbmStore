using System;

namespace MbmStore.Models
{
    public class Movie: Product
    {
        // properties
        public string Director { get; set; }
        public short Released { get; set; }

        // constructors
        public Movie() { }

        public Movie(int ProductId, string title, decimal price) : base (ProductId, title, price) { }

        public Movie(int ProductId, string title, decimal price, string imageUrl, string director) : base(ProductId, title, price)
        {
            ImageUrl = imageUrl;
            Director = director;
        }
    }
}