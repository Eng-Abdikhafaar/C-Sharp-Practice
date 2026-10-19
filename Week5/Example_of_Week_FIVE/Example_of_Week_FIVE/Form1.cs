using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_of_Week_FIVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValidationBtn_Click(object sender, EventArgs e)
        {
            // Variables
            string names;
            int Age;
            double Salary;
            string gender;
            string Faculty = "";

            //validation age iyo salary only apply numeric
            //data.tryparse()
            if (int.TryParse(TxtAge.Text, out Age) & double.TryParse(TxtSalary.Text, out Salary))
            {
                Age = int.Parse(TxtAge.Text);
                Salary = double.Parse(TxtSalary.Text);

                // checking data integrity
                if (Age > 0 & Salary > 0)
                {
                    //validation checked property of radio button
                    if (RdoMale.Checked) // Male
                    {
                        gender = "Male";
                        // add item in list box
                        //listbox.item..add(value)
                        LstResult.Items.Add(TxtName.Text);
                        LstResult.Items.Add("Age is " + Age);
                        LstResult.Items.Add("_______________");
                        LstResult.Items.Add("Gener is " + gender);

                    }
                    else if (RdoFemale.Checked) //Female
                    {
                        gender = "Female";
                        // add item in list box
                        //listbox.item..add(value)
                        LstResult.Items.Add("Age is " + Age);
                        LstResult.Items.Add("_______________");
                        LstResult.Items.Add("Gener is " + gender);
                    }
                    else
                    {
                        MessageBox.Show("Please Select gender");
                    }
                    
                    if (ChckComputer.Checked & ChckIt .Checked)
                    {
                        Faculty = "IT\n" + " " + "Computer\n";
                        LstResult.Items.Add(Faculty);
                    }

                    else if (ChckComputer.Checked)
                    {
                        Faculty = "Computer\n";
                        LstResult.Items.Add(Faculty);
                    }
                    else if (ChckIt.Checked)
                    {
                        Faculty = "IT\n";
                        LstResult.Items.Add(Faculty);
                    }
                    
                    else
                    {
                        MessageBox.Show("Please Select Faculty");
                    }
                }
                else
                {
                    MessageBox.Show("Not Accept Age Negative");
                }
                

            }
            else
            {
                MessageBox.Show("Age And Salary Accept Numeric");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // clear list box
            LstResult.Items.Clear();
        }

        private void SlectBtn_Click(object sender, EventArgs e)
        {
            String CtSlctItem;
            //CtSlctItem = LstResult.Text;

            CtSlctItem = LstResult.SelectedItem.ToString(); // it's good but it has an error when it's null That is ()
            MessageBox.Show(CtSlctItem);

        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int count;
            count = LstResult.Items.Count;
            MessageBox.Show("Count is " + count);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int index;
            index = LstResult.SelectedIndex;
            MessageBox.Show("Position " + index);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            LstResult.Items.Remove("CA246"); // looks the case sensetive
        }

        private void RMVATBtn_Click(object sender, EventArgs e)
        {
            LstResult.Items.RemoveAt(0); // When it is null An Error Will Happen 
        }
    }
}
