using System;
using System.Collections.Generic;

namespace SpotifyWindowsForm.Models
{
    public class Playlist : IPlayable
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        private int currentSongIndex = 0;

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public void RemoveSong(Song song)
        {
            if (song != null)
            {
                Songs.Remove(song);
            }
        }

        public void AddAlbum(Album album)
        {
            if (album?.Songs == null) return;

            foreach (var song in album.Songs)
            {
                AddSong(song);
            }
        }

        public void AddPlaylist(Playlist playlist)
        {
            if (playlist?.Songs == null) return;

            foreach (var song in playlist.Songs)
            {
                AddSong(song);
            }
        }

        public void PlayPlaylist(Musicplayer player)
        {
            if (Songs.Count == 0 || player == null) return;

            currentSongIndex = 0;
            player.Play(this);
        }

        public void SkipSong(Musicplayer player)
        {
            if (player == null || Songs.Count == 0) return;

            currentSongIndex++;

            if (currentSongIndex >= Songs.Count)
            {
                player.Stop();
                return;
            }

            player.Play(this);
        }

        public void StopPlaylist(Musicplayer player)
        {
            player?.Stop();
        }

        public Song GetCurrentSong()
        {
            if (Songs.Count == 0) return null;
            return Songs[currentSongIndex];
        }
    }
}