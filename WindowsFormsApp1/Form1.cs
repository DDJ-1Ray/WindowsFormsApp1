using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double num1, num2;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                Double Result = 0;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":
                        Result = num1 + num2;
                        label3.Text = Result.ToString();
                        break;
                    case "-":
                        Result = num1 - num2;
                        label3.Text = Result.ToString();
                        break;
                    case "*":
                        Result = num1 * num2;
                        label3.Text = Result.ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            label3.Text = "除數不能是0";
                            return;
                        }
                        else
                            Result = num1 / num2;
                            label3.Text = Result.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                label3.Text = "輸入錯誤,必需是數";
            }
            catch (OverflowException)
            {
                label3.Text = "输入錯誤,溢出";
            }
            

        }
        
    }
}
