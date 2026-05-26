using Microsoft.VisualBasic.ApplicationServices;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWindowsForm.Models
{
    internal class Song
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        /* title,ganre, artist, timestamp
         * song heeft dalijk een tijdsduur, naam en artiest.
         * play 
         */
        public void Play(string FilePath)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(FilePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }
        public void Pause()
        {
            
        }
        // stop and pause should probally both use a timestamp to mark where you left off,
        // though stop might also close the playlist, and pause just keeps you on the current song?
        public void Stop()
        {
            outputDevice.Stop();
        }
        public void Skip()
        {
            // uitwerken op basis van playlist? as in, this is song #1, skip to next song in list.
        }
        public string Getinfo()
        {
            string gotteninfo = "hoi";
            return gotteninfo;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Song player = new Song();
                player.Play(@"Assets\music\sample-1.mp3");

                Console.WriteLine("Playing MP3 file...");
                Console.ReadLine();

                player.Stop();
            }
        }
    }
}
