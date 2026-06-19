using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;
using System.Drawing;
using System.Windows.Forms;

namespace SpotifyWindowsForm
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebar = new Panel();
            verzoekenButton = new Button();
            changeUserButton = new Button();
            albumsButton = new Button();
            nummersButton = new Button();
            artistButton = new Button();
            homeButton = new Button();
            playlistButton = new Button();
            friendsButton = new Button();
            Accountbutton = new Button();
            playButton = new Button();
            pauseButton = new Button();
            stopButton = new Button();
            repeatButton = new Button();
            titleLabel = new Label();
            playlistLabel = new Label();
            playlistCard1 = new Panel();
            cardLabel1 = new Label();
            playlistCard2 = new Panel();
            cardLabel2 = new Label();
            HomePannel = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            PlaylistPannel = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label1 = new Label();
            PlaylistField = new FlowLayoutPanel();
            ButtonBarPlaylistPannel = new FlowLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            FriendPannel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            lstUsers = new ListBox();
            toevoegen = new Button();
            ArtistPannel = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            AlbumPannel = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label5 = new Label();
            flowLayoutPanel11 = new FlowLayoutPanel();
            flowLayoutPanel12 = new FlowLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            NummersPannel = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label4 = new Label();
            NummersDisplayfield = new FlowLayoutPanel();
            flowLayoutPanel13 = new FlowLayoutPanel();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            VerzoekenPannel = new FlowLayoutPanel();
            flowLayoutPanel14 = new FlowLayoutPanel();
            label6 = new Label();
            flowLayoutPanel15 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            button12 = new Button();
            button13 = new Button();
            ChangeUserPannel = new FlowLayoutPanel();
            flowLayoutPanel16 = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            wachtwoordlabel = new Label();
            textBox2 = new TextBox();
            inloggen = new Button();
            uitloggen = new Button();
            Accountpannel = new FlowLayoutPanel();
            flowLayoutPanel18 = new FlowLayoutPanel();
            label9 = new Label();
            flowLayoutPanel19 = new FlowLayoutPanel();
            sidebar.SuspendLayout();
            playlistCard1.SuspendLayout();
            playlistCard2.SuspendLayout();
            HomePannel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            PlaylistPannel.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ButtonBarPlaylistPannel.SuspendLayout();
            FriendPannel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ArtistPannel.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            AlbumPannel.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            NummersPannel.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel13.SuspendLayout();
            VerzoekenPannel.SuspendLayout();
            flowLayoutPanel14.SuspendLayout();
            flowLayoutPanel15.SuspendLayout();
            ChangeUserPannel.SuspendLayout();
            flowLayoutPanel16.SuspendLayout();
            Accountpannel.SuspendLayout();
            flowLayoutPanel18.SuspendLayout();
            flowLayoutPanel19.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(verzoekenButton);
            sidebar.Controls.Add(changeUserButton);
            sidebar.Controls.Add(albumsButton);
            sidebar.Controls.Add(nummersButton);
            sidebar.Controls.Add(artistButton);
            sidebar.Controls.Add(homeButton);
            sidebar.Controls.Add(playlistButton);
            sidebar.Controls.Add(friendsButton);
            sidebar.Controls.Add(Accountbutton);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 600);
            sidebar.TabIndex = 0;
            // 
            // verzoekenButton
            // 
            verzoekenButton.ForeColor = SystemColors.ButtonFace;
            verzoekenButton.Location = new Point(23, 379);
            verzoekenButton.Name = "verzoekenButton";
            verzoekenButton.Size = new Size(180, 45);
            verzoekenButton.TabIndex = 7;
            verzoekenButton.Text = "Verzoeken";
            verzoekenButton.Click += verzoekenButton_Click;
            // 
            // changeUserButton
            // 
            changeUserButton.ForeColor = SystemColors.ButtonFace;
            changeUserButton.Location = new Point(23, 543);
            changeUserButton.Name = "changeUserButton";
            changeUserButton.Size = new Size(180, 45);
            changeUserButton.TabIndex = 6;
            changeUserButton.Text = "ChangeUser";
            changeUserButton.Click += changeUserButton_Click;
            // 
            // albumsButton
            // 
            albumsButton.ForeColor = SystemColors.ButtonFace;
            albumsButton.Location = new Point(23, 260);
            albumsButton.Name = "albumsButton";
            albumsButton.Size = new Size(180, 45);
            albumsButton.TabIndex = 5;
            albumsButton.Text = "Albums";
            albumsButton.Click += albumButton_Click;
            // 
            // nummersButton
            // 
            nummersButton.ForeColor = SystemColors.ButtonFace;
            nummersButton.Location = new Point(23, 318);
            nummersButton.Name = "nummersButton";
            nummersButton.Size = new Size(180, 45);
            nummersButton.TabIndex = 4;
            nummersButton.Text = "Nummers";
            nummersButton.Click += nummersButton_Click;
            // 
            // artistButton
            // 
            artistButton.ForeColor = SystemColors.ButtonFace;
            artistButton.Location = new Point(23, 202);
            artistButton.Name = "artistButton";
            artistButton.Size = new Size(180, 45);
            artistButton.TabIndex = 3;
            artistButton.Text = "Artists";
            artistButton.Click += artistButton_Click;
            // 
            // homeButton
            // 
            homeButton.ForeColor = SystemColors.ButtonFace;
            homeButton.Location = new Point(23, 22);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(180, 45);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.Click += homeButton_Click;
            // 
            // playlistButton
            // 
            playlistButton.ForeColor = SystemColors.ButtonFace;
            playlistButton.Location = new Point(23, 82);
            playlistButton.Name = "playlistButton";
            playlistButton.Size = new Size(180, 45);
            playlistButton.TabIndex = 1;
            playlistButton.Text = "Playlists";
            playlistButton.Click += playlistButton_Click;
            // 
            // friendsButton
            // 
            friendsButton.ForeColor = SystemColors.ButtonFace;
            friendsButton.Location = new Point(23, 142);
            friendsButton.Name = "friendsButton";
            friendsButton.Size = new Size(180, 45);
            friendsButton.TabIndex = 2;
            friendsButton.Text = "Friends";
            friendsButton.Click += friendsButton_Click;
            // 
            // Accountbutton
            // 
            Accountbutton.ForeColor = SystemColors.ButtonFace;
            Accountbutton.Location = new Point(23, 438);
            Accountbutton.Name = "Accountbutton";
            Accountbutton.Size = new Size(180, 45);
            Accountbutton.TabIndex = 8;
            Accountbutton.Text = "account";
            Accountbutton.Click += AccountButton_Click;
            // 
            // playButton
            // 
            playButton.Image = Properties.Resources.play_icon;
            playButton.Location = new Point(3, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(60, 60);
            playButton.TabIndex = 0;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Image = Properties.Resources.pause_icon;
            pauseButton.Location = new Point(69, 3);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(60, 60);
            pauseButton.TabIndex = 1;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopButton
            // 
            stopButton.Image = Properties.Resources.stop_icon;
            stopButton.Location = new Point(135, 3);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(60, 60);
            stopButton.TabIndex = 2;
            stopButton.Click += stopButton_Click;
            // 
            // repeatButton
            // 
            repeatButton.Location = new Point(201, 3);
            repeatButton.Name = "repeatButton";
            repeatButton.Size = new Size(70, 60);
            repeatButton.TabIndex = 3;
            repeatButton.Text = "Uit";
            repeatButton.Click += repeatButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 28F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(388, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Spotify Clone";
            // 
            // playlistLabel
            // 
            playlistLabel.AutoSize = true;
            playlistLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            playlistLabel.ForeColor = Color.White;
            playlistLabel.Location = new Point(3, 156);
            playlistLabel.Name = "playlistLabel";
            playlistLabel.Size = new Size(293, 43);
            playlistLabel.TabIndex = 2;
            playlistLabel.Text = "Recently Played";
            // 
            // playlistCard1
            // 
            playlistCard1.BackColor = Color.FromArgb(40, 40, 40);
            playlistCard1.Controls.Add(cardLabel1);
            playlistCard1.Location = new Point(3, 3);
            playlistCard1.Name = "playlistCard1";
            playlistCard1.Size = new Size(220, 220);
            playlistCard1.TabIndex = 3;
            // 
            // cardLabel1
            // 
            cardLabel1.ForeColor = Color.White;
            cardLabel1.Location = new Point(60, 160);
            cardLabel1.Name = "cardLabel1";
            cardLabel1.Size = new Size(100, 23);
            cardLabel1.TabIndex = 0;
            cardLabel1.Text = "Top Hits";
            // 
            // playlistCard2
            // 
            playlistCard2.BackColor = Color.FromArgb(40, 40, 40);
            playlistCard2.Controls.Add(cardLabel2);
            playlistCard2.Location = new Point(229, 3);
            playlistCard2.Name = "playlistCard2";
            playlistCard2.Size = new Size(220, 220);
            playlistCard2.TabIndex = 4;
            // 
            // cardLabel2
            // 
            cardLabel2.ForeColor = Color.White;
            cardLabel2.Location = new Point(60, 160);
            cardLabel2.Name = "cardLabel2";
            cardLabel2.Size = new Size(100, 23);
            cardLabel2.TabIndex = 0;
            cardLabel2.Text = "Chill Mix";
            // 
            // HomePannel
            // 
            HomePannel.Controls.Add(flowLayoutPanel2);
            HomePannel.Controls.Add(playlistLabel);
            HomePannel.Controls.Add(flowLayoutPanel3);
            HomePannel.Controls.Add(flowLayoutPanel4);
            HomePannel.Location = new Point(226, 0);
            HomePannel.Name = "HomePannel";
            HomePannel.Size = new Size(771, 600);
            HomePannel.TabIndex = 8;
            HomePannel.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(titleLabel);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(768, 150);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(playlistCard1);
            flowLayoutPanel3.Controls.Add(playlistCard2);
            flowLayoutPanel3.Location = new Point(3, 202);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(533, 275);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(playButton);
            flowLayoutPanel4.Controls.Add(pauseButton);
            flowLayoutPanel4.Controls.Add(stopButton);
            flowLayoutPanel4.Controls.Add(repeatButton);
            flowLayoutPanel4.Location = new Point(3, 483);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(768, 117);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // PlaylistPannel
            // 
            PlaylistPannel.Controls.Add(flowLayoutPanel5);
            PlaylistPannel.Controls.Add(PlaylistField);
            PlaylistPannel.Controls.Add(ButtonBarPlaylistPannel);
            PlaylistPannel.Location = new Point(223, 3);
            PlaylistPannel.Name = "PlaylistPannel";
            PlaylistPannel.Size = new Size(783, 597);
            PlaylistPannel.TabIndex = 8;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label1);
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(771, 61);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Playlists";
            // 
            // PlaylistField
            // 
            PlaylistField.Location = new Point(3, 70);
            PlaylistField.Name = "PlaylistField";
            PlaylistField.Size = new Size(771, 407);
            PlaylistField.TabIndex = 1;
            // 
            // ButtonBarPlaylistPannel
            // 
            ButtonBarPlaylistPannel.Controls.Add(button3);
            ButtonBarPlaylistPannel.Controls.Add(button2);
            ButtonBarPlaylistPannel.Controls.Add(button1);
            ButtonBarPlaylistPannel.Location = new Point(3, 483);
            ButtonBarPlaylistPannel.Name = "ButtonBarPlaylistPannel";
            ButtonBarPlaylistPannel.Size = new Size(771, 114);
            ButtonBarPlaylistPannel.TabIndex = 0;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.play_icon;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.Click += playPlaylistButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 3);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 3;
            button2.Text = "Vorige";
            button2.Click += previousButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(135, 3);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 3;
            button1.Text = "Volgende";
            button1.Click += nextButton_Click;
            // 
            // FriendPannel
            // 
            FriendPannel.Controls.Add(flowLayoutPanel1);
            FriendPannel.Controls.Add(flowLayoutPanel6);
            FriendPannel.Location = new Point(223, 0);
            FriendPannel.Name = "FriendPannel";
            FriendPannel.Size = new Size(774, 597);
            FriendPannel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(771, 80);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "Friends";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(lstUsers);
            flowLayoutPanel6.Controls.Add(toevoegen);
            flowLayoutPanel6.Location = new Point(3, 89);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(771, 499);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 25;
            lstUsers.Location = new Point(3, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(780, 304);
            lstUsers.TabIndex = 6;
            // 
            // toevoegen
            // 
            toevoegen.Location = new Point(3, 313);
            toevoegen.Name = "toevoegen";
            toevoegen.Size = new Size(226, 34);
            toevoegen.TabIndex = 7;
            toevoegen.Text = "toevoegen_vriend";
            toevoegen.UseVisualStyleBackColor = true;
            toevoegen.Click += toevoegen_Click;
            // 
            // ArtistPannel
            // 
            ArtistPannel.Controls.Add(flowLayoutPanel10);
            ArtistPannel.Controls.Add(flowLayoutPanel8);
            ArtistPannel.Location = new Point(223, 0);
            ArtistPannel.Name = "ArtistPannel";
            ArtistPannel.Size = new Size(774, 597);
            ArtistPannel.TabIndex = 2;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(label3);
            flowLayoutPanel10.Location = new Point(3, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(771, 80);
            flowLayoutPanel10.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 0;
            label3.Text = "Artists";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Location = new Point(3, 89);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(771, 499);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // AlbumPannel
            // 
            AlbumPannel.Controls.Add(flowLayoutPanel9);
            AlbumPannel.Controls.Add(flowLayoutPanel11);
            AlbumPannel.Controls.Add(flowLayoutPanel12);
            AlbumPannel.Location = new Point(223, 0);
            AlbumPannel.Name = "AlbumPannel";
            AlbumPannel.Size = new Size(774, 600);
            AlbumPannel.TabIndex = 9;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(label5);
            flowLayoutPanel9.Location = new Point(3, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(771, 65);
            flowLayoutPanel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 0;
            label5.Text = "Albums";
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Location = new Point(3, 74);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(768, 456);
            flowLayoutPanel11.TabIndex = 1;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Controls.Add(button6);
            flowLayoutPanel12.Controls.Add(button7);
            flowLayoutPanel12.Controls.Add(button8);
            flowLayoutPanel12.Location = new Point(3, 536);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(768, 61);
            flowLayoutPanel12.TabIndex = 0;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.play_icon;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 4;
            button6.Click += playAlbumButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(69, 3);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 5;
            button7.Text = "Vorige";
            button7.Click += previousAlbumButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(135, 3);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 6;
            button8.Text = "Volgende";
            button8.Click += nextAlbumButton_Click;
            // 
            // NummersPannel
            // 
            NummersPannel.Controls.Add(flowLayoutPanel7);
            NummersPannel.Controls.Add(NummersDisplayfield);
            NummersPannel.Controls.Add(flowLayoutPanel13);
            NummersPannel.Location = new Point(223, 0);
            NummersPannel.Name = "NummersPannel";
            NummersPannel.Size = new Size(774, 600);
            NummersPannel.TabIndex = 10;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label4);
            flowLayoutPanel7.Location = new Point(3, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(768, 80);
            flowLayoutPanel7.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 0;
            label4.Text = "Nummers";
            // 
            // NummersDisplayfield
            // 
            NummersDisplayfield.Location = new Point(3, 89);
            NummersDisplayfield.Name = "NummersDisplayfield";
            NummersDisplayfield.Size = new Size(771, 430);
            NummersDisplayfield.TabIndex = 4;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Controls.Add(button9);
            flowLayoutPanel13.Controls.Add(button10);
            flowLayoutPanel13.Controls.Add(button11);
            flowLayoutPanel13.Location = new Point(3, 525);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(771, 74);
            flowLayoutPanel13.TabIndex = 3;
            // 
            // button9
            // 
            button9.Image = Properties.Resources.play_icon;
            button9.Location = new Point(3, 3);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 3;
            // 
            // button10
            // 
            button10.Image = Properties.Resources.pause_icon;
            button10.Location = new Point(69, 3);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 3;
            // 
            // button11
            // 
            button11.Image = Properties.Resources.stop_icon;
            button11.Location = new Point(135, 3);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 3;
            // 
            // VerzoekenPannel
            // 
            VerzoekenPannel.Controls.Add(flowLayoutPanel14);
            VerzoekenPannel.Controls.Add(flowLayoutPanel15);
            VerzoekenPannel.Location = new Point(223, 0);
            VerzoekenPannel.Name = "VerzoekenPannel";
            VerzoekenPannel.Size = new Size(774, 599);
            VerzoekenPannel.TabIndex = 11;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.Controls.Add(label6);
            flowLayoutPanel14.Location = new Point(3, 3);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(768, 80);
            flowLayoutPanel14.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 0;
            label6.Text = "Vriendschaps-verzoeken";
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.Controls.Add(listBox1);
            flowLayoutPanel15.Controls.Add(button12);
            flowLayoutPanel15.Controls.Add(button13);
            flowLayoutPanel15.Location = new Point(3, 89);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(771, 511);
            flowLayoutPanel15.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(780, 404);
            listBox1.TabIndex = 7;
            // 
            // button12
            // 
            button12.Location = new Point(3, 413);
            button12.Name = "button12";
            button12.Size = new Size(112, 34);
            button12.TabIndex = 0;
            button12.Text = "accepteren";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(121, 413);
            button13.Name = "button13";
            button13.Size = new Size(112, 34);
            button13.TabIndex = 1;
            button13.Text = "weigeren";
            button13.UseVisualStyleBackColor = true;
            // 
            // ChangeUserPannel
            // 
            ChangeUserPannel.Controls.Add(flowLayoutPanel16);
            ChangeUserPannel.Location = new Point(223, 0);
            ChangeUserPannel.Name = "ChangeUserPannel";
            ChangeUserPannel.Size = new Size(774, 597);
            ChangeUserPannel.TabIndex = 12;
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.Controls.Add(label7);
            flowLayoutPanel16.Location = new Point(3, 3);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new Size(768, 80);
            flowLayoutPanel16.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 25);
            label7.TabIndex = 0;
            label7.Text = "verander van gebruiker";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 11;
            label8.Text = "log in met gebruiker:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(771, 31);
            textBox1.TabIndex = 9;
            // 
            // wachtwoordlabel
            // 
            wachtwoordlabel.AutoSize = true;
            wachtwoordlabel.ForeColor = Color.White;
            wachtwoordlabel.Location = new Point(3, 62);
            wachtwoordlabel.Name = "wachtwoordlabel";
            wachtwoordlabel.Size = new Size(114, 25);
            wachtwoordlabel.TabIndex = 12;
            wachtwoordlabel.Text = "wachtwoord:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(780, 31);
            textBox2.TabIndex = 10;
            // 
            // inloggen
            // 
            inloggen.Location = new Point(3, 127);
            inloggen.Name = "inloggen";
            inloggen.Size = new Size(226, 34);
            inloggen.TabIndex = 5;
            inloggen.Text = "inloggen";
            inloggen.UseVisualStyleBackColor = true;
            inloggen.Click += inloggen_Click;
            // 
            // uitloggen
            // 
            uitloggen.Location = new Point(235, 127);
            uitloggen.Name = "uitloggen";
            uitloggen.Size = new Size(226, 34);
            uitloggen.TabIndex = 8;
            uitloggen.Text = "uitloggen";
            uitloggen.UseVisualStyleBackColor = true;
            uitloggen.Click += uitloggen_Click;
            // 
            // Accountpannel
            // 
            Accountpannel.Controls.Add(flowLayoutPanel18);
            Accountpannel.Controls.Add(flowLayoutPanel19);
            Accountpannel.Location = new Point(223, 0);
            Accountpannel.Name = "Accountpannel";
            Accountpannel.Size = new Size(774, 597);
            Accountpannel.TabIndex = 13;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.Controls.Add(label9);
            flowLayoutPanel18.Location = new Point(3, 3);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new Size(771, 80);
            flowLayoutPanel18.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(134, 25);
            label9.TabIndex = 0;
            label9.Text = "in of uit loggen";
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.Controls.Add(label8);
            flowLayoutPanel19.Controls.Add(textBox1);
            flowLayoutPanel19.Controls.Add(wachtwoordlabel);
            flowLayoutPanel19.Controls.Add(textBox2);
            flowLayoutPanel19.Controls.Add(inloggen);
            flowLayoutPanel19.Controls.Add(uitloggen);
            flowLayoutPanel19.Location = new Point(3, 89);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(771, 499);
            flowLayoutPanel19.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1000, 600);
            Controls.Add(Accountpannel);
            Controls.Add(ChangeUserPannel);
            Controls.Add(VerzoekenPannel);
            Controls.Add(NummersPannel);
            Controls.Add(AlbumPannel);
            Controls.Add(ArtistPannel);
            Controls.Add(FriendPannel);
            Controls.Add(PlaylistPannel);
            Controls.Add(HomePannel);
            Controls.Add(sidebar);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spotify Clone";
            Load += MainMenuForm_Load;
            sidebar.ResumeLayout(false);
            playlistCard1.ResumeLayout(false);
            playlistCard2.ResumeLayout(false);
            HomePannel.ResumeLayout(false);
            HomePannel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            PlaylistPannel.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ButtonBarPlaylistPannel.ResumeLayout(false);
            FriendPannel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            ArtistPannel.ResumeLayout(false);
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            AlbumPannel.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            NummersPannel.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel13.ResumeLayout(false);
            VerzoekenPannel.ResumeLayout(false);
            flowLayoutPanel14.ResumeLayout(false);
            flowLayoutPanel14.PerformLayout();
            flowLayoutPanel15.ResumeLayout(false);
            ChangeUserPannel.ResumeLayout(false);
            flowLayoutPanel16.ResumeLayout(false);
            flowLayoutPanel16.PerformLayout();
            Accountpannel.ResumeLayout(false);
            flowLayoutPanel18.ResumeLayout(false);
            flowLayoutPanel18.PerformLayout();
            flowLayoutPanel19.ResumeLayout(false);
            flowLayoutPanel19.PerformLayout();
            ResumeLayout(false);
        }

        private Panel sidebar;

        private Label titleLabel;
        private Label playlistLabel;

        private Button homeButton;
        private Button playlistButton;
        private Button friendsButton;

        private Button playButton;
        private Button pauseButton;
        private Button stopButton;
        private Button repeatButton;

        private Panel playlistCard1;
        private Panel playlistCard2;

        private Label cardLabel1;
        private Label cardLabel2;

        #endregion

        private Button artistButton;
        private Button albumsButton;
        private Button nummersButton;
        private Button changeUserButton;
        private Button verzoekenButton;
        private FlowLayoutPanel HomePannel;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel PlaylistPannel;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label1;
        private FlowLayoutPanel PlaylistField;
        private FlowLayoutPanel ButtonBarPlaylistPannel;
        private Button button3;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel FriendPannel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel ArtistPannel;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel AlbumPannel;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private Button button6;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel NummersPannel;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel13;
        private Button button9;
        private Button button10;
        private Button button11;
        private FlowLayoutPanel NummersDisplayfield;
        private FlowLayoutPanel VerzoekenPannel;
        private FlowLayoutPanel flowLayoutPanel14;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel15;
        private Button button12;
        private Button button13;
        private FlowLayoutPanel ChangeUserPannel;
        private FlowLayoutPanel flowLayoutPanel16;
        private Label label7;
        private Button inloggen;
        private ListBox lstUsers;
        private Button toevoegen;
        private ListBox listBox1;
        private Button uitloggen;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label8;
        private Label wachtwoordlabel;
        private Button Accountbutton;
        private FlowLayoutPanel Accountpannel;
        private FlowLayoutPanel flowLayoutPanel18;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel19;
    }
}