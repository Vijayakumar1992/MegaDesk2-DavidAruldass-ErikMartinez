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
using Newtonsoft.Json;

namespace MegaDesk_3_DavidAruldass
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            string orderQuotes = @"quotes.json";
            using (StreamReader writeOrderQuotes = new StreamReader(orderQuotes))
            {
                var quotes = writeOrderQuotes.ReadToEnd();

                List<DeskQuote> aQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                quoteGrid.DataSource = aQuotes.Select(d => new
                {
                    QuoteDate = d.QuoteDate,
                    CustomerName = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    NumOfDrawers = d.Desk.NumberOfDrawers,
                    DeskMaterial = d.Desk.SurfaceMaterial,
                    Shipping = d.DeliveryType,
                    Price = d.PriceAmount
                }).ToList();
            }
        }
    }
}
