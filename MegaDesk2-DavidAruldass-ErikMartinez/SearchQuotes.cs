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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // gets the list of the surface material && populate matrials combobox
            var matrial = new List<Desk.Surface>(); // just telling them this is where we will work to get the code. 
            matrial = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            comboBox1.DataSource = matrial;
            comboBox1.SelectedIndex = -1;

            string orderQuotes = @"quotes.json";
            using (StreamReader writeOrderQuotes = new StreamReader(orderQuotes))

            {
                int j = 0;
                while (!writeOrderQuotes.EndOfStream)
                {
                    string quoteLine = writeOrderQuotes.ReadLine();
                    if (quoteLine.Length == 0)
                    {
                        MessageBox.Show("The quote is empty");
                        return;
                    }

                    string[] quoteData = quoteLine.Split(',');
                    dataGridView1.Rows.Add();

                    for (var i = 0; i < 8; i++)
                    {
                        dataGridView1[i, j].Value = quoteData[i];
                    }
                    j++;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String quotes = @"quotes.json";

            StreamReader streamReader = new StreamReader(quotes);

            int row = 0;

            dataGridView1.Rows.Clear();

            while (!streamReader.EndOfStream)

            {
                string rowData = streamReader.ReadLine();

                if (rowData.Length > 0)

                {
                    string[] values = rowData.Split(',');

                    if (values[5] == comboBox1.SelectedValue.ToString())

                    {
                        dataGridView1.Rows.Add();

                        for (int i = 0; i < 8; i++)

                        {
                            dataGridView1[i, row].Value = values[i];
                        }
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("There are no quotes to show.");
                }
            }

        }
    }

}

