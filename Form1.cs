using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"database.txt");
            string olddata = sr.ReadLine();
            sr.Close();
            string[] data = new string[4];
            data[0] = textBox1.Text;
            data[1] = textBox2.Text;
            data[2] = textBox3.Text;
            data[3] = textBox4.Text;
            StreamWriter sw = new StreamWriter(@"database.txt");
            sw.WriteLine(olddata + (Environment.NewLine) + "Booking's info" + Environment.NewLine + "Booking ID: " + data[0]
                + "    Booking Date: " + data[1] + "    Customer Name: " + data[2] + "    Flight Number: " + data[3]);
            sw.Close();

            MessageBox.Show("Data uploaded successfully!!");
        }
    }
}
