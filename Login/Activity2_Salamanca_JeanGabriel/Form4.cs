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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string SetValueText19;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtName.Text = Form1.SetValueText1 + " " + Form1.SetValueText2;
            txtCourse.Text = Form1.SetValueText13;
            txtE.Text = Form2.SetValuesText14;
            txtM.Text = Form2.SetValuesText15;
            txtS.Text = Form2.SetValuesText16;
            txtF.Text = Form2.SetValuesText17;
            txtW.Text = Form2.SetValuesText18;

           
                     // GWA //
            txtGWA.Text = Form4.SetValueText19;

            double sum = (double.Parse(txtE.Text) + double.Parse(txtM.Text) + double.Parse(txtS.Text) + double.Parse(txtF.Text) + double.Parse(txtW.Text));
            double GWA = sum / 5;
            txtGWA.Text = GWA.ToString();

        }
    }
}
