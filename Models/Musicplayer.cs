using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.SoundFont;
using NAudio.Wave;
namespace SpotifyWindowsForm.Models
{
    public class Musicplayer
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
        public void Pause()
        {
            if(outputDevice == null)
            {
                Console.WriteLine("geen nummer geselecteerd");
            }
            else
            {
                outputDevice.Pause();
            }
            
        }

        // Stop Button Click Event  
        public void Stop()
        {
            outputDevice?.Stop();
        }
        public void Restart()
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