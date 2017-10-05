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

namespace WindowsFormsTabs
{
    public partial class Contacts : Form
    {
        internal List<Contact> arr;
        Form1 fr;

        public Contacts(Form1 fr)
        {
            InitializeComponent();
            this.fr = fr;
            arr = new List<Contact>();
            /*arr.Add(new Contact("Adrian", "Yepremyan", "093791170", "060515454"));
            arr.Add(new Contact("Papa", "", "095555282", ""));
            arr.Add(new Contact("Mama", "", "093791165", ""));
            arr.Add(new Contact("Marianna", "Yepremyan", "094303003", "060533003"));
            arr.Add(new Contact("Valod", "", "099011000", ""));
            arr.Add(new Contact("Garik", "", "093653672", ""));*/
            Read();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact c = arr.ElementAt(e.RowIndex);
            FormAdd fa = new FormAdd();
            fa.textName.Text = c.Name;
            fa.textSurname.Text = c.Surname;
            fa.textMobile.Text = c.Mobile;
            fa.textHome.Text = c.Home;
            View(fa);
            DialogResult dr = fa.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            else if (dr == DialogResult.OK)
            {
                arr.ElementAt(e.RowIndex).Name = fa.textName.Text;
                arr.ElementAt(e.RowIndex).Surname = fa.textSurname.Text;
                arr.ElementAt(e.RowIndex).Mobile = fa.textMobile.Text;
                arr.ElementAt(e.RowIndex).Home = fa.textHome.Text;
                Save();
                Tarmecnel();
            }
            else if (dr == DialogResult.Yes)
            {
                string phone = fa.textMobile.Text;
                string home = fa.textHome.Text;
                if (phone.Length != 0 && home.Length != 0)
                {
                    DialogResult d = MessageBox.Show("Yes - Mobile\nNo - Home", "Which number?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (d == DialogResult.Cancel) return;
                    else if (d == DialogResult.Yes)
                    {
                        fr.number.Text = phone;
                        fr.CallButton.PerformClick();
                    }
                    else if (d == DialogResult.No)
                    {
                        fr.number.Text = home;
                        fr.CallButton.PerformClick();
                    }
                }
                else if (phone.Length != 0)
                {
                    fr.number.Text = phone;
                    fr.CallButton.PerformClick();
                }
                else
                {
                    fr.number.Text = home;
                    fr.CallButton.PerformClick();
                }
            }
            else arr.Remove(c);
            Tarmecnel();
        }

        void Add(FormAdd fa)
        {
            fa.Text = "New Contact";
            fa.buttonOK.Text = "Add";
            fa.buttonClose.Visible = false;
            fa.buttonCall.Visible = false;
            fa.buttonRemove.Text = "Cancel";
        }

        void View(FormAdd fa)
        {
            fa.Text = "Contact Info";
            fa.buttonOK.Text = "Save";
            fa.buttonClose.Visible = true;
            fa.buttonRemove.Text = "Remove";
            if (fa.textHome.Text.Length == 0 && fa.textMobile.Text.Length == 0)
            {
                fa.buttonCall.Visible = false;
                return;
            }
            fa.buttonCall.Visible = true;
        }

        internal void Read()
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream("Data/arx", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    arr = (List<Contact>)bf.Deserialize(fs);
                }
                Tarmecnel();
            }
            catch { }
        }

        internal void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/arx", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
        }

        private void Contacts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        void Tarmecnel()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = arr;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd fa = new FormAdd();
            Add(fa);
            if (fa.ShowDialog() == DialogResult.Cancel) return;
            arr.Add(new Contact(fa.textName.Text, fa.textSurname.Text, fa.textMobile.Text, fa.textHome.Text));
            Save();
            Tarmecnel();
        }
    }
}