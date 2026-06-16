using System;
using NAudio.Wave;

namespace SpotifyWindowsForm.Models
{
    public class Musicplayer
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;
        private IPlayable? currentCollection;
        private bool manualStop = false;

        public void Play(IPlayable playable)
        {
            Song song = playable.GetCurrentSong();
            if (song == null) return;

            currentCollection = playable;

            manualStop = true;
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            manualStop = false;

            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;

            audioFile = new AudioFileReader(song.FilePath);
            outputDevice.Init(audioFile);
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
            manualStop = true;
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
            if (manualStop)
            {
                outputDevice?.Dispose();
                outputDevice = null;
                audioFile?.Dispose();
                audioFile = null;
                return;
            }

            //nummer is automatisch klaar: doorschakelen
            if (currentCollection is MusicCollection collection)
            {
                bool hasNext = collection.MoveNext();
                if (hasNext)
                {
                    Play(currentCollection);
                    return;
                }
            }

            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
            currentCollection = null;
        }
    }
}