using System;
using System.Windows.Forms;

namespace demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.lastaction = "signup"; // Set action to signup
            signup form = new signup();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.lastaction = "login"; // Set action to login
            signup form = new signup();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public static class Globals
    {
        public static string lastaction = ""; // This variable can now be accessed across forms
    }
}
