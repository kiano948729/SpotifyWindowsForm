using System;
using System.Windows.Forms;
using SpotifyWindowsForm.Models;

namespace SpotifyWindowsForm
{
    public partial class MainMenuForm : Form
    {
        private Playlist playlist;
        private Musicplayer player;

        public MainMenuForm()
        {
            InitializeComponent();

            player = new Musicplayer();
            playlist = new Playlist("Test playlist");

            SeedTestData();
        }

        private void SeedTestData()
        {
            playlist.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            playlist.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/oof.mp3"));

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
    }
}