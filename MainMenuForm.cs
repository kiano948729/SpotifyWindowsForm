using System;
using System.Diagnostics;
using System.Windows.Forms;
using SpotifyWindowsForm.Models;

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
                bool moved = collection.MovePrevious();
                if (moved) player.Previous();
            }
        }

        private void nextAlbumButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"ActiveCollection: {activeCollection?.GetType().Name}");
            if (activeCollection is MusicCollection collection)
            {
                bool moved = collection.MoveNext();
                if (moved) player.Next();
                else player.Stop();
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
        }
        private void changeUserButton_Click(object sender, EventArgs e)
        {
            ToggleInfo();
            ChangeUserPannel.Visible = true;
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
    }
}