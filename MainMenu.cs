using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratford
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_add_new_quote_Click(object sender, EventArgs e)
        {
            //var addQuoteForm = new AddQuote();
            //addQuoteForm.Tag = this;
            //addQuoteForm.Show();

            var addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();

            this.Hide();

        }
        private void btn_view_quotes_Click(object sender, EventArgs e)
        {
            var viewQuoteForm = new ViewAllQuotes(this);
            viewQuoteForm.Show();

            this.Hide();
        }

        private void btn_search_quotes_Click(object sender, EventArgs e)
        {
            var searchQuoteForm = new SearchQuotes(this);
            searchQuoteForm.Show();

            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
