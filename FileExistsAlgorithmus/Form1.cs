using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExistsAlgorithmus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            while ((line = file.ReadLine()) != null)
            {
                if (File.Exists(line))
                {
                    File.AppendAllLines(textBox1.Text, new[] { line + " EXISTIERT in seinem Verzeichnis." });
                } else {
                    File.AppendAllLines(textBox1.Text, new[] { line + " EXISTIERT NICHT in seinem Verzeichnis." });
                }
                counter++;
            }
            file.Close();
            MessageBox.Show("Die Analyse ist vollständig...", "Fertig");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
