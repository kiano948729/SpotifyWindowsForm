using System;
using NAudio.Wave;

namespace SpotifyWindowsForm.Models
{
    public class Musicplayer
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;

        public void Play(IPlayable playable)
        {
            if (playable == null)
            {
                Console.WriteLine("Geen afspeelbaar object geselecteerd");
                return;
            }

            Song song = playable.GetCurrentSong();

            if (song == null)
            {
                Console.WriteLine("Geen nummer gevonden");
                return;
            }

            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (audioFile == null)
            {
                audioFile = new AudioFileReader(song.FilePath);
                outputDevice.Init(audioFile);
            }

            outputDevice.Play();
        }

        public void Pause()
        {
            if (outputDevice == null)
            {
                Console.WriteLine("Geen nummer geselecteerd");
                return;
            }

            outputDevice.Pause();
        }

        public void Stop()
        {
            outputDevice?.Stop();
        }

        public void Restart()
        {
            if (audioFile != null)
            {
                audioFile.Position = 0;
            }
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