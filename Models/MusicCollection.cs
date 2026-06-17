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
        public bool RepeatEnabled { get; set; } = false;

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

        public bool MoveNext()
        {
            if (Songs.Count == 0) return false;

            if (currentSongIndex + 1 < Songs.Count)
            {
                currentSongIndex++;
                return true;
            }

            if (RepeatEnabled)
            {
                currentSongIndex = 0;
                return true;
            }

            return false;
        }

        public bool MovePrevious()
        {
            if (Songs.Count == 0) return false;

            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                return true;
            }

            if (RepeatEnabled)
            {
                currentSongIndex = Songs.Count - 1;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentSongIndex = 0;
        }
    }
}
