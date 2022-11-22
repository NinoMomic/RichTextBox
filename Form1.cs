using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:tempproba.rtf");
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }
    }
}
