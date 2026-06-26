using System;

namespace SpotifyWindowsForm.Models
{
    public class Playlist : MusicCollection
    {
        public string Name { get; set; }

        public Playlist(string name)
        {
            Name = name;
        }

        public void AddAlbum(Album album)
        {
            if (album == null)
                return;

            foreach (Song song in album.Songs)
            {
                AddSong(song);
            }
        }

        public void AddPlaylist(Playlist playlist)
        {
            if (playlist == null) return;

            foreach (Song song in playlist.Songs)
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
    }
}