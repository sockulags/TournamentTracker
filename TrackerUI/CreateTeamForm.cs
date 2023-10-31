using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel() { 
                FirstName = firstNameValue.Text,
                LastName = lastNameValue.Text,
                EmailAddress = emailValue.Text,
                PhoneNumber = cellphoneValue.Text};

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if(firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if(lastNameValue.Text.Length == 0)
            { return false; }

            if(emailValue.Text.Length == 0)
            {
                // TODO - Proper email validation.
                return false;
            }

            if(cellphoneValue.Text.Length == 0)
            {
                // TODO - Proper phone number validation for a swedish number.
                return false;
            }
            return true;
        }
    }
}
