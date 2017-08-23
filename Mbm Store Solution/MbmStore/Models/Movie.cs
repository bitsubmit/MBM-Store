using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        
        
        private string director;


        public string Director
        {
            get { return director; } 
            set { director = value; } 
        }
        
        

        public Movie(string title, decimal price, string director):base(title,price)
        {
            this.director = director;
        }
    }
}