using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWindowsForm.Models
{
    public class Album
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }
        private int currentSongIndex = 0;

        public Album(string name, string description)
        {
            Name = name;
            Description = description;
            Songs = new List<Song>();
        }
        public Album GetInfo(Album album)
        {
            return album;
        }     
                
        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
            else
            {
                Console.WriteLine("song not found");
            }
        }
        public void RemoveSong(Song song)
        {
            if (song != null)
            {
                Songs.Remove(song);
            }
            else
            { 
                Console.WriteLine("could not remove song"); 
            }
        }
        public void PlayAlbum(Musicplayer player)

        {

            if (Songs.Count == 0 || player == null) return;


            currentSongIndex = 0;

            player.Play(Songs[currentSongIndex]);

        }
    }
}
