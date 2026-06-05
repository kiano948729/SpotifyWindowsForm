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
        public MainMenuForm()
        {
            InitializeComponent();

            player = new Musicplayer();
            playlist = new Playlist("Test playlist");

            SeedTestData();
        }

        private void SeedTestData()
        {
            Song song1 = new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3");
            Song song2 = new Song("Song 2", "Artist 1", "Pop", "Assets/music/oof.mp3");

            playlist.AddSong(song1);
            playlist.AddSong(song2);

            artist = new Artist("Artist 1", "Test artiest voor Spotify");

            artist.AddSong(song1);
            artist.AddSong(song2);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playlist.PlayPlaylist(player);
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