using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo2
{
    public partial class signup : Form
    {
        public signup()
        {
           // InitializeComponent();
            this.Load += new EventHandler(signup_Load); // Hook up the Load event
        }

        // This method will run when the form loads
        private void signup_Load(object sender, EventArgs e)
        {
            if (Globals.lastaction == "signup")
            {
                label1.Text = "Create a New Account"; // Set label for Signup
                button1.Text = "sign up";
            }
            else if (Globals.lastaction == "login")
            {
                label1.Text = "Welcome Back! Please Log In"; // Set label for Login
                button1.Text = "log in";
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if necessary
        }

        // Close the application when the form is closed
        private void signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the entire application when the signup form is closed
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phoneNumber = textBox3.Text.Trim();
            string password = textBox4.Text.Trim(); 

            // Validate Name (ensure it's not empty)
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Email (must contain "@" and end with ".com")
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                MessageBox.Show("Please enter a valid email address (e.g., user@example.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Phone Number (must be numeric and 10 digits)
            if (!long.TryParse(phoneNumber, out _) || phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be exactly 10 digits long and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Password validation(example if you have a password field)
             if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If all validations pass, proceed to the next form
            if (radioButton1.Checked)
            {
                Form3 form = new Form3();
                form.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Form4 form = new Form4();
                form.Show();
                this.Hide();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // signup
            // 
            this.ClientSize = new System.Drawing.Size(603, 244);
            this.Name = "signup";
            this.ResumeLayout(false);

        }
    }
}

