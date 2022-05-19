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
        Double result = 0;
        String operation = "";
        bool enter_value = false;
       // int bracketCount = 0;

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

        //number 0 - 9 and . btn 
        private void button_Click(object sender, EventArgs e)
        {    
            
            if ((textBox1.Text == "0") || (enter_value)) 
                textBox1.Text = "";
            
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".") { 
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }


        //create BackSpaceClick 
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        //+ or - btn
        private void btnPM_Click(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString();
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            String btntext = ((Button)sender).Text;
            Button num = (Button)sender;
            operation = num.Text;
            if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-' || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                if  (operation != textBox1.Text[textBox1.Text.Length - 1].ToString()){
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    btntext = Convert.ToString(textBox1.Text);
                    textBox1.Text = System.Convert.ToString(btntext) + operation;
                }
                return;
            }
            btntext = Convert.ToString(textBox1.Text);
            textBox1.Text = System.Convert.ToString(btntext) + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            
            Console.WriteLine(textBox1.Text );
            String Equalstr = (textBox1.Text);

            if (Equalstr[Equalstr.Length - 1] == '+' || Equalstr[Equalstr.Length - 1] == '-' || Equalstr[Equalstr.Length - 1] == '*' || Equalstr[Equalstr.Length - 1] == '/')
            {
                Equalstr = Equalstr.Remove(Equalstr.Length - 1);
            }
            
            // new DataTable() obj eka callculate 
            var FinalResult = Convert.ToDouble(new DataTable().Compute(Equalstr,"")+"");
            Console.WriteLine(FinalResult);
            textBox1.Text = Math.Round(FinalResult, 5).ToString();

        }

        //pi btn 
        private void btnPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        //Log Button
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xlog = Double.Parse(textBox1.Text);
            xlog = Math.Log10(xlog);
            textBox1.Text = System.Convert.ToString(xlog);
        }

        //Square root button
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }

            Double xSqrt = Double.Parse(textBox1.Text);
            xSqrt = Math.Sqrt(xSqrt);
            textBox1.Text = System.Convert.ToString(xSqrt);
        }

        //SinH Button
        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }

            Double xSinh = Double.Parse(textBox1.Text);
            xSinh = Math.Sinh(xSinh);
            textBox1.Text = System.Convert.ToString(xSinh);
        }

        //Sin Button
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }

            Double xSin = Double.Parse(textBox1.Text);
            xSin = Math.Sin(xSin);
            textBox1.Text = System.Convert.ToString(xSin);
        }

        //Cosh Button
        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xCosh = Double.Parse(textBox1.Text);
            xCosh = Math.Cosh(xCosh);
            textBox1.Text = System.Convert.ToString(xCosh);
        }

        //Cos Button
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xCos = Double.Parse(textBox1.Text);
            xCos = Math.Cos(xCos);
            textBox1.Text = System.Convert.ToString(xCos);
        }

        //TanH Button
        private void btnTanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xTanh = Double.Parse(textBox1.Text);
            xTanh = Math.Tanh(xTanh);
            textBox1.Text = System.Convert.ToString(xTanh);
        }

        //Tan Button
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            
            Double xTan = Double.Parse(textBox1.Text);
            xTan = Math.Tan(xTan);
            textBox1.Text = System.Convert.ToString(xTan);
        }

        //Dec Button
        private void btnDec_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xDec = Double.Parse(textBox1.Text);
            xDec = Math.Log10(xDec);
            textBox1.Text = System.Convert.ToString(xDec);
        }

        //bin button
        private void btnBin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            int xBin = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xBin,2);
        }

        //hex button
        private void btnHex_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            int xHex = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xHex,16);
        }

        //oct button
        private void btnOct_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            int xOct = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xOct,8);
        }

        // X2 button
        private void btnX2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            double x2 ;
            x2 = Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(x2);
        }

        // X3 button
        private void btnX3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            double x3;
            x3 = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(x3);
        }

        // 1/X button
        private void btn1X_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            double x1;
            x1 = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)) ;
            textBox1.Text = System.Convert.ToString(x1);
        }

        // In button
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            Double xIn = Double.Parse(textBox1.Text);
            xIn = Math.Log(xIn);
            textBox1.Text = System.Convert.ToString(xIn);
        }

        //Percentage button
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                return;
            }
            double xPercentage ;
            xPercentage = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(xPercentage);
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature temp = new Temperature();
            temp.Show();
            
        }
    }
}
