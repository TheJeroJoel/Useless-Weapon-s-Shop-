using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Useless_Weapon_s_Shop
{
    public partial class ShopForm : Form
    {
        int NumberOfPens = 0;
        int NumberOfSticks = 0;
        int NumberOfPenguins = 0;
        double PenPrice = 2.50;
        double StickPrice = 1.00;
        double PenguinPrice = 35.00;
        double taxrate = 0.19;
        double subtotal = 0;
        double taxAmount = 0;
        double totalprice = 0;
        int NumofMoney = 0;
        double moneyhave;



        public ShopForm()
        {
            InitializeComponent();
            CalculateChangeButton.Enabled = false;
            PrintButton.Enabled = false;
            NewOrderButton.Enabled = false;
            Line.Enabled = false;
        }


        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton1_Click(object sender, EventArgs e)
        {
            try
            {
                NumberOfPens = Convert.ToInt32(PenTextBox.Text);
                NumberOfSticks = Convert.ToInt32(StickTextBox.Text);
                NumberOfPenguins = Convert.ToInt32(PenguinTextBox.Text);


                subtotal = NumberOfPens * PenPrice + NumberOfSticks * StickPrice + NumberOfPenguins * PenguinPrice;
                SubTotalLabel2.Text = $"{subtotal.ToString("C")}";


                taxAmount = subtotal * taxrate;
                TaxLabel2.Text = $"{taxAmount.ToString("C")}";

                totalprice = subtotal + taxAmount;
                TotalLabel2.Text = $"{totalprice.ToString("C")}";
                CalculateChangeButton.Enabled = true;
            }
            catch
            {
                SubTotalLabel2.Text = "Bogus Error";
                SubTotalLabel.Text = "Error";
            }
        }

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {

            try
            { 
              NumofMoney = Convert.ToInt32(TenderedTextBox.Text);
                moneyhave = NumofMoney - totalprice;
                ChangeLabel2.Text = $"{moneyhave.ToString("C")}";
             PrintButton.Enabled = true;
            }
            catch
            {
                ChangeLabel.Text = "Error";
                ChangeLabel2.Text = "Error";

            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Receipt.Text = "        Useless Weapon's Shop";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += "\n                  Order Number 1275";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += "\n                 October 3rd 2022";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n                 Pens x{NumberOfPens} @ {PenPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n                 Sticks x{NumberOfSticks} @ {StickPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n             Penguins x {NumberOfPenguins} @ {PenguinPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Subtotal    {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Tax         {taxrate.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Total       {totalprice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Tendered    {NumofMoney.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Change      {moneyhave.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            Receipt.Text += $"\n\n        Have a Nice Day";
            NewOrderButton.Enabled = true;
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NumberOfPens = 0;
            PenTextBox.Text = "";
            NumberOfSticks = 0;
            StickTextBox.Text = "";
            NumberOfPenguins = 0;
            PenguinTextBox.Text = "";
            SubTotalLabel2.Text = "_";
            TaxLabel2.Text = "_";
            TotalLabel2.Text = "_";
            Receipt.Text = "";
            TenderedTextBox.Text = "";
            ChangeLabel2.Text = "_";
        }
    }
}
