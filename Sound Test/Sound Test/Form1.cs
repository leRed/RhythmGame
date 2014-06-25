using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using Microsoft.DirectX;

namespace Sound_Test
{
    public partial class Form1 : Form
    {

        Audio mPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setPlayerInfoVisibility(false);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            //Open a dialog box to search for a track
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3|*.mp3|WAV|*.wav"; //only search for mp3's and wav's
            ofd.Title = "Select and audio track to play"; //Change the title of the dialog box

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Filepath.Text = ofd.FileName;               //Filepath
                mPlayer = new Audio(Filepath.Text);         //Tells the player the filepath of the track
                mPlayer.Open(Filepath.Text, false);         //Opens the file
                trackbarControl();                          //Sets Minimum/Maximum length for the trackbar equal to audio length
                audio_filename.Text = ofd.SafeFileName;     //Shows the name of the track

                //Get the max length of the audio track
                TimeSpan soundLength = TimeSpan.FromSeconds((int)mPlayer.Duration);
                trackbar_maxTime.Text = soundLength.ToString();

                //Set trackbar and info to show
                setPlayerInfoVisibility(true);
            }
        }
        
        private void Play_Click(object sender, EventArgs e)
        {
             mPlayer.Play();
             timer1.Start();    //starts timer to keep track of position of the trackhead
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            mPlayer.Pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            mPlayer.Stop();
        }

        //Updates the trackhead when scrolling on the trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mPlayer.CurrentPosition = (uint)trackBar1.Value;    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeConverter();                                //Updates the current time
            trackBar1.Value = (int)mPlayer.CurrentPosition; //updates the trackhead on the trackbar
        }

        private void setPlayerInfoVisibility(Boolean playerInfo)
        {
            audio_filename.Visible = playerInfo;
            trackBar1.Visible = playerInfo;
            trackbar_time.Visible = playerInfo;
            trackbar_maxTime.Visible = playerInfo;
        }

        private void timeConverter()
        {
            TimeSpan soundTime = TimeSpan.FromSeconds((int)mPlayer.CurrentPosition);
            trackbar_time.Text = soundTime.ToString();
        }

        private void trackbarControl()
        {
            trackBar1.Maximum = (int)mPlayer.Duration;
            trackBar1.Minimum = 0;
        }
        
        

        





    }
}
