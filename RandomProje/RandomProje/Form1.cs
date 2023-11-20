using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random sayi bulma
            Random rnd = new Random();
            int sayi,sayi2,sayi3;
            sayi = rnd.Next(1,5);
            sayi2 = rnd.Next(1, 5);
            sayi3 = rnd.Next(1, 5);

            label1.Text = sayi.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString(); 


        }
    }
}
