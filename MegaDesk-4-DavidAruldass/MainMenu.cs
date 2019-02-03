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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
                
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void newquotebutton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void viewquotesbutton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addNewQuoteForm = new ViewAllQuotes();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void searchquotesbutton_Click(object sender, EventArgs e)
        {
            SearchQuotes addNewQuoteForm = new SearchQuotes();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
         }
        private void exitbutton_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

