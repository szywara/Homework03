using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie05
{
    public partial class FormMain : Form
    {
        int result=0;
        string oper;
        bool isOperPerformed;

        public FormMain()
        {
            InitializeComponent();
      
        }
        
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                
                oper = button.Text;
                labelCurrentOperation.Text = result + " " + oper;
                isOperPerformed = true;
            }
            else
            {

                oper = button.Text;
                result = Int32.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = result + " " + oper;
                isOperPerformed = true;
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperPerformed))
                textBox_Result.Clear();

            isOperPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }
        private void buttonEquals(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    textBox_Result.Text = (result + Int32.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - Int32.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * Int32.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (result / Int32.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Int32.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
        }
    }
}
