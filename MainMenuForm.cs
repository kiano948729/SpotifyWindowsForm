using System;
using System.Windows.Forms;
using SpotifyWindowsForm.Models;

namespace SpotifyWindowsForm
{
    public partial class MainMenuForm : Form
    {
        private Playlist playlist;
        private Musicplayer player;
        private Artist artist;
        private Album album1,album2,album3,album4;
        private Song testSong;
        public MainMenuForm()
        {
            InitializeComponent();

            player = new Musicplayer();
            playlist = new Playlist("Test playlist");
            album1 = new Album("testalbum-1", "dit is een test album");
            album2 = new Album("testalbum-2", "dit is een test album");
            album3 = new Album("testalbum-3", "dit is een test album");
            album4 = new Album("testalbum-4", "dit is een test album");
            SeedTestData();
        }

        private void SeedTestData()
        {
            testSong = new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3");

            Song song2 = new Song("Song 2", "Artist 1", "Pop", "Assets/music/oof.mp3");

            playlist.AddSong(testSong);
            playlist.AddSong(song2);

            artist = new Artist("Artist 1", "Test artiest voor Spotify");

            album1.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album1.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            album1.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album1.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));

            album2.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album2.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album2.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album2.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));

            album3.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album3.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album3.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album3.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));

            album4.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            album4.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album4.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album4.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
        }
        

        private void playButton_Click(object sender, EventArgs e)
        {
            player.Play(testSong);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            playlist.SkipSong(player);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
        }

        private void artistButton_Click(object sender, EventArgs e)
        {
            //i.p.v een messagebox kan dit later een aparte form worden
            MessageBox.Show(
                artist.ToString(),
                "Artist Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}