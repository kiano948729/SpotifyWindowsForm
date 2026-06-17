using Microsoft.VisualBasic.ApplicationServices;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWindowsForm.Models
{
    public class Song : IPlayable
    {

        public string Title { get; set; }
        public string Artist { get; set; }
        public string FilePath {  get; set; }
        public string Genre { get; set; }

        /* title,genre, artist, timestamp
         * song heeft dalijk een tijdsduur, naam en artiest.
         * play 
         */
        public Song(string title, string artist, string genre, string filepath)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            FilePath = filepath;
        }

        public Song GetCurrentSong()
        {
            return this;
        }
    }
}
