using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(String.Format("Opcja {0}", i));
                listBox2.Items.Add(String.Format("Opcja {0}", (char)(i + (int)'A')));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            if(listBox1.SelectedItem != null)
            { button1.Enabled = true; }
            
        }
        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            if (listBox2.SelectedItem != null)
            { button2.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> toRemove = new List<object>();

            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
                toRemove.Add(item);
            }

            foreach (var item in toRemove)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<object> toRemove = new List<object>();

            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
                toRemove.Add(item);
            }

            foreach (var item in toRemove)
            {
                listBox2.Items.Remove(item);
            }
        }
    }
}
