using System;
using NAudio.Wave;

namespace SpotifyWindowsForm.Models
{
    public class Musicplayer
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;

        private IPlayable? currentCollection;

        public Action<IPlayable>? OnAutoAdvance { get; set; }

        public void Play(IPlayable playable)
        {
            Song song = playable.GetCurrentSong();
            if (song == null) return;

            currentCollection = playable;

            Cleanup();

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(song.FilePath);

            outputDevice.Init(audioFile);
            outputDevice.PlaybackStopped += OnPlaybackStopped;
            outputDevice.Play();
        }

        public void Pause()
        {
            outputDevice?.Pause();
        }

        public void Stop()
        {
            Cleanup();
        }

        public void Restart()
        {
            if (audioFile != null)
                audioFile.Position = 0;
        }

        public void Next()
        {
            if (currentCollection is MusicCollection mc)
            {
                if (mc.MoveNext())
                    Play(mc);
            }
        }

        public void Previous()
        {
            if (currentCollection is MusicCollection mc)
            {
                if (mc.MovePrevious())
                    Play(mc);
            }
        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            Cleanup();

            if (currentCollection is MusicCollection mc)
            {
                if (mc.MoveNext())
                {
                    OnAutoAdvance?.Invoke(mc);
                }
            }
        }

        private void Cleanup()
        {
            if (outputDevice != null)
            {
                outputDevice.PlaybackStopped -= OnPlaybackStopped;
                outputDevice.Dispose();
                outputDevice = null;
            }

            audioFile?.Dispose();
            audioFile = null;
        }
    }
}