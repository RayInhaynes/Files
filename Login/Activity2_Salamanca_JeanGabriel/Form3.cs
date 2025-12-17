using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2_Salamanca_JeanGabriel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "password123")
            {
                // Show success message
                MessageBox.Show("Credentials are correct, proceed to login.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide Form1 and show Form2
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                // Show Messagge //
                MessageBox.Show("Credentials are incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
