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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string SetValueText1;
        public static string SetValueText2;
        public static string SetValueText3;
        public static string SetValueText4;
        public static string SetValueText5;
        public static string SetValueText6;
        public static string SetValueText7;
        public static string SetValueText8;
        public static string SetValueText10;
        public static string SetValueText11;
                  // Courses //
        public static string SetValueText13;
                // Subjects //
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {


 

            //strings

            string Gender = String.Empty;
            string Hobbies = String.Empty;
            string City = String.Empty;
            string CivilStatus = String.Empty;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Courses = String.Empty;
            
            //condition for gender
            if(rdmMale.Checked==true)
            {
                Gender = "Male";
            }
            else if(rdmFemale.Checked==true)
            {
                Gender = "Female";
            }
            //Condition for hobbies
           

            City=comboCity.Text;
            CivilStatus = IstCivilStatus.Text;
            Courses = comboCourses.Text;

            MessageBox.Show("Registration Successfull");
                
            SetValueText1 = textBox1.Text;
            SetValueText2 = textBox2.Text;
            SetValueText3 = textBox3.Text;
            SetValueText4 = Gender;
            SetValueText5 = textBox5.Text;
            SetValueText6 = City;
            SetValueText7 = CivilStatus;
            SetValueText10 = txtUsername.Text;
            SetValueText11 = txtPassword.Text;
            SetValueText13 = comboCourses.Text;
            
            
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
