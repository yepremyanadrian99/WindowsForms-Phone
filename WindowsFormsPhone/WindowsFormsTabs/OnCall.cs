using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsTabs
{
    public partial class OnCall : Form
    {
        bool paused = false;
        bool error = false;
        Random rr = new Random();
        int x = 0;
        int y = 0;
        public OnCall()
        {
            InitializeComponent();
            if (File.Exists("Data//callname"))
            {
                if (File.ReadAllText("Data//callname").Length != 0)
                {
                    time.Text = File.ReadAllText("Data//callname");
                }
                else
                {
                    time.Text = File.ReadAllText("Data//call");
                }
            }
            else
            {
                time.Text = File.ReadAllText("Data//call");
            }
            pause.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.transport_pause));
            timerstart.Start();
            x = rr.Next(2, 5);

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            paused = true;
            if (pause.Tag.ToString() == "pause")
            {
                pause.Tag = "play";
                pause.BackgroundImage = null;
                pause.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.transport_play));
                timertalk.Stop();
                return;
            }
            pause.Tag = "pause";
            pause.BackgroundImage = null;
            pause.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.transport_pause));
            timertalk.Start();
        }

        private void timerstart_Tick(object sender, EventArgs e)
        {
            if (File.ReadAllText("Data//call").Length != 9)
            {
                if (error) return;
                error = true;
                timertalk.Start();
                System.Media.SoundPlayer er = new System.Media.SoundPlayer(@"audio\voice\error.wav");
                er.Play();
                return;
            }
            if (y < x)
            {
                y++;
                System.Media.SoundPlayer beep = new System.Media.SoundPlayer(@"audio\beep.wav");
                beep.Play();
                return;
            }
            else if (y >= x)
            {
                int r = rr.Next(0, 4);
                System.Media.SoundPlayer voice = new System.Media.SoundPlayer("audio/voice/talk" + r + ".wav");
                voice.Play();

                timerstart.Stop();
                timertalk.Start();
                y = 0;
                time.Text = "";
                seconds.Visible = true;
                minutes.Visible = true;
                label4.Visible = true;
                pause.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void timertalk_Tick(object sender, EventArgs e)
        {
            if (!error)
            {
                File.WriteAllText("Data//money", (double.Parse(File.ReadAllText("Data//money")) - 5).ToString());
            }
            if (int.Parse(seconds.Text) == 5)
            {
                if (error)
                {
                    if (!paused)
                    {
                        EndButton.PerformClick();   /////////Es el Error-i depqum avtomat anjti/////////
                        return;
                    }
                }
            }
            if (double.Parse(File.ReadAllText("Data//money")) - 5 < 0)
            {
                System.Media.SoundPlayer vs = new System.Media.SoundPlayer(@"Audio\Voice\nomoney.wav");
                vs.Play();
                Thread.Sleep(3000);
                EndButton.PerformClick();
                return;
            }
            if (int.Parse(seconds.Text) < 59)
            {
                seconds.Text = (int.Parse(seconds.Text) + 1).ToString();
                return;
            }
            else
            {
                seconds.Text = "0";
                minutes.Text = (int.Parse(minutes.Text) + 1).ToString();
                return;
            }
        }

        private void OnCall_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("Data//callname", "");
            System.Media.SoundPlayer v = new System.Media.SoundPlayer(@"audio/voice/voiceAdrian.wav");
            System.Media.SoundPlayer er = new System.Media.SoundPlayer(@"audio\voice\error.wav");
            System.Media.SoundPlayer beep = new System.Media.SoundPlayer(@"audio\beep.wav");
            System.Media.SoundPlayer vs = new System.Media.SoundPlayer(@"Audio\Voice\nomoney.wav");
            er.Play();
            beep.Stop();
            v.Stop();
            timertalk.Stop();
            timerstart.Stop();
            int m = int.Parse(minutes.Text);
            int s = int.Parse(seconds.Text);
            if (m < 10 && s < 10)
            {
                MessageBox.Show("Talk time - 0" + m + ":0" + s);
            }
            else if (m < 10)
            {
                MessageBox.Show("Talk time - 0" + m + ":" + s);
            }
            else if (s < 10)
            {
                MessageBox.Show("Talk time - " + m + ":0" + s);
            }
            else
            {
                MessageBox.Show("Talk time - " + m + ":" + s);
            }   
        }
    }
}