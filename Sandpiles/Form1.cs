using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandpiles
{
    public partial class Form1 : Form
    {
                
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Sandpile sandpile)
        {
            InitializeComponent();
            fillGaps(sandpile.grains);
            
        }

        void fillGaps(int[,] grains)
        {
            textBox1.Text = Convert.ToString(grains[0, 0]);
            textBox2.Text = Convert.ToString(grains[0, 1]);
            textBox3.Text = Convert.ToString(grains[0, 2]);
            textBox4.Text = Convert.ToString(grains[1, 0]);
            textBox5.Text = Convert.ToString(grains[1, 1]);
            textBox6.Text = Convert.ToString(grains[1, 2]);
            textBox7.Text = Convert.ToString(grains[2, 0]);
            textBox8.Text = Convert.ToString(grains[2, 1]);
            textBox9.Text = Convert.ToString(grains[2, 2]);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
