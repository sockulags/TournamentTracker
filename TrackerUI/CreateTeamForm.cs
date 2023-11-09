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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Lucas", LastName = "Skog" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Linda", LastName = "Brolin" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Test", LastName = "Testsson" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Ada", LastName = "Lovelace" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bo", LastName = "Sten" });
        }

        public void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel()
                {
                    FirstName = firstNameValue.Text,
                    LastName = lastNameValue.Text,
                    EmailAddress = emailValue.Text,
                    PhoneNumber = cellphoneValue.Text
                };

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
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            { return false; }

            if (emailValue.Text.Length == 0)
            {
                // TODO - Proper email validation.
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                // TODO - Proper phone number validation for a swedish number.
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
