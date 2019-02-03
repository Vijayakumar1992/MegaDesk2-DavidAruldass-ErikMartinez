using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DavidAruldass
{
    public partial class DisplayQuote : Form
    {

        private DeskQuote _deskQuote;



        public DisplayQuote(DeskQuote NewDeskQuote)
        {
            //getting all the data entered in to get a newQuote
            InitializeComponent();

            _deskQuote = NewDeskQuote;


            widthupanddown.Value = NewDeskQuote.Desk.Width;
            depthupdown.Value = NewDeskQuote.Desk.Depth;
            Surface_Matrial.SelectedValue = NewDeskQuote.Desk.SurfaceMaterial;
            Num_Drawers.SelectedValue = NewDeskQuote.Desk.NumberOfDrawers;
            Delivery_Time.SelectedValue = NewDeskQuote.DeliveryType;
            CustomerName.Text = NewDeskQuote.CustomerName;
            TotalPrice.Text = NewDeskQuote.PriceAmount.ToString();         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
