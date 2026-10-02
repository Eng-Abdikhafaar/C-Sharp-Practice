using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_ONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Amount_Click(object sender, EventArgs e)
        {
            // creating variables
            String Food1, Food2;
            Double P_Food1, P_Food2, Amount, TotalAmount, SalesTax, Tips, NetAmount;

            // creating const variables
            const double salesTaxRate = 5;
            double tipsRate = int.Parse(TxtTIpsAmount.Text);


            try
            {
                // Taking the data from the User
                Food1 = TxtFood1.Text;
                Food2 = TxtFood2.Text;
                P_Food1 = double.Parse(TxtPriceFood1.Text);
                P_Food2 = double.Parse(TxtPriceFood2.Text);

                // process

                // calculating total amount
                Amount = P_Food1 + P_Food2;

                // calculating the tax amount
                SalesTax = Amount * (salesTaxRate / 100);
                Tips = Amount * (tipsRate / 100);

                // calculating Total Amount for pay
                TotalAmount = Amount + SalesTax + Tips;

                // Calculating the net Amount
                NetAmount = TotalAmount - SalesTax - Tips;

                // Displaying The Amounts
                LblSalesText.Text = SalesTax.ToString("c");
                LblTipsAmount.Text = Tips.ToString("c");
                LblTotalAmount.Text = TotalAmount.ToString("c");
                LblNetAmount.Text = NetAmount.ToString("c");
            }

            catch (Exception)
            {
                MessageBox.Show("Enter Valid Values");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clearing the text boxes
            TxtFood1.Clear();
            TxtFood2.Text = "";
            TxtPriceFood1.Text = String.Empty;
            TxtPriceFood2.Clear();
            TxtTIpsAmount.Clear();

            // clearing the labels
            LblSalesText.Text = String.Empty;
            LblTipsAmount.Text = String.Empty;
            LblTotalAmount.Text = String.Empty;
            LblNetAmount.Text = String.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
