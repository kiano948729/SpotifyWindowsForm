namespace SpotifyWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(2, 380);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(795, 69);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 66);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPlay_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 66);
            button2.TabIndex = 1;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnPause_Click;
            // 
            // button3
            // 
            button3.Location = new Point(239, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 66);
            button3.TabIndex = 2;
            button3.Text = "Skip";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(357, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 66);
            button4.TabIndex = 3;
            button4.Text = "Stop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
