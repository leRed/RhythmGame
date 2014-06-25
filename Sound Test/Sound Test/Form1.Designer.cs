namespace Sound_Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Filepath = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackbar_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackbar_maxTime = new System.Windows.Forms.Label();
            this.audio_filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filepath
            // 
            this.Filepath.Location = new System.Drawing.Point(74, 55);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(276, 20);
            this.Filepath.TabIndex = 1;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(115, 95);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(195, 95);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(275, 95);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path: ";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(35, 95);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 6;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(62, 200);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(297, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackbar_time
            // 
            this.trackbar_time.AutoSize = true;
            this.trackbar_time.Location = new System.Drawing.Point(13, 202);
            this.trackbar_time.Name = "trackbar_time";
            this.trackbar_time.Size = new System.Drawing.Size(49, 13);
            this.trackbar_time.TabIndex = 9;
            this.trackbar_time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackbar_maxTime
            // 
            this.trackbar_maxTime.AutoSize = true;
            this.trackbar_maxTime.Location = new System.Drawing.Point(358, 202);
            this.trackbar_maxTime.Name = "trackbar_maxTime";
            this.trackbar_maxTime.Size = new System.Drawing.Size(49, 13);
            this.trackbar_maxTime.TabIndex = 10;
            this.trackbar_maxTime.Text = "00:00:00";
            // 
            // audio_filename
            // 
            this.audio_filename.AutoSize = true;
            this.audio_filename.Location = new System.Drawing.Point(17, 171);
            this.audio_filename.Name = "audio_filename";
            this.audio_filename.Size = new System.Drawing.Size(46, 13);
            this.audio_filename.TabIndex = 11;
            this.audio_filename.Text = "filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 262);
            this.Controls.Add(this.audio_filename);
            this.Controls.Add(this.trackbar_maxTime);
            this.Controls.Add(this.trackbar_time);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Filepath);
            this.Name = "Form1";
            this.Text = "Rhythm Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Filepath;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label trackbar_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label trackbar_maxTime;
        private System.Windows.Forms.Label audio_filename;
    }
}

