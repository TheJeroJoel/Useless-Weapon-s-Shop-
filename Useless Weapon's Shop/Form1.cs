using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public ShopForm()
        {
            InitializeComponent();
        }

       
        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

    }
}
