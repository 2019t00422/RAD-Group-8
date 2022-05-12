using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADGroup8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            textBox1.Width = 260;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void standedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            textBox1.Width = 260;
           
        }

        private void scienctificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 570;
            textBox1.Width = 530;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
