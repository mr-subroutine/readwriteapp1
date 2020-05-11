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

namespace ReadWriteApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\ff7.txt";

            string[] lines = System.IO.File.ReadAllLines(@f);
            foreach (string line in lines)
            {
                textBox1.Text += line;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\ff7.txt";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@f, true))
            {
                file.WriteLine("This is added text.");
            }
            textBox1.Clear();
            button1_Click(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
