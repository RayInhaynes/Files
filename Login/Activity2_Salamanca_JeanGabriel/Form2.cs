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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string SetValuesText13;
        public static string SetValuesText14;
        public static string SetValuesText15;
        public static string SetValuesText16;
        public static string SetValuesText17;
        public static string SetValuesText18;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.SetValueText1;
            textBox2.Text = Form1.SetValueText2;
            textBox3.Text = Form1.SetValueText3;
            textBox4.Text = Form1.SetValueText4;
            textBox5.Text = Form1.SetValueText5;
            textBox6.Text = Form1.SetValueText6;
            textBox7.Text = Form1.SetValueText7;
            txtCourse.Text = Form1.SetValueText13;
            
            
           
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SetValuesText13 = txtCourse.Text;
            SetValuesText14 = txtE.Text;
            SetValuesText15 = txtM.Text;
            SetValuesText16 = txtS.Text;
            SetValuesText17 = txtF.Text;
            SetValuesText18 = txtW.Text;


            Form4 form4 = new Form4();
            form4.Show();
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tx_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }
    }
}