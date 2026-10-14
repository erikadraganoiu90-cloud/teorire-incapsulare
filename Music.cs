using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    public enum MusicGenre { Pop, Rock, Jazz, Classical, HipHop, Electronic, Folk, Other }
    public class Music
    {
        private string title;
        private string artist;
        private MusicGenre genre;
        private int durationSeconds;
        private int releaseYear;
        private bool isFavorite;
        private int playCount;

        //constructorii

        public Music()
        {
            Console.WriteLine("ce mai faci");
        }

         
        public Music(string title, string artist, MusicGenre genre, int durationSeconds, int releaseYear, bool isFavorite, int playCount)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            DurationSeconds = durationSeconds;
            ReleaseYear = releaseYear;
            this.isFavorite = isFavorite;
            this.playCount = playCount;
        }
        public Music(string title, string artist, int durationSeconds)
        {
            Title = title;
            Artist = artist;
            DurationSeconds = durationSeconds;
            Genre = MusicGenre.Other;
            this.isFavorite = false;
            this.playCount = 0;
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Titlul nu poate fi gol.");
                }

                title = value;
            }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                if (value < 1860 || value > DateTime.Now.Year)
                    throw new ArgumentException("An de lansare invalid.");
                releaseYear = value;
            }

        }

        public string Artist
        {
            get { return artist; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Artistul nu poate fi gol.");
                }
                artist = value;
            }
        }

        public int DurationSeconds
        {
            get { return durationSeconds; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Durata trebuie sa fie mai mare ca 0.");
                }
                durationSeconds = value;
            }
        }

        public bool IsFavorite
        {
            get { return  isFavorite; }
            //set { isFavorite = value; }
        }

        public void AddToFavorites()
        {
            isFavorite= true;
        }
        public void RemoveFromFavorites()
        {
            isFavorite = false;
        }

        public int PlayCount
        {
            get { return  playCount; }
             
        }
        public void Play()
        {
            playCount++;
        }

        // format: "titlu,artist,gen,durataSecunde,anLansare"=>["Bohemian Rhapsody","Queen,]
        // exemplu: "Bohemian Rhapsody,Queen,Rock,354,1975"
        public Music(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Textul nu poate fi gol.");
            }

            string[] parti = text.Split(',');

            if (parti.Length != 5)
            {
                throw new ArgumentException("Format invalid. Asteptat: titlu,artist,gen,durata,an");
            }

            Title = parti[0].Trim();
            Artist = parti[1].Trim();
            Genre = Enum.Parse<MusicGenre>(parti[2].Trim(), true);
            DurationSeconds = int.Parse(parti[3].Trim());
            ReleaseYear = int.Parse(parti[4].Trim());
        }

        internal  MusicGenre Genre
        {
            get { return genre; }
            set { genre = value; }
             
        }


        public string Duration
        {
            get { return durationSeconds / 60 + ":" + durationSeconds % 60; }
        }

        private int rating = 0;

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException("Nota trebuie sa fie intre 1 si 5.");
                rating = value;
            }
        }



    }
    }
