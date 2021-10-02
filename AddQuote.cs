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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        private string customerName;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
 
            surfaceMaterialInput.DataSource = Enum.GetValues(typeof(DesktopMaterial));

            rushOrderInput.DataSource = Enum.GetValues(typeof(ShippingType));
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                customerName = nameInput.Text;
            }
            catch(Exception exception)
            {
                Console.WriteLine("{0} Failed", exception);
            }
        }
    }
}
