using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWindowsForm.Models
{
    public class Playlist
    {
        public string Name { get; set; }

        public Playlist(string name)
        {
            Name = name;
        }
    }
}
