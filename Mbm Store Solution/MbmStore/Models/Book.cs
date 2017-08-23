using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author
        {
            get; set;
        }
        public string Publisher
        {
            get; set;
        }
        public short Published
        {
            get; set;
        }
        public string ISBN
        {
            get; set;
        }

        // constructors
       
        public Book(string author, string title, decimal price, short published) : base(title,price)
        {
            Author = author;
            Published = published;
        }
    }
}