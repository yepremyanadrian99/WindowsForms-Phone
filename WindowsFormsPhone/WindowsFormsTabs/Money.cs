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
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (code.Text.Length != 12)
            {
                MessageBox.Show("Cod@ petq e lini 12 nishanoc");
                code.Clear();
                return;
            }
            if (File.ReadAllText("Data//money").Length == 0)
            {
                File.WriteAllText("Data//money", "0");
            }
            File.WriteAllText("Data//money", (int.Parse(File.ReadAllText("Data//money")) + 100).ToString());
            MessageBox.Show("Dzer hashiv@ licqavorvel e 100 dramov, kazmum e " + File.ReadAllText("Data//money") + " dram");
            this.Close();
        }

        private void code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enter.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}