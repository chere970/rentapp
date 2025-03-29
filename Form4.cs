using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the entire application when the signup form is closed
        }
        private void Form4_load(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl61.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl61.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userControl51.Hide();
            userControl61.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signup form = new signup();
            form.Show();
            this.Hide();
        }
    }
}
