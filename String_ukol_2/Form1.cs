using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_ukol_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string text = textBox1.Text;
            if (text == "") { MessageBox.Show("Nebylo nic zadáno!!", "Error"); }
            else {
                text = String.Join(" ", text.Split(' ').Where(slovo => !String.IsNullOrWhiteSpace(slovo)));
                string[] slova = (textBox1.Text.Trim()).Split(' ');
                foreach (string s in slova) { if (s.Any(char.IsDigit)) { listBox1.Items.Add(s); } }
                textBox1.Text = text;
            }
        }
    }
}
