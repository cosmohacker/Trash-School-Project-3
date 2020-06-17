using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fak = 1,sayi;
            sayi = Convert.ToInt32(tx_fak.Text);

            for (int i = 1; i <= sayi; i++)
            {
                fak = fak * i;
                listBox1.Items.Add(i);
                label2.Text = fak.ToString();
            }
        }
    }
}
