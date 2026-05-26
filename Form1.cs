using NAudio.Wave;

namespace SpotifyWindowsForm
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOut = new WaveOutEvent(); // Handles audio output  
        private AudioFileReader audioFileReader; // Reads and decodes MP3  
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            string filePath = @"Assets\music\sample-1.mp3";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found!");
                return;
            }

            try
            {
                // Initialize audio components if not already running  
                if (waveOut == null)
                {
                    waveOut = new WaveOutEvent(); // Uses Windows Multimedia APIs  
                    audioFileReader = new AudioFileReader(filePath); // Decodes MP3 to PCM  
                    waveOut.Init(audioFileReader); // Link reader to output  
                }

                waveOut.Play(); // Start playback  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing file: {ex.Message}");
                Cleanup(); // Release resources on error  
            }
        }

        // Pause Button Click Event  
        private void btnPause_Click(object sender, EventArgs e)
        {
            waveOut?.Pause();
        }

        // Stop Button Click Event  
        private void btnStop_Click(object sender, EventArgs e)
        {
            waveOut?.Stop();
            Cleanup(); // Release resources  
        }

        // Cleanup to prevent memory leaks  
        private void Cleanup()
        {
            audioFileReader?.Dispose();
            waveOut?.Dispose();
            audioFileReader = null;
            waveOut = null;
        }

        // Form Closing: Ensure cleanup  
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cleanup();
        }
    }
}
