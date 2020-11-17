using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public decimal TotalPrice { get { return Quantity * Product.Price; } }

        // navigation property 
        public virtual Product Product { get; set; }



        public OrderItem() { }


        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

        }
    }
}