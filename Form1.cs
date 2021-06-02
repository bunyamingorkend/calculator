using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public class sas
        {
            public static double ans = 0;
            public  static double d;
            public  static char echo;
            public sas()
            { }
           public  sas(double dw, char ech)
            {
                
                d = dw;
                echo = ech;

            }
            public String don(double ds)
            {
               // MessageBox.Show(d+"");
              
                if (echo == 'a')
                {
                    ans = d + ds;
                    return Convert.ToString(ans);

                }
                else if (echo == 'd')
                {
                    if (ds == 0)
                    {
                        return "Inf";

                    }

                    ans = d / ds;
                    return Convert.ToString(ans);

                }
                else if (echo == 's')
                {
                    ans = d - ds;
                    return Convert.ToString(ans);
                }
                else  
                {
                    ans = d * ds;
                    return Convert.ToString(ans);
                }
               
               
            }

        }


        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text +="1";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+ float.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture));
            sas s=new sas(double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture), 'd');
            textBox1.Text += " /";
            label1.Text = textBox1.Text;

                 textBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sas s = new sas(double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture), 'm');
            textBox1.Text += " *";
            label1.Text = textBox1.Text;

            textBox1.Text = " ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sas s=new sas();
            label1.Text += textBox1.Text+" =";
            textBox1.Text=s.don(Convert.ToDouble(textBox1.Text));
            


        }

        private void button13_Click(object sender, EventArgs e)
        {
            sas s = new sas(double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture), 's');
            textBox1.Text += " -";
            label1.Text = textBox1.Text;

            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sas s = new sas(double.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture), 'a');
            textBox1.Text += " +";
            label1.Text = textBox1.Text;

            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            { }
            else
            { textBox1.Text += '.'; }

        }
    }
}
