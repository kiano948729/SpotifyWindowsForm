using System;
using System.Collections.Generic;

namespace SpotifyWindowsForm.Models
{
    public class User
    {
        public string Username { get; set; }

        //collecties
        public List<User> Friends { get; set; }
        public List<Playlist> Playlists { get; set; }

        public User(string username)
        {
            Username = username;
            Friends = new List<User>();
            Playlists = new List<Playlist>();
        }

        //playlist toevoegen
        public void AddPlaylist(Playlist playlist)
        {
            if (playlist != null)
            {
                Playlists.Add(playlist);
            }
        }

        //playlists bekijken
        public List<Playlist> GetPlaylists()
        {
            return Playlists;
        }
    }
}