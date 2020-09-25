using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            if (comboBox1.SelectedIndex > -1)
            {

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        panel1.BackColor = Color.Black;
                        label1.Text="1";
                        break;
                    case 1:
                        panel1.BackColor = Color.Brown;
                        label1.Text="2";
                        break;
                    case 2:
                        panel1.BackColor = Color.Red;
                        label1.Text="3";
                        break;
                    case 3:
                        panel1.BackColor = Color.Orange;
                        label1.Text = "3";
                        break;
                    case 4:
                        panel1.BackColor = Color.Yellow;
                        label1.Text = "4";
                        break;
                    case 5:
                        panel1.BackColor = Color.Green;
                        label1.Text = "5";
                        break;
                    case 6:
                        panel1.BackColor = Color.Blue;
                        label1.Text = "6";
                        break;
                    case 7:
                        panel1.BackColor = Color.Violet;
                        label1.Text = "7";
                        break;
                    case 8:
                        panel1.BackColor = Color.Gray;
                        label1.Text = "8";
                        break;
                    case 9:
                        panel1.BackColor = Color.AntiqueWhite;
                        label1.Text = "9";
                        break;
                    default:
                        break;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            if (comboBox2.SelectedIndex > -1)
            {

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        panel2.BackColor = Color.Black;
                        label2.Text = "1";
                        break;
                    case 1:
                        panel2.BackColor = Color.Brown;
                        label2.Text = "2";
                        break;
                    case 2:
                        panel2.BackColor = Color.Red;
                        label2.Text = "3";
                        break;
                    case 3:
                        panel2.BackColor = Color.Orange;
                        label2.Text = "3";
                        break;
                    case 4:
                        panel2.BackColor = Color.Yellow;
                        label2.Text = "4";
                        break;
                    case 5:
                        panel2.BackColor = Color.Green;
                        label2.Text = "5";
                        break;
                    case 6:
                        panel2.BackColor = Color.Blue;
                        label2.Text = "6";
                        break;
                    case 7:
                        panel2.BackColor = Color.Violet;
                        label2.Text = "7";
                        break;
                    case 8:
                        panel2.BackColor = Color.Gray;
                        label2.Text += "8";
                        break;
                    case 9:
                        panel2.BackColor = Color.AntiqueWhite;
                        label2.Text += "9";
                        break;
                    default:
                        break;
                }
            }
        }

        private void labelWynik_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pierwszy = Convert.ToDouble(label1.Text);
            double drugi = Convert.ToDouble(label2.Text);
            double mnoznik = Convert.ToDouble(label3.Text);
            double wynik = (pierwszy * 10 + drugi) * mnoznik;

            if (wynik > 1000000)
            {
                labelWynik.Text = String.Format("Rezystancja opornika wynosi {0}MΩ z toleracją {1}",
                (wynik/1000000).ToString(), label4.Text);
            }
            else if (wynik>1000)
            {
                labelWynik.Text = String.Format("Rezystancja opornika wynosi {0}KΩ z toleracją {1}",
                (wynik / 1000).ToString(), label4.Text);
            }
            else
            {
                labelWynik.Text = String.Format("Rezystancja opornika wynosi {0}Ω z toleracją {1}",
                wynik.ToString(), label4.Text);
            }
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            if (comboBox3.SelectedIndex > -1)
            {
                
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        panel3.BackColor = Color.Black;
                        label3.Text = "1";
                        break;
                    case 1:
                        panel3.BackColor = Color.Brown;
                        label3.Text = "10";
                        break;
                    case 2:
                        panel3.BackColor = Color.Red;
                        label3.Text = "100";
                        break;
                    case 3:
                        panel3.BackColor = Color.Orange;
                        label3.Text = "1000";
                        break;
                    case 4:
                        panel3.BackColor = Color.Yellow;
                        label3.Text = "10000";
                        break;
                    case 5:
                        panel3.BackColor = Color.Green;
                        label3.Text = "100000";
                        break;
                    case 6:
                        panel3.BackColor = Color.Blue;
                        label3.Text = "1000000";
                        break;
                    case 7:
                        panel3.BackColor = Color.Violet;
                        label3.Text = "10000000";
                        break;
                    case 8:
                        panel3.BackColor = Color.Gold;
                        label3.Text = "0,1";
                        break;
                    case 9:
                        panel3.BackColor = Color.Silver;
                        label3.Text = "0,01";
                        break;
                    default:
                        break;
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (comboBox4.SelectedIndex > -1)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        panel4.BackColor = Color.Brown;
                        label4.Text = "=+1%";
                        break;
                    case 1:
                        panel4.BackColor = Color.Red;
                        label4.Text = "=+2%";
                        break;
                    case 2:
                        panel4.BackColor = Color.Green;
                        label4.Text = "=+0,5%";
                        break;
                    case 3:
                        panel4.BackColor = Color.Blue;
                        label4.Text = "=+0,25%";
                        break;
                    case 4:
                        panel4.BackColor = Color.Violet;
                        label4.Text = "=+0,10%";
                        break;
                    case 5:
                        panel4.BackColor = Color.Gray;
                        label4.Text = "=+0,05%";
                        break;
                    case 6:
                        panel4.BackColor = Color.Gold;
                        label4.Text = "=+5%";
                        break;
                    case 7:
                        panel4.BackColor = Color.Silver;
                        label4.Text = "=+10%";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
