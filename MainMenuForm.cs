using SpotifyWindowsForm.Data;
﻿using System;
using System.Data.Common;
using System.Diagnostics;
using SpotifyWindowsForm.Models;
using SpotifyWindowsForm.Services;
using System.DirectoryServices;
using System.Windows.Forms;


namespace SpotifyWindowsForm
{
    public partial class MainMenuForm : Form
    {
        private Playlist playlist;
        private Musicplayer player;
        private Album testAlbum;
        private IPlayable? activeCollection;

        public MainMenuForm()
        {
            InitializeComponent();

            player = new Musicplayer();

            //auto-advance terug op de UI-thread uitvoeren
            player.OnAutoAdvance = (collection) =>
            {
                this.BeginInvoke(() => player.Play(collection));
            };

            playlist = new Playlist("Test Playlist");
            testAlbum = new Album("Test Album", "Album voor testen");
            SeedTestData();
            ToggleInfo();
            HomePannel.Visible = true;
        }

        private void SeedTestData()
        {
            //playlist
            playlist.AddSong(new Song("Rickroll", "Rick Astley", "Pop", "Assets/music/rickroll.MP3"));
            playlist.AddSong(new Song("Oof", "Onbekend", "Meme", "Assets/music/oof.mp3"));
            playlist.AddSong(new Song("River Flows In You", "Yiruma", "Classical", "Assets/music/River-Flows-In-You.mp3"));

            //album
            testAlbum.AddSong(new Song("fantaisie impromptu", "frededric chopin", "Classical", "Assets/music/fantaisie-impromptu.mp3"));
            testAlbum.AddSong(new Song("Oof", "Onbekend", "Meme", "Assets/music/oof.mp3"));
            testAlbum.AddSong(new Song("River Flows In You", "Yiruma", "Classical", "Assets/music/River-Flows-In-You.mp3"));
            testAlbum.AddSong(new Song("Vivaldi Cello Sonata", "Vivaldi", "Classical", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            testAlbum.AddSong(new Song("Throne", "Bring Me The Horizon", "Metal", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            testAlbum.AddSong(new Song("Reaction", "Onbekend", "Electronic", "Assets/music/Reaction.mp3"));
        }

        //home paneel knoppen

        private void playButton_Click(object sender, EventArgs e)
        {
            if (activeCollection != null)
            {
                player.Play(activeCollection);
            }
            else
            {
                activeCollection = playlist;
                playlist.Reset();
                player.Play(playlist);
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (activeCollection is MusicCollection collection)
            {
                collection.RepeatEnabled = !collection.RepeatEnabled;
                repeatButton.Text = collection.RepeatEnabled ? "Aan" : "Uit";
            }
        }

        //playlist paneel knoppen
        private void playPlaylistButton_Click(object sender, EventArgs e)
        {
            activeCollection = playlist;
            playlist.Reset();
            player.Play(playlist);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (activeCollection is MusicCollection collection)
            {
                bool moved = collection.MovePrevious();
                if (moved) player.Play(activeCollection);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (activeCollection is MusicCollection collection)
            {
                player.Next();
            }
        }

        // album paneel knoppen
        private void playAlbumButton_Click(object sender, EventArgs e)
        {
            activeCollection = testAlbum;
            testAlbum.PlayAlbum(player);
        }

        private void previousAlbumButton_Click(object sender, EventArgs e)
        {
            if (activeCollection is MusicCollection collection)
            {
                player.Previous();
            }
        }

        private void nextAlbumButton_Click(object sender, EventArgs e)
        {
            if (activeCollection is MusicCollection collection)
            {
                player.Next();
            }
        }

        //navigatie knoppen
        private void homeButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            HomePannel.Visible = true;
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            PlaylistPannel.Visible = true;
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            FriendPannel.Visible = true;
        }

        private void artistButton_Click(object sender, EventArgs e)
        {
            //i.p.v een messagebox kan dit later een aparte form worden
            //MessageBox.Show(
            //    artist.ToString(),
            //    "Artist Information",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //);
            ToggleInfo();
            ArtistPannel.Visible = true;
        }

        private void albumButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            AlbumPannel.Visible = true;
        }
        private void nummersButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            NummersPannel.Visible = true;
        }
        private void verzoekenButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            VerzoekenPannel.Visible = true;
            User? currentUser = LoginService.CurrentUser;

            if (currentUser == null)
            {
                MessageBox.Show("Geen gebruiker ingelogd.");
                return;
            }

            listBox1.DataSource =
                AppData.FriendService.GetRequestsForUser(currentUser);

            listBox1.DisplayMember = "SenderName";
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            Accountpannel.Visible = true;
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            ChangeUserPannel.Visible = true;
        }


        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            lstUsers.DataSource = UserStore.Users;
            lstUsers.DisplayMember = "Username";
        }

        private void toevoegen_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstUsers.SelectedItem;

            if (selectedUser == null) return;

            User? currentUser = LoginService.CurrentUser;

            if (currentUser == null)
            {
                MessageBox.Show("Geen gebruiker ingelogd.");
                return;
            }

            AppData.FriendService.SendRequest(currentUser, selectedUser);

            MessageBox.Show($"Request gestuurd naar {selectedUser.Username}");
        }
        private void verzoekAccepteren_Click(object sender, EventArgs e)
        {
            FriendRequest request = (FriendRequest)listBox1.SelectedItem;

            if (request == null)
                return;

            AppData.FriendService.AcceptRequest(request);
            MessageBox.Show("Vriendschapsverzoek geaccepteerd.");
        }

        private void inloggen_Click(object sender, EventArgs e)
        {
            bool success = LoginService.Login(
                textBox1.Text,
                textBox2.Text);

            if (success)
            {
                MessageBox.Show($"Welkom {LoginService.CurrentUser?.Username}!");
            }
            else
            {
                MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord.");
            }
            Accountbutton.Text = LoginService.CurrentUser?.Username;
        }
        private void uitloggen_Click(object sender, EventArgs e)
        {
            LoginService.Logout();
            MessageBox.Show("Uitgelogd.");
            Accountbutton.Text = "Account";
        }
        private void ToggleInfo()
        {
            HomePannel.Visible = false;
            PlaylistPannel.Visible = false;
            FriendPannel.Visible = false;
            ArtistPannel.Visible = false;
            AlbumPannel.Visible = false;
            NummersPannel.Visible = false;
            VerzoekenPannel.Visible = false;
            ChangeUserPannel.Visible = false;
            Accountpannel.Visible = false;
        }


    }
}