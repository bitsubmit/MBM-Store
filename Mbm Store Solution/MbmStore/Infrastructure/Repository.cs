using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public class Repository
    {
        
        public List<Product> Products = new List<Product>();
        public List<Invoice> Invoices = new List<Invoice>();        public Repository()
        {
            //---------------------
            //Books starts here!
            //---------------------

            //string author, string title, decimal price, short published
            Book myBook = new Book("J.K. Rowling", "Harry Potter", 60, 15);
            myBook.ProductId = 1; 
            myBook.Publisher = "Little, Brown Book Group";
            myBook.ISBN = "1-333-5555555";
            myBook.ImageUrl = "harry.jpg";
            myBook.Category = "Book";
            Products.Add(myBook);


            Book myBook2  = new Book("J.R.R. Tolkien", "The Lord Of The Rings", 50, 14);
            myBook2.ProductId = 2;
            myBook2.Publisher = "George Allen & Unwin";
            myBook2.ISBN = "1-333-6666666";
            myBook2.ImageUrl = "lord.jpg";
            myBook2.Category = "Book";
            Products.Add(myBook2);


            //---------------------
            //CD's starts here!
            //---------------------

            //string artist, string title, decimal price, short released)
            MusicCD cd1 = new MusicCD("Metallica", "The Black Album", 60, 15);
            cd1.ProductId = 3;
            cd1.Released = 1991;
            cd1.Label = "Blackened Recordings";
            cd1.ImageUrl = "metallica.jpg";
            cd1.Category = "CD";
            cd1.AddTrack(new Track("Enter Sandman", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Sad But True", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Holier Than Thou", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("The Unforgiven", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Whereever I May Roam", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Don't Tread On Me", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Through The Never", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Nothing Else Matters", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("Of Wolf and Man", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("The God That Failed", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("My Friend Of Misery", "--", new TimeSpan(2, 14, 18)));
            cd1.AddTrack(new Track("The Struggle Within", "--", new TimeSpan(2, 14, 18)));
            //cd1.AddTrack(new Track("So What", "--", new TimeSpan(2, 14, 18)));
            Products.Add(cd1);
            
        
            //string artist, string title, decimal price, short released)
            MusicCD cd2 = new MusicCD("Nirvana", "Nevermind", 50, 16);
            cd2.ProductId = 4;
            cd2.Label = "Blackened Recordings";
            cd2.ImageUrl = "nirvana.jpg";
            cd2.Category = "CD";
            //cd2.AddTrack(new Track("Sad But True", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Smells Like Teen Spirit", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Come as You Are", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Breed", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Lithium", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Polly", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Territorial Pissings", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Drain You", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Lounge Act", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Stay Away", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("On a Plain", "--", new TimeSpan(2, 14, 18)));
            cd2.AddTrack(new Track("Something in the Way", "--", new TimeSpan(2, 14, 18)));
            Products.Add(cd2);



            //---------------------
            //Movies starts here!!
            //---------------------
            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "Jon Favreau");
            jungleBook.ProductId = 5;
            jungleBook.ImageUrl = "JungleBook.jpg";
            jungleBook.Category = "Movie";
            Products.Add(jungleBook);

            Movie gladiator = new Movie("Gladiator", 49.95m, "Ridley Scott");
            gladiator.ProductId = 6;
            gladiator.ImageUrl = "gladiator.jpg";
            gladiator.Category = "Movie";
            Products.Add(gladiator);

            Movie forrestGump = new Movie("Forrest Gump", 154.50m, "Robert Zemeckis");
            forrestGump.ProductId = 7;
            forrestGump.ImageUrl = "forrest-gump.jpg";
            forrestGump.Category = "Movie";
            Products.Add(forrestGump);


            Customer c1 = new Customer("Simon", "Jakobsen", "Risdalsvej", "8260", "Viby J");

            Customer c2 = new Customer("Helle", "Jakobsen", "Frigsvej", "8680", "Ry");

            Invoice i1 = new Invoice(1, new DateTime(2016, 4, 6) ,c1);
            Invoices.Add(i1);
            Invoice i2 = new Invoice(2, new DateTime(2016, 4, 5), c2);
            Invoices.Add(i2);

            //order items
            i1.AddOrderItem(jungleBook, 1);
            i1.AddOrderItem(cd1, 1);
            i2.AddOrderItem(gladiator, 1);
            i2.AddOrderItem(cd2, 1);

        }

    }
}