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
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace WindowsFormsTabs
{
    public partial class Form1 : Form
    {
        public string anun;
        Contacts ct;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            name.Text = "";
            ct = new Contacts(this);
            if (File.Exists("Data/aaa.txt"))
            {
                MessageBox.Show("Xosal@ dzri chi, 5 dr/vrk\npogh@ stugel - *122#\nlicqavorel - *123#\nmisht lav zanger stanaq!");
                File.Delete("Data/aaa.txt");
            }
        }

        private void recents_MouseEnter(object sender, EventArgs e)
        {
            recents.BackColor = Color.LightSlateGray;
        }

        private void call_MouseEnter(object sender, EventArgs e)
        {
            call.BorderStyle = BorderStyle.Fixed3D;
        }

        private void contacts_MouseEnter(object sender, EventArgs e)
        {
            contacts.BackColor = Color.LightSlateGray;
        }

        private void recents_MouseLeave(object sender, EventArgs e)
        {
            recents.BackColor = Color.LightSteelBlue;
        }

        private void contacts_MouseLeave(object sender, EventArgs e)
        {
            contacts.BackColor = Color.LightSteelBlue;
        }
        private void button1_MouseClick(object sender, EventArgs e)
        {
            if (number.Text.Length < 22)
            {
                number.Text += ((Button)sender).Text;     /////////////////Tver@ kardalu hamar en/////////////////
            }
            if (((Button)sender).Text == "0")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/0.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "1")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/1.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "2")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/2.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "3")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/3.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "4")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/4.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "5")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/5.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "6")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/6.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "7")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/7.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "8")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/8.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "9")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/9.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "*")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/star.wav");
                sound.Play();
            }
            if (((Button)sender).Text == "#")
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("audio/#.wav");
                sound.Play();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            number.Text = "";
        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            if (number.Text == "*122#" || number.Text == "*102#") /////////////////Licqavorman, hashiv@ stugelu hamara/////////////////
            {
                number.Text = "";
                try
                {
                    File.ReadAllText("Data//money");
                }
                catch
                {
                    File.WriteAllText("Data//money", "500");
                }
                MessageBox.Show("Dzer hashvin ka " + File.ReadAllText("Data//money") + " dram");
                return;
            }
            if (number.Text == "*123#")
            {
                number.Text = "";
                Money m = new Money();
                m.ShowDialog();
                return;
            }
            if (number.Text.Length == 0)
            {
                string num = "";
                try
                {
                    num = File.ReadAllText("Data//call");  //////////Vor zang@ sxmeluc avtomat verji hamar@ datark toghum gri//////////
                }
                catch
                {
                    File.WriteAllText("Data//call", "");
                    return;
                }
                if (num.Length != 0)
                {
                    number.Text = num;
                }
                return;
            }
            try
            {
                if (double.Parse(File.ReadAllText("Data//money")) < 1)  /////////////////Lav chi ashxatum/////////////////
                {                                                   /////////////////Pogh tanuma menak ete ropeov es xosum/////////////////
                    MessageBox.Show("Du pogh chunes zangelu hamar!");
                    number.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            File.WriteAllText("Data//recent", number.Text);
            File.AppendAllText("Data//recents", "\n" + number.Text);
            File.WriteAllText("Data//call", number.Text);
            File.WriteAllText("Data//callname", name.Text);
            OnCall on = new OnCall();
            on.ShowDialog();
            number.Text = "";
            name.Text = "";
        }

        int[] a = new int[9];
        private void recents_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Data//recent"))/////////////////Menak amenaverji hamar@ kardalu hamara es papken/////////////////
            {
                new System.Media.SoundPlayer("Audio//Voice//chka.wav").Play();
                File.WriteAllText("Data//recent", "");
                return;
            }
            else if (!File.Exists("Data//recents"))
            {
                File.WriteAllText("Data//recents", "");
                return;
            }
            else if (File.ReadAllText("Data//recents").Length == 0)
            {
                new System.Media.SoundPlayer("Audio//Voice//chka.wav").Play();
                return;
            }
            int num = int.Parse(File.ReadAllText("Data//recent"));
            /*if (num.ToString().Length != 9)
            {
                return;
            }*/
            a[0] = num / 100000000;
            a[1] = num / 10000000 % 10; ;
            a[2] = num / 1000000 % 10; ;
            a[3] = num / 100000 % 10; ;
            a[4] = num / 10000 % 10; ;   /////////////////Sranq tver@ kartalu hamar en/////////////////
            a[5] = num / 1000 % 10; ;
            a[6] = num / 100 % 10; ;
            a[7] = num / 10 % 10; ;
            a[8] = num % 10; ;
            /*for (int i = 1; i < 8; i++)
            {
                for (int j = 10000000; j > 10; j = j / 10)
                {
                    for (int k = 10; ; )
                    {
                        a[i] = num / j % k;
                    }
                }
            }*/
            System.Media.SoundPlayer vs = new System.Media.SoundPlayer("Audio//Voice//read.wav");//////////////Kartuma hamar@//////////////
            vs.Stop();
            vs.Play();
            Thread.Sleep(1000);
            read.Start();
            new Recents().ShowDialog();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            ct.ShowDialog();

            ct.Save();
        }

        private void read_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer vs = new System.Media.SoundPlayer("Audio//" + a[i] + ".wav");
            vs.Play();
            if (i + 1 >= 9)///////////Stuguma ete hamar@ prcela kardal(9 nishanoc)///////////
            {
                read.Stop();
                i = 0;
                return;
            }
            i++;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            /*if (number.Text == "093791170")        /////////////////Some contacts/////////////////
            {
                name.Text = "Adrian";
            }
            else if (number.Text == "095555282")
            {
                name.Text = "Papa";
            }
            else if (number.Text == "094303003" || number.Text == "060533003")
            {
                name.Text = "Kyanqsss";
            }
            else if (number.Text == "093791165")
            {
                name.Text = "Mama";
            }
            else if (number.Text == "060515454" || number.Text == "010424621")
            {
                name.Text = "Tun";
            }
            else if (number.Text == "093303003" || number.Text == "099011000")
            {
                name.Text = "Axxpers";
            }
            else if (number.Text == "093791163")
            {
                name.Text = "Nina tati";
            }
            else
            {
                anun = "";
                name.Text = "";
            }*/
            bool found = false;
            Contact cc = new Contact();
            foreach (Contact c in ct.arr)
            {
                if (number.Text.Length != 0 && (number.Text == c.Mobile || number.Text == c.Home))
                {
                    cc.Name = c.Name;
                    cc.Surname = c.Surname;
                    found = true;
                    break;
                }
            }
            if (found) name.Text = cc.Name + " " + cc.Surname;
            else name.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (number.Text.Length == 0)
            { return; }
            number.Text = number.Text.Remove(number.Text.Length - 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) button0.PerformClick();
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) button1.PerformClick();
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) button2.PerformClick();
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) button3.PerformClick();
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) button4.PerformClick();
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) button5.PerformClick();
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) button6.PerformClick();
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) button7.PerformClick();
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) button8.PerformClick();
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) button9.PerformClick();
            else if (e.KeyCode == Keys.Multiply) button10.PerformClick();
            else if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3) button12.PerformClick();
            else if (e.KeyCode == Keys.Back) Delete.PerformClick();
            else if (e.KeyCode == Keys.Delete) Clear.PerformClick();
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R) recents.PerformClick();
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C) contacts.PerformClick();
        }
    }
}