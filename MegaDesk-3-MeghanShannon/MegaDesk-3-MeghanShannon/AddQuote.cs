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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            /*
             * This form provides the user input interface.
             */
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void deskWidth_TextChanged(object sender, EventArgs e)
        {
            /*int i = 0;
            string deskWidthString = deskWidth.Text;
            const int WIDTHMIN = 24;
            const int WIDTHMAX = 96;
            bool isNumber = int.TryParse(deskWidthString, out i);
            
            if (isNumber == false || i < WIDTHMIN || i > WIDTHMAX)
            {
                deskWidth.BackColor = Color.Red;
                Console.Beep();
            }
            else
            {
                deskWidth.BackColor = Color.White;
            }*/

        }

        private void deskWidth_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNum(deskWidth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                deskWidth.Select(0, deskWidth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(deskWidth, errorMsg);
            }
        }

        private void deskWidth_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(deskWidth, "");
        }
        public bool ValidNum(string deskWidthString, out string errorMessage)
        {
            int i = 0;
            const int WIDTHMIN = 24;
            const int WIDTHMAX = 96;
            bool isNumber = int.TryParse(deskWidthString, out i);

            // Confirm that the e-mail address string is not empty.
            if (deskWidthString.Length == 0)
            {
                deskWidth.BackColor = Color.Red;
                Console.Beep();
                errorMessage = "Width is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (isNumber == true && i > WIDTHMIN && i < WIDTHMAX)
            {
                errorMessage = "";
                return true;                
            }

            deskWidth.BackColor = Color.Red;
            Console.Beep();
            errorMessage = "Width must be a number between 24 and 96.";
            return false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void deskDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void deskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char deskDepthChar = char.Parse(deskDepth.Text);
            int i = 0;
            const int WIDTHMIN = 12;
            const int WIDTHMAX = 48;
            
            bool isNumber = Char.IsDigit(deskDepthChar);

            if (isNumber == false || deskDepthChar < WIDTHMIN || deskDepthChar > WIDTHMAX)
            {
                deskWidth.BackColor = Color.Red;
                Console.Beep();
            }
            else
            {
                deskWidth.BackColor = Color.White;
            }
        }
    }
}
