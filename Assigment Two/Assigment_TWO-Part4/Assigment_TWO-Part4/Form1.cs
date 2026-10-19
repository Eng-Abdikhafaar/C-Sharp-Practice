using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_TWO_Part4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            bool bookingApproved = true;
            string rejectionReason = "";

            string studentName = TxtName.Text.Trim();
            string studentId = TxtID.Text.Trim();
            int studyLevel = int.Parse(TxtYear.Text);

            int numberOfCourses = 0;
            double feePerCourse = 0;
            double tuitionFee = 0;
            double accommodationFee = 0;
            double discountAmount = 0;
            double serviceDiscount = 0;
            double finalAmount = 0;

            // Validate student information
            if (studentName == "")
            {
                bookingApproved = false;
                rejectionReason = "Please enter the student name.";
            }
            else
            {
                if (studentId == "")
                {
                    bookingApproved = false;
                    rejectionReason = "Please enter the student ID.";
                }
                else
                {
                    // Validate number of courses using TryParse
                    if (int.TryParse(TxtCourse.Text, out numberOfCourses))
                    {
                        if (numberOfCourses >= 1 && numberOfCourses <= 8)
                        {
                            // Validate study level and set fee per course
                            if (studyLevel == 1)
                            {
                                feePerCourse = 40;
                            }
                            else if (studyLevel == 2)
                            {
                                feePerCourse = 45;
                            }
                            else if (studyLevel == 3)
                            {
                                feePerCourse = 50;
                            }
                            else if (studyLevel == 4)
                            {
                                feePerCourse = 55;
                            }
                            else
                            {
                                bookingApproved = false;
                                rejectionReason = "Please select a valid study level.";
                            }

                            // Validate service selections
                            if (bookingApproved)
                            {
                                // Calculate basic tuition fee
                                tuitionFee = feePerCourse * numberOfCourses;


                                // Apply 10% discount for 6 or more courses
                                if (numberOfCourses >= 6)
                                {
                                    discountAmount = tuitionFee * 0.10;
                                }
                                else
                                {
                                    discountAmount = 0;
                                }

                                // Calculate tuition after the first discount
                                double discountedTuition = tuitionFee - discountAmount;

                                // Calculate total discount
                                discountAmount = discountAmount + serviceDiscount;

                                // Calculate final registration fee
                                finalAmount = tuitionFee + accommodationFee + int.Parse(TxtFee.Text) - discountAmount;
                                /*
                                if ((rbAccommodationYes.Checked || rbAccommodationNo.Checked) && (rbTransportYes.Checked || rbTransportNo.Checked))
                                {


                                    Calculate accommodation fee
                                    if (rbAccommodationYes.Checked)
                                    {
                                        accommodationFee = 120;
                                    }
                                    else
                                    {
                                        accommodationFee = 0;
                                    }

                                    // Calculate transport fee
                                    if (rbTransportYes.Checked)
                                    {
                                        transportFee = 50;
                                    }
                                    else
                                    {
                                        transportFee = 0;
                                    }

                                    Apply 10 % discount for 6 or more courses



                                    Apply additional 5 % service discount
                                    if (rbAccommodationYes.Checked && rbTransportYes.Checked && numberOfCourses >= 5)
                                        {
                                            serviceDiscount =
                                                discountedTuition * 0.05;
                                        }
                                        else
                                        {
                                            serviceDiscount = 0;
                                        }
                                }
                                else
                                {
                                    bookingApproved = false;
                                    rejectionReason = "Please select Yes or No for both services.";
                                }*/
                            }
                        }
                        else
                        {
                            bookingApproved = false;
                            rejectionReason = "Number of courses must be between 1 and 8.";
                        }
                    }
                    else
                    {
                        bookingApproved = false;
                        rejectionReason = "Please enter a valid number of courses.";
                    }
                }
            }

            // Display results when booking is approved
            if (bookingApproved)
            {
                lblName.Text = "Name : " + studentName;
                lblId.Text = "ID : " + studentId;
                lblCourses.Text = "Number Courses : " + numberOfCourses;
                lblStudyYear.Text = "Study Year : " + studyLevel;

                lblTuitionFee.Text = "Tuition Fee : " + tuitionFee.ToString("C2");

                lblTransportFee.Text = "Transport Fee : " + int.Parse(TxtFee.Text).ToString("C2");

                lblDiscount.Text ="Discount : " + discountAmount.ToString("C2");

                lblFinalAmount.Text = "Final Amount : " + finalAmount.ToString("C2");

                MessageBox.Show("Registration completed successfully!","Success");
            }
            else
            {
                MessageBox.Show(rejectionReason,"Validation Error");
            }
        }
    }
}
