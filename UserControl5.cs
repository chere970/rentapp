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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        public void UserControl5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Single family home");
            comboBox1.Items.Add("condo");
            comboBox1.Items.Add("townhome");
            comboBox1.Items.Add("apartment");
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
