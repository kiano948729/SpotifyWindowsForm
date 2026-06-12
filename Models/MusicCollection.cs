using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace SpotifyWindowsForm.Models
{
    public abstract class MusicCollection : IPlayable
    {
        protected int currentSongIndex = 0;

        public List<Song> Songs { get; }

        protected MusicCollection()
        {
            Songs = new List<Song>();
        }

        public virtual void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public virtual void RemoveSong(Song song)
        {
            if (song != null)
            {
                Songs.Remove(song);
            }
        }

        public Song GetCurrentSong()
        {
            if (Songs.Count == 0)
                return null;

            return Songs[currentSongIndex];
        }
    }
}
