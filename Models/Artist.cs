using System;
using System.Collections.Generic;

namespace SpotifyWindowsForm.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private List<Album> Albums { get; set; }
        private List<Song> Songs { get; set; }

        public Artist(string name, string description = "")
        {
            Name = name;
            Description = description;
            Albums = new List<Album>();
            Songs = new List<Song>();
        }

        public void AddAlbum(Album album)
        {
            if (album != null)
            {
                Albums.Add(album);
            }
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public List<Album> GetAlbums()
        {
            return Albums;
        }

        public List<Song> GetSongs()
        {
            return Songs;
        }

        public override string ToString()
        {
            string info = $"Artist: {Name}\n";
            info += $"Description: {Description}\n\n";

            info += "Albums:\n";
            foreach (var album in Albums)
            {
                info += $"{album.Name}: {album.Description}\n";
            }

            info += "\nSongs:\n";
            foreach (var song in Songs)
            {
                info += $"{song.Title} ({song.Genre})\n";
            }

            return info;
        }
    }
}