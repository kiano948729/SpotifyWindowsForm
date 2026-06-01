using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace SpotifyWindowsForm.Models
{
    internal class Musicplayer
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public void Play(Song Song)
        {


            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(Song.FilePath);
                outputDevice.Init(audioFile);
            }
        outputDevice.Play();
        }

        // Pause Button Click Event  
        private void btnPause_Click(object sender, EventArgs e)
        {
            // todo
        }

        // Stop Button Click Event  
        private void Stop(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }
        private void Restart(object sender, EventArgs e)
        {
           audioFile.Position = 0;
           // was working in forms, moved to player.
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
        }
    }
}