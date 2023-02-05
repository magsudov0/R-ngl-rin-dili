using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rənglərin_dili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text+"," +" "+ comboBox1.Text+" "+"rəng"+" "+"xoşbəxliyin rəngidir";
                button2.BackColor = Color.Blue;
            }
           if (comboBox1.Text == "Qırmızı")
            {
                label4.Text = textBox1.Text + "," + " " + comboBox1.Text + " " + "rəng" + " " + "bərəkətin rəngidir";
                button2.BackColor = Color.Red;
                    
            }
            if (comboBox1.Text == "Siyah") 
                {
                label4.Text = textBox1.Text + "," + " " + comboBox1.Text + " " + "rəng" + " " + "gücün rəngidir";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Ağ") 
            {
                label4.Text = textBox1.Text + "," + " " + comboBox1.Text + " " + "rəng" + " " + "sülhün rəngidir";
                button2.BackColor = Color.White;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
