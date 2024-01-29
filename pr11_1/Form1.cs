using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zherbcev_Vitaliy_26._01
{
    public partial class train :Form
    {
        public train ()
        {
            InitializeComponent();
        }



        public class Train
        {
            public string num;
            public string time;
            public string punkt;

            
        }
        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Train train1 = new Train();
            train1.num = textBox1.Text;
            train1.punkt = textBox2.Text;
            train1.time = textBox3.Text;
            Train train2 = new Train();
            train2.num = textBox4.Text;
            train2.punkt = textBox5.Text;
            train2.time = textBox6.Text;

            MessageBox.Show(string.Format("Номер поезда1: {0}\nВремя1: {1}\nПункт1: {2} \nНомер поезда2: {3}\nВремя2: {4}\nПункт2: {5}  ", train1.num, train1.time, train2.punkt, train2.num, train2.time, train2.punkt));
            
        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        private void train_Load (object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged (object sender, EventArgs e)
        {

        }

        private void label5_Click (object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {

        }

        private void label3_Click (object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged (object sender, EventArgs e)
        {

        }

        private void label6_Click (object sender, EventArgs e)
        {

        }
    }
}
