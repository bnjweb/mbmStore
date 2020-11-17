using System;

namespace MbmStore.Models {

    public class Book : Product {
        // properties
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        // constructors
        public Book() { }

        public Book(int ProductId, string author, string title, decimal price, short published)
            : base(ProductId, title, price) {
            Author = author;
            Published = published;
        }

       
    }
}