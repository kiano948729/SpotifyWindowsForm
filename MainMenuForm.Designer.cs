using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;

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
            homeButton.BackColor = Color.Black;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            homeButton.ForeColor = Color.White;
            homeButton.Location = new Point(20, 80);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(180, 45);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // playlistButton
            // 
            playlistButton.BackColor = Color.Black;
            playlistButton.FlatAppearance.BorderSize = 0;
            playlistButton.FlatStyle = FlatStyle.Flat;
            playlistButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            playlistButton.ForeColor = Color.White;
            playlistButton.Location = new Point(20, 140);
            playlistButton.Name = "playlistButton";
            playlistButton.Size = new Size(180, 45);
            playlistButton.TabIndex = 1;
            playlistButton.Text = "Playlists";
            playlistButton.UseVisualStyleBackColor = false;
            playlistButton.Click += playlistButton_Click;
            // 
            // friendsButton
            // 
            friendsButton.BackColor = Color.Black;
            friendsButton.FlatAppearance.BorderSize = 0;
            friendsButton.FlatStyle = FlatStyle.Flat;
            friendsButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            friendsButton.ForeColor = Color.White;
            friendsButton.Location = new Point(20, 200);
            friendsButton.Name = "friendsButton";
            friendsButton.Size = new Size(180, 45);
            friendsButton.TabIndex = 2;
            friendsButton.Text = "Friends";
            friendsButton.UseVisualStyleBackColor = false;
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
            playButton.BackColor = Color.FromArgb(30, 215, 96);
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Arial", 18F, FontStyle.Bold);
            playButton.ForeColor = Color.White;
            playButton.ImageAlign = ContentAlignment.MiddleCenter;
            playButton.TextImageRelation = TextImageRelation.ImageAboveText;
            playButton.Text = "";
            playButton.Image = Properties.Resources.play_icon;
            playButton.Location = new Point(420, 10);
            playButton.Name = "playButton";
            playButton.Size = new Size(60, 60);
            playButton.TabIndex = 0;
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.FromArgb(40, 40, 40);
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Font = new Font("Arial", 18F, FontStyle.Bold);
            pauseButton.ForeColor = Color.White;
            playButton.ImageAlign = ContentAlignment.MiddleCenter;
            playButton.TextImageRelation = TextImageRelation.ImageAboveText;
            playButton.Text = "";
            pauseButton.Image = Properties.Resources.pause_icon;
            pauseButton.Location = new Point(500, 10);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(60, 60);
            pauseButton.TabIndex = 1;
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.FromArgb(40, 40, 40);
            stopButton.FlatAppearance.BorderSize = 0;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Arial", 18F, FontStyle.Bold);
            stopButton.ForeColor = Color.White;
            playButton.ImageAlign = ContentAlignment.MiddleCenter;
            playButton.TextImageRelation = TextImageRelation.ImageAboveText;
            playButton.Text = "";
            stopButton.Image = Properties.Resources.stop_icon;
            stopButton.Location = new Point(580, 10);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(60, 60);
            stopButton.TabIndex = 2;
            stopButton.UseVisualStyleBackColor = false;
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
            titleLabel.Click += titleLabel_Click;
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
            playlistLabel.Click += playlistLabel_Click;
            // 
            // playlistCard1
            // 
            playlistCard1.BackColor = Color.FromArgb(40, 40, 40);
            playlistCard1.Controls.Add(cardLabel1);
            playlistCard1.Location = new Point(270, 180);
            playlistCard1.Name = "playlistCard1";
            playlistCard1.Size = new Size(220, 220);
            playlistCard1.TabIndex = 3;
            playlistCard1.Paint += playlistCard1_Paint;
            // 
            // cardLabel1
            // 
            cardLabel1.AutoSize = true;
            cardLabel1.Font = new Font("Arial", 16F, FontStyle.Bold);
            cardLabel1.ForeColor = Color.White;
            cardLabel1.Location = new Point(60, 160);
            cardLabel1.Name = "cardLabel1";
            cardLabel1.Size = new Size(97, 26);
            cardLabel1.TabIndex = 0;
            cardLabel1.Text = "Top Hits";
            // 
            // playlistCard2
            // 
            playlistCard2.BackColor = Color.FromArgb(40, 40, 40);
            playlistCard2.Controls.Add(cardLabel2);
            playlistCard2.Location = new Point(540, 180);
            playlistCard2.Name = "playlistCard2";
            playlistCard2.Size = new Size(220, 220);
            playlistCard2.TabIndex = 4;
            playlistCard2.Paint += playlistCard2_Paint;
            // 
            // cardLabel2
            // 
            cardLabel2.AutoSize = true;
            cardLabel2.Font = new Font("Arial", 16F, FontStyle.Bold);
            cardLabel2.ForeColor = Color.White;
            cardLabel2.Location = new Point(60, 160);
            cardLabel2.Name = "cardLabel2";
            cardLabel2.Size = new Size(96, 26);
            cardLabel2.TabIndex = 0;
            cardLabel2.Text = "Chill Mix";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            playlistCard1.PerformLayout();
            playlistCard2.ResumeLayout(false);
            playlistCard2.PerformLayout();
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