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
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Komplektuyushchiye
        {            
            public string PAPA;
            public string MAMA;
            Form1 Ded = new Form1();
            public Komplektuyushchiye()
            {
                PAPA = "null";
                MAMA = "null";
            }
            public abstract void Display(ListBox listBox1);
        }
        class CPU : Komplektuyushchiye
        {
            public string DOCH;
            public string CIN;
            public string BRAT;
            Form1 Ded = new Form1();
            public override void Display(ListBox listBox1)
            {
                Ded.listBox1.Items.Add($"{PAPA}, {MAMA}, {DOCH}, {CIN}, {BRAT}");
            }
        }
        class Videokarta : CPU
        {
            public string Vid1;
            public string Vid2;
            public string Vid3;
            Form1 Ded = new Form1();
            public override void Display(ListBox listBox1)
            {
               listBox1.Items.Add($"{PAPA}, {MAMA}, {DOCH}, {CIN}, {BRAT}, {Vid1}, {Vid2}, {Vid3}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CPU semya = new CPU();
            semya.PAPA = Convert.ToString(textBox1.Text);
            semya.MAMA = Convert.ToString(textBox2.Text);
            semya.DOCH = Convert.ToString(textBox3.Text);
            semya.CIN = Convert.ToString(textBox4.Text);
            semya.BRAT = Convert.ToString(textBox5.Text);
            semya.Display(listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Videokarta semya = new Videokarta();
            semya.PAPA = Convert.ToString(textBox1.Text);
            semya.MAMA = Convert.ToString(textBox2.Text);
            semya.DOCH = Convert.ToString(textBox3.Text);
            semya.CIN = Convert.ToString(textBox4.Text);
            semya.BRAT = Convert.ToString(textBox5.Text);
            semya.Vid1 = Convert.ToString(textBox6.Text);
            semya.Vid2 = Convert.ToString(textBox7.Text);
            semya.Vid3 = Convert.ToString(textBox8.Text);
            semya.Display(listBox1);
        }
    }
}
