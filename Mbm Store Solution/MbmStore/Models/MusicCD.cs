using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        private List<Track> tracks = new List<Track>();



        public new string Title
        {
            get; set;
        }

        public string Artist
        {
            get; set;
        }

        public string Label
        {
            get; set;
        }

        public short Released
        {
            get; set;
        }

        public List<Track> Tracks
        {
            get { return tracks; }
        }

        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            this.Artist = artist;
            this.Released = released;
            Title = title;
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan totalTime = new TimeSpan(0, 0, 0);
            foreach (Track track in Tracks)
            {
                totalTime = totalTime.Add(track.Length);
            }
            return totalTime;
        }
    }
}