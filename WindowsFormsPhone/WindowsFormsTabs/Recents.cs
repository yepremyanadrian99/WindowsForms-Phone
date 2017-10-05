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

namespace WindowsFormsTabs
{
    public partial class Recents : Form
    {
        public Recents()
        {
            InitializeComponent();
            textBox1.Text = "Recent calls" + "\r\n" + File.ReadAllText("Data//recents");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.WriteAllText("Data//recents", "");
                File.WriteAllText("Data//recent", "");
                textBox1.Text = File.ReadAllText("Data//recents");
            }
        }
    }
}
