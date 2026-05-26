using NAudio.Wave;

namespace SpotifyWindowsForm
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"Assets\music\sample-1.mp3");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }

        // Pause Button Click Event  
        private void btnPause_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        // Stop Button Click Event  
        private void btnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop(); 
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
    }
}
