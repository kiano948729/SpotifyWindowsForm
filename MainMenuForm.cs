using SpotifyWindowsForm.Data;
using System;
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

        private void PopulateArtists(List<Artist> artists)
        {
            //panel clearen voor de nieuwe data
            flowLayoutPanel8.Controls.Clear();

            flowLayoutPanel8.Visible = true;
            ArtistDetailPanel.Visible = false;

            foreach (Artist artist in artists)
            {
                //voor iedere artiest wordt een nieuwe button gemaakt
                Button btn = CreateStyledButton(artist.Name, 250, 50);
                btn.Tag = artist;

                //click event wordt uitgevoerd
                btn.Click += (s, e) =>
                {
                    Artist selected = (Artist)((Button)s).Tag;
                    ShowArtistDetail(selected);
                };

                flowLayoutPanel8.Controls.Add(btn);
            }
        }

        private void ShowArtistDetail(Artist artist)
        {
            ArtistDetailPanel.Controls.Clear();

            //terugknop naar de lijst
            Button backBtn = CreateStyledButton("<- Terug naar artiesten", 220, 40);
            backBtn.Click += (s, e) =>
            {
                ArtistDetailPanel.Visible = false;
                flowLayoutPanel8.Visible = true;
            };
            ArtistDetailPanel.Controls.Add(backBtn);

            Label nameLabel = new Label();
            nameLabel.Text = artist.Name;
            nameLabel.Font = new Font(Font.FontFamily, 16, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.AutoSize = true;
            nameLabel.Margin = new Padding(3, 15, 3, 3);
            ArtistDetailPanel.Controls.Add(nameLabel);

            Label descLabel = new Label();
            descLabel.Text = artist.Description;
            descLabel.ForeColor = Color.Gainsboro;
            descLabel.AutoSize = true;
            descLabel.Margin = new Padding(3, 0, 3, 15);
            ArtistDetailPanel.Controls.Add(descLabel);

            if (artist.GetAlbums().Count > 0)
            {
                Label albumsHeader = new Label();
                albumsHeader.Text = "Albums";
                albumsHeader.ForeColor = Color.White;
                albumsHeader.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
                albumsHeader.AutoSize = true;
                ArtistDetailPanel.Controls.Add(albumsHeader);

                foreach (Album album in artist.GetAlbums())
                {
                    Button albumBtn = CreateStyledButton(album.Name, 250, 40);
                    albumBtn.Tag = album;
                    albumBtn.Click += (s, e) =>
                    {
                        Album selected = (Album)((Button)s).Tag;
                        activeCollection = selected;
                        selected.PlayAlbum(player);
                    };
                    ArtistDetailPanel.Controls.Add(albumBtn);
                }
            }

            if (artist.GetSongs().Count > 0)
            {
                Label songsHeader = new Label();
                songsHeader.Text = "Nummers";
                songsHeader.ForeColor = Color.White;
                songsHeader.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
                songsHeader.AutoSize = true;
                songsHeader.Margin = new Padding(3, 15, 3, 3);
                ArtistDetailPanel.Controls.Add(songsHeader);

                foreach (Song song in artist.GetSongs())
                {
                    Button songBtn = CreateStyledButton(song.Title, 250, 40);
                    songBtn.Tag = song;
                    songBtn.Click += (s, e) =>
                    {
                        Song selected = (Song)((Button)s).Tag;

                        Playlist tempPlaylist = new Playlist(selected.Title);
                        tempPlaylist.AddSong(selected);

                        activeCollection = tempPlaylist;
                        player.Play(tempPlaylist);
                    };
                    ArtistDetailPanel.Controls.Add(songBtn);
                }
            }

            flowLayoutPanel8.Visible = false;
            ArtistDetailPanel.Visible = true;
        }
        private Button CreateStyledButton(string text, int width, int height)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Width = width;
            btn.Height = height;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(40, 40, 40);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
            return btn;
        }

        private void PopulateAlbums(List<Album> albums)
        {
            flowLayoutPanel11.Controls.Clear();

            foreach (Album album in albums)
            {
                Button btn = CreateStyledButton(album.Name, 250, 50);
                btn.Tag = album;

                btn.Click += (s, e) =>
                {
                    Album selected = (Album)((Button)s).Tag;
                    activeCollection = selected;
                    selected.PlayAlbum(player);
                };

                flowLayoutPanel11.Controls.Add(btn);
            }
        }

        private void PopulateSongs(List<Song> songs)
        {
            NummersDisplayfield.Controls.Clear();

            foreach (Song song in songs)
            {
                Button btn = CreateStyledButton($"{song.Title} - {song.Artist}", 320, 40);
                btn.Tag = song;

                btn.Click += (s, e) =>
                {
                    Song selected = (Song)((Button)s).Tag;

                    Playlist tempPlaylist = new Playlist(selected.Title);
                    tempPlaylist.AddSong(selected);

                    activeCollection = tempPlaylist;
                    player.Play(tempPlaylist);
                };

                NummersDisplayfield.Controls.Add(btn);
            }
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
            PopulateArtists(MusicStore.Artists);
        }

        private void albumButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            AlbumPannel.Visible = true;
            PopulateAlbums(MusicStore.Albums);
        }
        private void nummersButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            NummersPannel.Visible = true;
            PopulateSongs(MusicStore.Songs);
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