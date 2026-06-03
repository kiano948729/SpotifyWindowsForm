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
        /// </summary
        private void InitializeComponent()
        {
            sidebar = new Panel();
            homeButton = new Button();
            playlistButton = new Button();
            friendsButton = new Button();
            playerBar = new Panel();
            playButton = new Button();
            pauseButton = new Button();
            stopButton = new Button();
            titleLabel = new Label();
            playlistLabel = new Label();
            playlistCard1 = new Panel();
            cardLabel1 = new Label();
            playlistCard2 = new Panel();
            cardLabel2 = new Label();
            sidebar.SuspendLayout();
            playerBar.SuspendLayout();
            playlistCard1.SuspendLayout();
            playlistCard2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(homeButton);
            sidebar.Controls.Add(playlistButton);
            sidebar.Controls.Add(friendsButton);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 600);
            sidebar.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.ForeColor = SystemColors.ButtonFace;
            homeButton.Location = new Point(20, 80);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(180, 45);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.Click += homeButton_Click;
            // 
            // playlistButton
            // 
            playlistButton.ForeColor = SystemColors.ButtonFace;
            playlistButton.Location = new Point(20, 140);
            playlistButton.Name = "playlistButton";
            playlistButton.Size = new Size(180, 45);
            playlistButton.TabIndex = 1;
            playlistButton.Text = "Playlists";
            playlistButton.Click += playlistButton_Click;
            // 
            // friendsButton
            // 
            friendsButton.ForeColor = SystemColors.ButtonFace;
            friendsButton.Location = new Point(20, 200);
            friendsButton.Name = "friendsButton";
            friendsButton.Size = new Size(180, 45);
            friendsButton.TabIndex = 2;
            friendsButton.Text = "Friends";
            friendsButton.Click += friendsButton_Click;
            // 
            // playerBar
            // 
            playerBar.BackColor = Color.Black;
            playerBar.Controls.Add(playButton);
            playerBar.Controls.Add(pauseButton);
            playerBar.Controls.Add(stopButton);
            playerBar.Location = new Point(0, 520);
            playerBar.Name = "playerBar";
            playerBar.Size = new Size(1000, 80);
            playerBar.TabIndex = 5;
            // 
            // playButton
            // 
            playButton.Image = Properties.Resources.play_icon;
            playButton.Location = new Point(420, 10);
            playButton.Name = "playButton";
            playButton.Size = new Size(60, 60);
            playButton.TabIndex = 0;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Image = Properties.Resources.pause_icon;
            pauseButton.Location = new Point(500, 10);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(60, 60);
            pauseButton.TabIndex = 1;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopButton
            // 
            stopButton.Image = Properties.Resources.stop_icon;
            stopButton.Location = new Point(580, 10);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(60, 60);
            stopButton.TabIndex = 2;
            stopButton.Click += stopButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 28F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(260, 40);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(264, 45);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Spotify Clone";
            // 
            // playlistLabel
            // 
            playlistLabel.AutoSize = true;
            playlistLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            playlistLabel.ForeColor = Color.White;
            playlistLabel.Location = new Point(270, 130);
            playlistLabel.Name = "playlistLabel";
            playlistLabel.Size = new Size(196, 29);
            playlistLabel.TabIndex = 2;
            playlistLabel.Text = "Recently Played";
            // 
            // playlistCard1
            // 
            playlistCard1.BackColor = Color.FromArgb(40, 40, 40);
            playlistCard1.Controls.Add(cardLabel1);
            playlistCard1.Location = new Point(270, 180);
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
            playlistCard2.Location = new Point(520, 180);
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
            // MainMenuForm
            // 
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1000, 600);
            Controls.Add(sidebar);
            Controls.Add(titleLabel);
            Controls.Add(playlistLabel);
            Controls.Add(playlistCard1);
            Controls.Add(playlistCard2);
            Controls.Add(playerBar);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spotify Clone";
            sidebar.ResumeLayout(false);
            playerBar.ResumeLayout(false);
            playlistCard1.ResumeLayout(false);
            playlistCard2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel sidebar;
        private Panel playerBar;

        private Label titleLabel;
        private Label playlistLabel;

        private Button homeButton;
        private Button playlistButton;
        private Button friendsButton;

        private Button playButton;
        private Button pauseButton;
        private Button stopButton;

        private Panel playlistCard1;
        private Panel playlistCard2;

        private Label cardLabel1;
        private Label cardLabel2;

        #endregion
    }
}