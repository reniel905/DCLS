using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCLS
{
    public partial class NewPatient : Form
    {
        
        public NewPatient()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            var errorWindow = new NewPatient_Error();

            string firstName = createFirstNameTextBox.Text;
            string lastName = createLastNameTextBox.Text;
            string middleInitial = createMiddleInitialTextBox.Text;
            string contact = createContactNumberTextBox.Text;
            string gender = createGenderComboBox.Text;
            string birthday = createPatientBirthdate.Text;
            string regexPattern = @"^[\d]{7,15}[\s\-]?[\d\s\-]*$";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(createContactNumberTextBox.Text))
            {
                if (createFirstNameTextBox.Text == "" ||
                createLastNameTextBox.Text == "" ||
                createMiddleInitialTextBox.Text == "" ||
                createContactNumberTextBox.Text == "" ||
                createGenderComboBox.Text == "" ||
                createPatientBirthdate.Text == "")
                {
                    errorWindow.ShowDialog();
                }

                else
                {
                    errorWindow.ShowDialog();
                }
            }
            
            else
            {
                AccessDatabase addNewPatient = new AccessDatabase(DatabaseQueries.addPatient(firstName, lastName, middleInitial, gender, birthday, contact));
                DataTable id = addNewPatient.executeDatabaseQuery();

                string newCustomerId = id.Rows[0]["NewID"].ToString();

                // should return the current id has been created.

                var Window = new NewPatient_Completion(newCustomerId);
                Window.ShowDialog();
                Close();
            }      
        }
    }
}
