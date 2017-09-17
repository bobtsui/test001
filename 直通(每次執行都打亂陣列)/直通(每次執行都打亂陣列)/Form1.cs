using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 直通_每次執行都打亂陣列_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            this.label1.Text = "";
            Random random = new Random();
            int test;
            for (int i = 0; i < 10; i++)
            {
                int idx = random.Next(i, 10);  //隨機
                //swap elements
                test = array[i]; 
                array[i] = array[idx];
                array[idx] = test;
                
            }
            foreach (var a in array)
            {
                string abc = a + " ";
                this.label1.Text += abc;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello!!!!!!!!!!  GitHub~");
        }
    }
}
