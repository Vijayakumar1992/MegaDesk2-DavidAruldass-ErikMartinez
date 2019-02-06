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
                int j = 0;
                while (!writeOrderQuotes.EndOfStream)
                {
                    string quoteLine = writeOrderQuotes.ReadLine();
                    if (quoteLine.Length ==0)
                    {
                        MessageBox.Show("The quote is empty");
                        return;
                    }

                    string[] quoteData = quoteLine.Split(',');
                    quoteGrid.Rows.Add();


                    for ( var i =0; i < quoteData.Length; i++)
                    {
                        quoteGrid[i, j].Value = quoteData[i];
                    }

                    j++;
                }


            }
        }
    }
}
