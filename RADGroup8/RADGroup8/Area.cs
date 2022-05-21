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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnConvert_Click(object sender, EventArgs e)
        {
			String combo1 = comboBox1.Text;
            String combo2 = comboBox2.Text;
			Console.WriteLine(combo1);
			Console.WriteLine(combo2);

            // Square miters to square feet
            if (combo1 == "Square meters" && combo2 == "Square feet")
            {
               double squareMeters = Double.Parse(textBox1.Text);
               double squareFeet = squareMeters * 10.7639;
                textBox2.Text = squareFeet.ToString();
            }

			// Square feet to square meters
			else if (combo1 == "Square feet" && combo2 == "Square meters")
			{
				double squareFeet = Double.Parse(textBox1.Text);
				double squareMeters = squareFeet / 10.7639;
				textBox2.Text = squareMeters.ToString();
			}

			// // Square feet to square inches
			// if (combo1 == "Square Feet" && combo2 == "Square Inches")
			// {
			// 	double squareFeet = Double.Parse(textBox1.Text);
			// 	double squareInches = squareFeet * 144;
			// 	textBox2.Text = squareInches.ToString();
			// }

			// // Square inches to square feet
			// if (combo1 == "Square Inches" && combo2 == "Square Feet")
			// {
			// 	double squareInches = Double.Parse(textBox1.Text);
			// 	double squareFeet = squareInches / 144;
			// 	textBox2.Text = squareFeet.ToString();
			// }

			// // Square feet to square yards
			// if (combo1 == "Square Feet" && combo2 == "Square Yards")
			// {
			// 	double squareFeet = Double.Parse(textBox1.Text);
			// 	double squareYards = squareFeet / 9;
			// 	textBox2.Text = squareYards.ToString();
			// }

			// // Square yards to square feet
			// if (combo1 == "Square Yards" && combo2 == "Square Feet")
			// {
			// 	double squareYards = Double.Parse(textBox1.Text);
			// 	double squareFeet = squareYards * 9;
			// 	textBox2.Text = squareFeet.ToString();
			// }

			// // Square yards to square meters
			// if (combo1 == "Square Yards" && combo2 == "Square Meters")
			// {
			// 	double squareYards = Double.Parse(textBox1.Text);
			// 	double squareMeters = squareYards * 0.836127;
			// 	textBox2.Text = squareMeters.ToString();
			// }

			// // Square meters to square yards
			// if (combo1 == "Square Meters" && combo2 == "Square Yards")
			// {
			// 	double squareMeters = Double.Parse(textBox1.Text);
			// 	double squareYards = squareMeters * 1.19599;
			// 	textBox2.Text = squareYards.ToString();
			// }
			else{
				textBox2.Text = "Error";
			}

        }
    }
}
