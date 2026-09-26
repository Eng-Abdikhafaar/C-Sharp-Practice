using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examp_of_Week_TWO
{
    public partial class Example2 : Form
    {
        public Example2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set lebel
            Lbl_Name.Text = "Hello! My name is Abdighafaar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this clear my Lbl_Name you can make two ways
            // First way: using empty property
            Lbl_Name.Text = String.Empty;

            // Second way: using empty string
            Lbl_Name.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this closes the application you can make also two ways 
            // First way: using close function
            this.Close();

            // Second way: using Exit function
            Application.Exit();
        }

        private void BtnReader_Click(object sender, EventArgs e)
        {
            // Read From the lebal 
            String Name = Lbl_Name.Text;
            MessageBox.Show(Name);
        }

        private void Lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void Fac_Cover_Img_Click(object sender, EventArgs e)
        {

        }

        private void Behance_Cvr_Rec_Click(object sender, EventArgs e)
        {
            
        }

        private void Img_Label_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FirstnameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastnameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firstnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Lastnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void ConcatBtn_Click(object sender, EventArgs e)
        {
            // creating variables
            string Firstname, Lastname;

            // initialize the variables
            Firstname = FirstnameTxtBx.Text;
            Lastname = LastnameTxtBx.Text;

            // concartinating the name
            string Fullname = Firstname + " " +Lastname;

            // printing the full name
            LblOutput.Text = Fullname;
        }

        private void LblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearTxt_Click(object sender, EventArgs e)
        {
            // you can clear TextBox three ways
            // First: is using Clear Function 
            FirstnameTxtBx.Clear();

            // Second & third: is just like the two ways of label 
            LastnameTxtBx.Text = string.Empty;

            // don't confuse this is clearing the label 
            LblOutput.Text = String.Empty;

        }
    }
}
