using System.Collections.Generic;
using SpotifyWindowsForm.Models;

namespace SpotifyWindowsForm.Data
{
    internal class MusicStore
    {
        public static List<Album> Albums = new List<Album>();
        public static List<Artist> Artists = new List<Artist>();
        public static List<Song> Songs = new List<Song>();
        public static List<Playlist> Playlists = new List<Playlist>();

        static MusicStore()
        {
            SeedAlbums();
            SeedArtists();
            SeedSongs();
            SeedPLaylist();
        }

        private static void SeedPLaylist()
        {
            Playlist testPlaylist = new Playlist("Test Playlist");
            testPlaylist.AddSong(new Song("Fantaisie Impromptu", "Frederic Chopin", "Classical", "Assets/music/fantaisie-impromptu.mp3"));
        }

        private static void SeedAlbums()
        {
            Album testAlbum = new Album("Test Album", "Album voor testen");
            testAlbum.AddSong(new Song("Fantaisie Impromptu", "Frederic Chopin", "Classical", "Assets/music/fantaisie-impromptu.mp3"));
            testAlbum.AddSong(new Song("Oof", "Onbekend", "Meme", "Assets/music/oof.mp3"));
            testAlbum.AddSong(new Song("River Flows In You", "Yiruma", "Classical", "Assets/music/River-Flows-In-You.mp3"));
            testAlbum.AddSong(new Song("Vivaldi Cello Sonata", "Vivaldi", "Classical", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            testAlbum.AddSong(new Song("Throne", "Bring Me The Horizon", "Metal", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            testAlbum.AddSong(new Song("Reaction", "Onbekend", "Electronic", "Assets/music/Reaction.mp3"));

            Albums.Add(testAlbum);
        }

        private static void SeedArtists()
        {
            Artist chopin = new Artist("Frederic Chopin", "Pools-Frans pianist en componist");
            Artist yiruma = new Artist("Yiruma", "Zuid-Koreaanse pianist en componist");
            Artist bmth = new Artist("Bring Me The Horizon", "Britse metalcore band");

            //koppelt bestaande nummers uit de albums-lijst aan de juiste artiest
            foreach (Album album in Albums)
            {
                foreach (Song song in album.Songs)
                {
                    if (song.Artist == chopin.Name) chopin.AddSong(song);
                    if (song.Artist == yiruma.Name) yiruma.AddSong(song);
                    if (song.Artist == bmth.Name) bmth.AddSong(song);
                }
            }

            Artists.Add(chopin);
            Artists.Add(yiruma);
            Artists.Add(bmth);
        }

        private static void SeedSongs()
        {
            foreach (Album album in Albums)
            {
                Songs.AddRange(album.Songs);
            }
            foreach(Playlist playlist in Playlists)
            {
                Songs.AddRange(playlist.Songs);
            }
        }
    }
}
