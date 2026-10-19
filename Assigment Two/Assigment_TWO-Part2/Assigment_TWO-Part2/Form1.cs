using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_TWO_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Variables to hold user input
            bool bookingApproved = true;
            string rejectionReason = "";

            int Age;
            int numberOfTickets;
            double baggageWeight;

            string passengerName = TxtName.Text.Trim();

            // Validate inputs using TryParse
            if (int.TryParse(txtPassengerAge.Text, out Age) & int.TryParse(txtNumberOfTickets.Text, out numberOfTickets) & double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                // Validate passenger information
                if (passengerName == "")
                {
                    bookingApproved = false;
                    rejectionReason = "Passenger name is required.";
                }
                else
                {
                    if (Age >= 1 && Age <= 100)
                    {
                        if (numberOfTickets >= 1 && numberOfTickets <= 5)
                        {
                            if (baggageWeight >= 0 && baggageWeight <= 50)
                            {
                                if (RdoFirstclass.Checked || RdoNormalClass.Checked || RdoBusinessClass.Checked)
                                {
                                    if (Age < 12 && RdoFirstclass.Checked)
                                    {
                                        bookingApproved = false;
                                        rejectionReason =
                                            "Passengers below 12 cannot book First Class.";
                                    }
                                }
                                else
                                {
                                    bookingApproved = false;
                                    rejectionReason = "Please select a travel class.";
                                }
                            }
                            else
                            {
                                bookingApproved = false;
                                rejectionReason =
                                    "Baggage weight must be between 0 and 50 kg.";
                            }
                        }
                        else
                        {
                            bookingApproved = false;
                            rejectionReason = "Enter a valid number of tickets.";
                        }
                    }
                    else
                    {
                        bookingApproved = false;
                        rejectionReason = "Passenger age must be between 1 and 100.";
                    }
                }

                // Calculate the booking only when approved
                if (bookingApproved)
                {
                    double ticketPrice = 0;
                    string travelClass = "";

                    if (RdoFirstclass.Checked)
                    {
                        ticketPrice = 500;
                        travelClass = "First Class";
                    }
                    else
                    {
                        if (RdoNormalClass.Checked)
                        {
                            ticketPrice = 300;
                            travelClass = "Normal Class";
                        }
                        else
                        {
                            ticketPrice = 700;
                            travelClass = "Business Class";
                        }
                    }

                    // Calculate basic ticket cost
                    double basicTicketCost = ticketPrice * numberOfTickets;

                    // Calculate ticket discount
                    double ticketDiscountRate = 0;

                    if (numberOfTickets >= 3 && numberOfTickets <= 4)
                    {
                        ticketDiscountRate = 0.05;
                    }
                    else
                    {
                        if (numberOfTickets == 5)
                        {
                            ticketDiscountRate = 0.10;
                        }
                    }

                    double ticketDiscount =
                        basicTicketCost * ticketDiscountRate;

                    double discountedCost =
                        basicTicketCost - ticketDiscount;

                    // Calculate age discount
                    double ageDiscountRate = 0;

                    if (Age < 12)
                    {
                        ageDiscountRate = 0.20;
                    }
                    else
                    {
                        if (Age >= 60)
                        {
                            ageDiscountRate = 0.10;
                        }
                    }

                    double ageDiscount = discountedCost * ageDiscountRate;

                    double costAfterAgeDiscount =
                        discountedCost - ageDiscount;

                    // Calculate travel insurance
                    double insuranceCost = 0;

                    if (chkTravelInsurance.Checked)
                    {
                        insuranceCost = 25 * numberOfTickets;
                    }

                    // Baggage allowance
                    string baggageStatus = "";

                    if (baggageWeight <= 20)
                    {
                        baggageStatus = "Free";
                    }
                    else
                    {
                        baggageStatus = "Over 20 kg; extra fee not specified";
                    }

                    // Calculate final cost
                    double totalCost =
                        costAfterAgeDiscount + insuranceCost;

                    // Display the results
                    LstResult.Items.Add("Passenger Name: " + passengerName);
                    LstResult.Items.Add("Passenger Age: " + Age);
                    LstResult.Items.Add("Number of Tickets: " + numberOfTickets);
                    LstResult.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                    LstResult.Items.Add("Travel Class: " + travelClass);
                    LstResult.Items.Add("Basic Ticket Cost: $" + basicTicketCost.ToString("F2"));
                    LstResult.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("F2"));
                    LstResult.Items.Add("Cost After Ticket Discount: $" + discountedCost.ToString("F2"));
                    LstResult.Items.Add("Age Discount: $" + ageDiscount.ToString("F2"));
                    LstResult.Items.Add("Cost After Age Discount: $" + costAfterAgeDiscount.ToString("F2"));
                    LstResult.Items.Add("Travel Insurance Cost: $" + insuranceCost.ToString("F2"));
                    LstResult.Items.Add("Baggage Status: " + baggageStatus);
                    LstResult.Items.Add("Total Cost: $" + totalCost.ToString("F2"));
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clear all input fields and reset the form
            TxtName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            // Reset radio buttons and checkbox
            RdoFirstclass.Checked = false;
            RdoNormalClass.Checked = false;
            RdoBusinessClass.Checked = false;
            chkTravelInsurance.Checked = false;

            // Clear the result list
            LstResult.Items.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}
