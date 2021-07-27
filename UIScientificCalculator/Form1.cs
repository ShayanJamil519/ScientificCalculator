using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIScientificCalculator
{
    public partial class ScientifCalculator : Form
    {
        double result;
        double FirstEntry;
        string Operator;
        bool OperatorAction = false;

        public double Factorial(double n)
        {
            double fact = 1;
            for(double i = n; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        public ScientifCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonNumbers_Click(object sender, EventArgs e)
        {

            if (textBoxScreen.Text == "0" || OperatorAction)
                textBoxScreen.Clear();
            OperatorAction = false;
           Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (! textBoxScreen.Text.Contains("."))
                {
                    textBoxScreen.Text = textBoxScreen.Text + btn.Text;
                }
            }
                else
                {
                    textBoxScreen.Text = textBoxScreen.Text + btn.Text;
                }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text ="0";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBoxScreen.Text);
            result = result * -1;
            textBoxScreen.Text = result.ToString();
        }

        private void Operators__Click(object sender, EventArgs e)
        {
            FirstEntry = double.Parse(textBoxScreen.Text);
            Button optr = (Button)sender;
            Operator = optr.Text;
            OperatorAction = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case "+":
                    textBoxScreen.Text = (FirstEntry + (double.Parse(textBoxScreen.Text))).ToString();
                    break;

                case "-":
                    textBoxScreen.Text = (FirstEntry - (double.Parse(textBoxScreen.Text))).ToString();
                    break;

                case "x":
                    textBoxScreen.Text = (FirstEntry * (double.Parse(textBoxScreen.Text))).ToString();
                    break;

                case "/":
                    textBoxScreen.Text = (FirstEntry / (double.Parse(textBoxScreen.Text))).ToString();
                    break;

                case "n!":
                    result = Factorial(FirstEntry);
                    textBoxScreen.Text = result.ToString();
                    break;

                case "nCr":
                    double nMinusr = (FirstEntry - (double.Parse(textBoxScreen.Text)));
                    result = (Factorial(FirstEntry)) / ((Factorial(double.Parse(textBoxScreen.Text))) * (Factorial(nMinusr)));
                    textBoxScreen.Text = result.ToString();
                    break;

                case "nPr":
                    double _nMinusr = (FirstEntry - (double.Parse(textBoxScreen.Text)));
                    result = (Factorial(FirstEntry)) /((Factorial(_nMinusr)));
                    textBoxScreen.Text = result.ToString();
                    break;
            }
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "";
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "0";
        }
        private void buttonDelSingleDigit_Click(object sender, EventArgs e)
        {
            int index = textBoxScreen.Text.Length;
            index--;
            textBoxScreen.Text = textBoxScreen.Text.Remove(index);
            if (textBoxScreen.Text == "")
            {
                textBoxScreen.Text = "0";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            result = Math.Sin(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            result = Math.Cos(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            result = Math.Tan(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonASin_Click(object sender, EventArgs e)
        {
            result = Math.Asin(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonACos_Click(object sender, EventArgs e)
        {
            result = Math.Acos(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonATan_Click(object sender, EventArgs e)
        {
            result = Math.Atan(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonLnX_Click(object sender, EventArgs e)
        {
            result = Math.Log(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            result = Math.Exp(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void button_Xsqr_Click(object sender, EventArgs e)
        {
            result = (double.Parse(textBoxScreen.Text))* (double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void button_Xcube_Click(object sender, EventArgs e)
        {
            result = (double.Parse(textBoxScreen.Text)) * (double.Parse(textBoxScreen.Text)) * (double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void button1uponX_Click(object sender, EventArgs e)
        {
            result = 1/(double.Parse(textBoxScreen.Text));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            result = (FirstEntry % (double.Parse(textBoxScreen.Text)));
            textBoxScreen.Text = result.ToString();
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            result =(double.Parse(textBoxScreen.Text))/100;
            textBoxScreen.Text = (result+" %").ToString();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            textBoxScreen.Text = result.ToString();
        }
    }
}
