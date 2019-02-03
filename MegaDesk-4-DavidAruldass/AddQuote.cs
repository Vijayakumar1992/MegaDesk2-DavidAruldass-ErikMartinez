using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_DavidAruldass
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void CancelButton_click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
         

        private void widthupanddown_Validating(object sender, CancelEventArgs e)
        {
            //size of desk in width(min 24"; max 96"
            if (widthupanddown.Value < 24 || widthupanddown.Value > 96)
            {
                MessageBox.Show("Please enter a number between 24 to 96", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depthupdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            //size of desk in  depth (min 12"; max 48")
            if (depthupdown.Value < 12 || depthupdown.Value > 48)
            {
                depthwarning.Text = "Please enter a number between 12 to 48";
            }
            else
            {
                depthwarning.Text = " ";
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            // gets the list of the desk && populate matrials combobox
            var matrial = new List<Desk.Surface>(); // just telling them this is where we will work to get the code. 
            matrial = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            Surface_Matrial.DataSource = matrial;
            Surface_Matrial.SelectedIndex = -1;

            // gets the list of the desk && populate matrials combobox
            var DeliveryDays = new List<DeskQuote.Delivery>(); // just telling them this is where we will work to get the code. 
            DeliveryDays = Enum.GetValues(typeof(DeskQuote.Delivery)).Cast<DeskQuote.Delivery>().ToList();
            Delivery_Time.DataSource = DeliveryDays;
            Delivery_Time.SelectedIndex = -1;



        }



        private void Get_NewQuote_Click(object sender, EventArgs e)
        {
            //This if statement is to check if the add quote form is complete.
            if (CustomerName.Text == "" || Delivery_Time.Text == "")
            {
                MessageBox.Show("Please fill all the values", "Form Imcomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gets the information of the desk
            Desk NameOfNewDesk = new Desk();
            NameOfNewDesk.Width = widthupanddown.Value;
            NameOfNewDesk.Depth = depthupdown.Value;
            NameOfNewDesk.NumberOfDrawers = (int)Num_Drawers.Value;
            NameOfNewDesk.SurfaceMaterial = (Desk.Surface)Surface_Matrial.SelectedValue;

            //gets the information entered by the user. 
            DeskQuote NewDeskQuote = new DeskQuote();
            NewDeskQuote.CustomerName = CustomerName.Text;
            NewDeskQuote.DeliveryType = (DeskQuote.Delivery)Delivery_Time.SelectedValue;

            // get the quote amount and add amount to quote
            NewDeskQuote.Desk = NameOfNewDesk;
            DateTime today = DateTime.Today;
            NewDeskQuote.QuoteDate = today;
            NewDeskQuote.PriceAmount = NewDeskQuote.GetQuote();



            try
            {
                // add quote to file
                AddQuoteToFile(NewDeskQuote);

                //show displayquote form
                DisplayQuote NewDeskForm = new DisplayQuote(NewDeskQuote);
                NewDeskForm.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.Message);
            }
        }
        //gets the new quote and adds it to the new file
        public void AddQuoteToFile( DeskQuote NewDeskQuote)
        {
            string quotesFile = @"quotes.txt";
            using (StreamWriter streamWriter = File.AppendText(quotesFile))
            {
                // this will display it when we open the displayquote and leave it as long as the program is open. 
                streamWriter.WriteLine(
                    $"{NewDeskQuote.QuoteDate}," +
                    $"{NewDeskQuote.CustomerName}," +
                    $"{NewDeskQuote.Desk.Width}," +
                    $"{NewDeskQuote.Desk.Depth}," +                    
                    $"{NewDeskQuote.Desk.NumberOfDrawers}," +
                    $"{NewDeskQuote.Desk.SurfaceMaterial}," +
                    $"{NewDeskQuote.DeliveryType}," +
                    $"{NewDeskQuote.PriceAmount}");
            }

           
        }
    }
}

        







