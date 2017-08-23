using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Product
    {
        // fields
        //private string title;
        //private double price;
        //private string imageUrl;

        //properties
        public int ProductId
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }
        public decimal Price
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set; 
        }

        public string Category { get; set; }

        // constructors
        public Product()
        {

        }
        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
}