using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Playlist
    {
         

 
    
        private string name;
        private List<Music> songs = new List<Music>();

        public Playlist(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public int Count { get { return songs.Count; } }

        public string TotalDuration
        {
            get
            {
                int total = 0;
                for (int i = 0; i < songs.Count; i++)
                    total = total + songs[i].DurationSeconds;

                int minute = total / 60;
                int secunde = total % 60;

                return minute + ":" + secunde.ToString("D2");
            }
        }

        public bool Add(Music m)
        {
            foreach (Music s in songs)
                if (s.Title == m.Title)
                    return false;  
            songs.Add(m);
            return true;
        }

        public Music MostPlayed()
        {
            if (songs.Count == 0)
                return null;
            Music top = songs[0];
            for (int i = 1; i < songs.Count; i++)
                if (songs[i].PlayCount > top.PlayCount)
                    top = songs[i];
            return top;
        }

        public List<Music> Favorites()
        {
            List<Music> fav = new List<Music>();
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].IsFavorite)
                    fav.Add(songs[i]);
            }
            return fav;
        }
    }
}
 