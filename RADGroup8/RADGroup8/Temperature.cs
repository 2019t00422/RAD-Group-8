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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (textBoxC.Text != "")
            {
                double celsius = Double.Parse(textBoxC.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                double kelvin = celsius + 273.15;

                textBoxF.Text = celsius.ToString();
                textBoxK.Text = kelvin.ToString();
            }
            else if (textBoxF.Text != "")
            {
                double fahrenheit = Double.Parse(textBoxF.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                double kelvin = (fahrenheit + 459.67) * 5 / 9;

                textBoxC.Text = celsius.ToString();
                textBoxK.Text = kelvin.ToString();
            }
            else if (textBoxK.Text != "")
            {
                double kelvin = Double.Parse(textBoxK.Text);
                double celsius = kelvin - 273.15;
                double fahrenheit = (kelvin * 9 / 5) - 459.67;

                textBoxC.Text = celsius.ToString();
                textBoxK.Text = kelvin.ToString();
            }


            
            
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxK.Text = "";
        }
    }
}
