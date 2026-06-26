using Microsoft.VisualBasic.ApplicationServices;
using SpotifyWindowsForm.Services;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using SpotifyWindowsForm.Services;

namespace SpotifyWindowsForm.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //collecties
        public List<User> Friends { get; set; }
        public List<Playlist> Playlists { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
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
        public void AddFriend(User user)
        {
            if (Friends != null)
            {
                Friends.Add(user);
            }
            //friendService.SendRequest(user1, user2);

        }
        public void RemoveFriend(User user)
        {
            if (Friends != null)
            {
                Friends.Remove(user);
            }
        }
        public List<User> GetFriends()
        {
            return Friends;
        }
    }
}