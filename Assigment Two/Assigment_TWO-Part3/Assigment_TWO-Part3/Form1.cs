using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assigment_TWO_Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            int age, days, experience;

            if (name == "")
            {
                MessageBox.Show("Please enter customer name.");
            }
            else
            {
                if (int.TryParse(txtAge.Text, out age) & int.TryParse(txtDays.Text, out days) & int.TryParse(txtExperience.Text, out experience))
                {
                    if (age > 18 & age < 80)
                    {
                        if (days > 1 & days < 30)
                        {
                            if (experience < 0 & experience < 1)
                            {
                                MessageBox.Show("Driving experience cannot be negative & it must be at least 1 year.");
                            }
                            else
                            {
                                if (rdoEconomy.Checked || rdoSuv.Checked || rdoLuxury.Checked)
                                {
                                    if (rdoLuxury.Checked && (age >= 25 & experience >= 3))
                                    {
                                        string vehicle = "";
                                        double rate = 0;

                                        if (rdoEconomy.Checked)
                                        {
                                            vehicle = "Economy";
                                            rate = 35;
                                        }
                                        else if (rdoSuv.Checked)
                                        {
                                            vehicle = "SUV";
                                            rate = 60;
                                        }
                                        else if (rdoLuxury.Checked)
                                        {
                                            vehicle = "Luxury";
                                            rate = 100;
                                        }

                                        // Basic rental cost
                                        double basicCost = rate * days;

                                        // Discount
                                        double discountRate = 0;

                                        if (days >= 14)
                                        {
                                            discountRate = 0.10;
                                        }
                                        else if (days >= 7)
                                        {
                                            discountRate = 0.05;
                                        }

                                        double discount = basicCost * discountRate;

                                        // Insurance
                                        double insuranceCost = 0;

                                        if (chkInsurance.Checked)
                                        {
                                            insuranceCost = 15 * days;
                                        }

                                        // Young driver surcharge
                                        double youngSurcharge = 0;

                                        if (age >= 21 && age <= 24)
                                        {
                                            youngSurcharge = basicCost * 0.10;
                                        }

                                        // Final cost
                                        double finalCost = basicCost - discount + insuranceCost + youngSurcharge;

                                        // Dispalay results

                                        lstResult.Items.Clear();
                                        lstResult.Items.Add("RENTAL DETAILS\n");
                                        lstResult.Items.Add("----------------------------------\n");
                                        lstResult.Items.Add("Customer Name\t: " + name);
                                        lstResult.Items.Add("Customer Age\t: " + age);
                                        lstResult.Items.Add("Driving Experience\t: " + experience + " years\n");
                                        lstResult.Items.Add("Vehicle Type\t: " + vehicle + "\n");
                                        lstResult.Items.Add("Daily Rate\t: $" + rate + "\n");
                                        lstResult.Items.Add("Rental Days\t: " + days + "\n");
                                        lstResult.Items.Add("Basic Rental Cost\t: $" + basicCost + "\n");
                                        lstResult.Items.Add("Discount\t\t: $" + discount + "\n");
                                        lstResult.Items.Add("Insurance Cost\t: $" + insuranceCost + "\n");
                                        lstResult.Items.Add("Young Driver Surcharge: $" + youngSurcharge + "\n");
                                        lstResult.Items.Add("Final Rental Cost\t: $" + finalCost + "\n");
                                        
                                        lstResult.Items.Add("\n");
                                        lstResult.Items.Add("----------------------------------\n");
                                        lstResult.Items.Add("Rental Status\t: " + (finalCost > 0 ? "Approved" : "Denied") + "\n");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Luxury requires age 25 or above and at least 3 years of experience.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select a vehicle type.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rental days must be between 1 and 30.");
                        }
                    }
                    else if (age < 21)
                    {
                        MessageBox.Show("Customers below 21 are not eligible.");
                    }
                    else
                    {
                        MessageBox.Show("Age must be between 18 and 80.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values.");
                }

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clear text boxes
            txtName.Clear();
            txtAge.Clear();
            txtDays.Clear();
            txtExperience.Clear();

            // clear radio buttons
            rdoEconomy.Checked = false;
            rdoLuxury.Checked = false;
            rdoSuv.Checked = false;

            // clear checkbox
            chkInsurance.Checked = false;

            // clear list box
            lstResult.Items.Clear();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
