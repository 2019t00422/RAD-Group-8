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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value)) {
                textBox1.Text = "";
            }
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index --;
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

        private void btnPM_Click(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString();
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = System.Convert.ToString(result)+ "" + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (result % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    Double i = Double.Parse(textBox1.Text);
                    Double q;
                    q = (result);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4) ).ToString();
                    break;
                
            }
           
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589 ";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Double xlog = Double.Parse(textBox1.Text);
            xlog = Math.Log(xlog);
            textBox1.Text = System.Convert.ToString(xlog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Double xSqrt = Double.Parse(textBox1.Text);
            xSqrt = Math.Sqrt(xSqrt);
            textBox1.Text = System.Convert.ToString(xSqrt);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            Double xSinh = Double.Parse(textBox1.Text);
            xSinh = Math.Sinh(xSinh);
            textBox1.Text = System.Convert.ToString(xSinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            Double xSin = Double.Parse(textBox1.Text);
            xSin = Math.Sin(xSin);
            textBox1.Text = System.Convert.ToString(xSin);
        }
        
        private void btnCosh_Click(object sender, EventArgs e)
        {
            Double xCosh = Double.Parse(textBox1.Text);
            xCosh = Math.Cosh(xCosh);
            textBox1.Text = System.Convert.ToString(xCosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Double xCos = Double.Parse(textBox1.Text);
            xCos = Math.Cos(xCos);
            textBox1.Text = System.Convert.ToString(xCos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            Double xTanh = Double.Parse(textBox1.Text);
            xTanh = Math.Tanh(xTanh);
            textBox1.Text = System.Convert.ToString(xTanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            Double xTan = Double.Parse(textBox1.Text);
            xTan = Math.Tan(xTan);
            textBox1.Text = System.Convert.ToString(xTan);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            Double xDec = Double.Parse(textBox1.Text);
            xDec = Math.Log10(xDec);
            textBox1.Text = System.Convert.ToString(xDec);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int xBin = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xBin,2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int xHex = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xHex,16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int xOct = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(xOct,8);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double x2 ;
            x2 = Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(x2);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            double x3;
            x3 = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(x3);
        }
    }
}
