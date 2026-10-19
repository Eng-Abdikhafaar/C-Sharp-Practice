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

namespace Assigment_TWO_Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChckBreak_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            string guestName = TxtName.Text.Trim();
            string roomType = "";

            int age, nights, guests;
            bool approved = true;
            double roomRate = 0, totalCost = 0, discountRate, total;

            // const variable for service surcharge 
            const double service_surcharge = 5;

            // Validate numeric inputs and guest name
            if (int.TryParse(TxtAge.Text, out age) & int.TryParse(TxtNumOfNights.Text, out nights) & int.TryParse(TxtNumOfGuest.Text, out guests))
            {
                if (guestName == "")
                {
                    MessageBox.Show("The Guest Name can't be Empty.");
                }
                else
                {
                    age = int.Parse(TxtAge.Text);
                    // Validate Age
                    if (age > 18 & age < 90)
                    {
                        nights = int.Parse(TxtNumOfNights.Text);
                        // Validate nights
                        if (nights > 1 & nights < 30)
                        {
                            guests = int.Parse(TxtNumOfGuest.Text);
                            // Validate guests
                            if (guests > 1 & guests < 6)
                            {
                                
                                // Determine room rate using switch
                                if (RdoStandard.Checked)
                                {
                                    roomType = "Standard";
                                }
                                else if (RdoNormal.Checked)
                                {
                                    roomType = "Normal";
                                }
                                else
                                {
                                    roomType = "Hight";
                                }


                                switch (roomType)
                                {
                                    case "Standard":
                                        roomRate = 50;

                                        if (guests > 2)
                                        {
                                            approved = false;
                                            MessageBox.Show("Booking rejected. You can choose Standard with less than 2 guest.");
                                        }
                                        else
                                        {
                                            // calculating total cost
                                            totalCost = roomRate * nights;
                                            
                                            // displaying in List Box
                                            LblBookingDetails.Items.Add("Guest Name is: " + guestName);
                                            LblBookingDetails.Items.Add("Guest Age is: " + age);
                                            LblBookingDetails.Items.Add("Number of Night's is: " + nights);
                                            LblBookingDetails.Items.Add("Number of Guest's is: " + guests);
                                            LblBookingDetails.Items.Add("Room Type is: " + roomType);
                                            LblBookingDetails.Items.Add("Room Rate is: " + roomRate);

                                        }
                                            

                                        
                                        break;

                                    case "Normal":
                                        roomRate = 80;

                                        if (guests > 4)
                                        {
                                            approved = false;
                                            MessageBox.Show("Booking rejected. You can choose Normal with less than 4 guest.");
                                        }
                                        else
                                        {
                                            // calculating total cost
                                            totalCost = roomRate * nights;

                                            // displaying in List Box
                                            LblBookingDetails.Items.Add("Guest Name is: " + guestName);
                                            LblBookingDetails.Items.Add("Guest Age is: " + age);
                                            LblBookingDetails.Items.Add("Number of Night's is: " + nights);
                                            LblBookingDetails.Items.Add("Number of Guest's is: " + guests);
                                            LblBookingDetails.Items.Add("Room Type is: " + roomType);
                                            LblBookingDetails.Items.Add("Room Rate is: " + roomRate);
                                        }

                                            
                                        break;

                                    case "Hight":
                                        roomRate = 130;

                                        if (guests > 6)
                                        {
                                            approved = false;
                                            MessageBox.Show("Booking rejected. You can choose High with less than 2 guest.");
                                        }
                                        else
                                        {
                                            // calculating total cost
                                            totalCost = roomRate * nights;

                                            // displaying in List Box
                                            LblBookingDetails.Items.Add("Guest Name is: " + guestName);
                                            LblBookingDetails.Items.Add("Guest Age is: " + age);
                                            LblBookingDetails.Items.Add("Number of Night's is: " + nights);
                                            LblBookingDetails.Items.Add("Number of Guest's is: " + guests);
                                            LblBookingDetails.Items.Add("Room Type is: " + roomType);
                                            LblBookingDetails.Items.Add("Room Rate is: " + roomRate);
                                        }
                                        break;

                                    default:
                                        MessageBox.Show("Please select a valid room type.");
                                        approved = false;
                                        break;
                                }

                                // Reject booking if rules are violated
                                if (approved == false)
                                {
                                    MessageBox.Show("Booking rejected. Check your booking details.");
                                    return;
                                }

                                // Apply length-of-stay discount
                                if (nights >= 10)
                                {
                                    // calculating DiscountRate cost
                                    discountRate = totalCost * 0.12;
                                    LblBookingDetails.Items.Add("You get 12% discount You total is: " + discountRate);
                                }
                                else if (nights >= 5)
                                {
                                    // calculating DiscountRate cost
                                    discountRate = totalCost * 0.05;
                                    LblBookingDetails.Items.Add("You get 5% discount You total is: " + discountRate);
                                }
                                else
                                {
                                    LblBookingDetails.Items.Add("There is no Discount and you total is: " + totalCost);
                                }

                                // Breakfast cost
                                if (ChckBreak.Checked)
                                {
                                    totalCost += 10 * guests * nights;
                                    LblBookingDetails.Items.Add("The Breakfast cost $10 You total is: " + totalCost);
                                }

                                // Service surcharge for more than 4 guests
                                if (guests > 4)
                                {
                                    total = totalCost * (service_surcharge / 100 );
                                    LblBookingDetails.Items.Add("If you are more than 4 guest there is");
                                    LblBookingDetails.Items.Add("\n 5% for service surcharge");
                                    LblBookingDetails.Items.Add("You total cost will be: " + total);
                                }

                                // Senior discount
                                if (age >= 60)
                                {
                                    // calculating DiscountRate cost
                                    discountRate = totalCost * 0.05;
                                    LblBookingDetails.Items.Add("You Age is above 60 so you get 5% senior discount");
                                    LblBookingDetails.Items.Add("You total is: " + discountRate);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nights must be between 1 and 30.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("The Number of Nights must be between 1 and 30.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("The Age Must be Between 18 up to 90");
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid number in Age Number Of Nights Number Of Guests And Guest Name can't be empty.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            // clearing the text box and the list box
            TxtAge.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtNumOfGuest.Text = string.Empty;
            TxtNumOfNights.Text = string.Empty;

            LblBookingDetails.Items.Clear();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
