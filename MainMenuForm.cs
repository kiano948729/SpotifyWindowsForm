using SpotifyWindowsForm.Data;
using SpotifyWindowsForm.Models;
using SpotifyWindowsForm.Services;
using System;
using System.DirectoryServices;
using System.Windows.Forms;


namespace SpotifyWindowsForm
{
    public partial class MainMenuForm : Form
    {
        private Playlist playlist;
        private Musicplayer player;
        private Artist artist;
        private Album album1, album2, album3, album4;
        private Song testSong;
        public MainMenuForm()
        {
            InitializeComponent();

            player = new Musicplayer();
            playlist = new Playlist("Test playlist");
            album1 = new Album("testalbum-1", "dit is een test album");
            album2 = new Album("testalbum-2", "dit is een test album");
            album3 = new Album("testalbum-3", "dit is een test album");
            album4 = new Album("testalbum-4", "dit is een test album");
            SeedTestData();
            ToggleInfo();
            HomePannel.Visible = true;
            //string users = string.Join(
            //    Environment.NewLine,
            //    UserStore.Users.Select(u => u.Username));

            //MessageBox.Show(users);
        }

        private void SeedTestData()
        {
            testSong = new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3");

            Song song2 = new Song("Song 2", "Artist 1", "Pop", "Assets/music/oof.mp3");

            playlist.AddSong(testSong);
            playlist.AddSong(song2);

            artist = new Artist("Artist 1", "Test artiest voor Spotify");

            album1.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album1.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            album1.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album1.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));

            album2.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album2.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album2.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album2.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));

            album3.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album3.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album3.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));
            album3.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));

            album4.AddSong(new Song("Song 1", "Artist 1", "Pop", "Assets/music/Vivaldi-Cello-Sonata.mp3"));
            album4.AddSong(new Song("Song 2", "Artist 1", "Pop", "Assets/music/River-Flows-In-You.mp3"));
            album4.AddSong(new Song("Song 3", "Artist 1", "Pop", "Assets/music/Bring-Me-The-Horizon-Throne.mp3"));
            album4.AddSong(new Song("Song 4", "Artist 1", "Pop", "Assets/music/rickroll.mp3"));

        }


        private void playButton_Click(object sender, EventArgs e)
        {
            player.Play(testSong);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            playlist.SkipSong(player);
        }

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
            User currentUser = UserStore.Users.First();

            listBox1.DataSource =
                AppData.FriendService.GetRequestsForUser(currentUser);

            listBox1.DisplayMember = "Sender.Username";

        }
        private void changeUserButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            ChangeUserPannel.Visible = true;
            authenticationService LoginTest = new authenticationService();
            LoginTest.AuthenticationService("name", "password");
            // hier moet nog een formulier bij komen om username+password door te sturen naar auth.service

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

        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            User currentUser = UserStore.Users.First();

            AppData.FriendService.SendRequest(currentUser, selectedUser);

            MessageBox.Show($"Request gestuurd naar {selectedUser.Username}");
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
        }
        private void uitloggen_Click(object sender, EventArgs e)
        {
            LoginService.Logout();
            MessageBox.Show("Uitgelogd.");
        }
    }
}