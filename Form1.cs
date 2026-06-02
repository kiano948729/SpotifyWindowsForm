using NAudio.Wave;
using SpotifyWindowsForm.Models;
using System.Numerics;

namespace SpotifyWindowsForm
{
    public partial class Form1 : Form
    {
        private Musicplayer musicplayer;
        private Song currentSong;
        public Form1()
        {
            InitializeComponent();
            // hardcoded 1ste nummer voor functie testen
            currentSong = new Song("sample-1","soundgenerator","sounds",@"assets/music/sample-1.mp3");
            musicplayer = new Musicplayer();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            musicplayer.Play(currentSong);
        }

        // Pause Button Click Event  
        private void btnPause_Click(object sender, EventArgs e)
        {
            musicplayer.Pause();
        }

        // Stop Button Click Event  
        private void btnStop_Click(object sender, EventArgs e)
        {
            musicplayer.Stop();
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            musicplayer.Restart();
        }
    }
}
