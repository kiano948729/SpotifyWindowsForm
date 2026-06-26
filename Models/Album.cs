using System;

namespace SpotifyWindowsForm.Models
{
    public class Album : MusicCollection
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Album(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Album GetInfo(Album album)
        {
            return album;
        }

        public void PlayAlbum(Musicplayer player)
        {
            if (Songs.Count == 0 || player == null) return;
            Reset(); 
            player.Play(this);
        }
    }
}