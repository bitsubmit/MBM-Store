using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Track
    {

        public string Title
        {
            get; set;
        }
        public string Composer
        {
            get; set;
        }
        public TimeSpan Length
        {
            get; set;
        }
        public Track(string title, string composer, TimeSpan lenght)
        {
            this.Title = title;
            this.Composer = composer;
            this.Length = lenght;
        }
    }
}