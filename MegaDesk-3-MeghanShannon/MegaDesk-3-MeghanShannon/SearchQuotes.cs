using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MeghanShannon
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            /*
             * This user interface form allows the user to pick a material type from a combo box and displays all quotes with that material.
             */
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
