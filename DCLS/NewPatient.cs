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
        private SearchPatient Window_Reference;
        /*public NewPatient()
        {
            InitializeComponent();
            createPatientBirthdate.MaxDate = DateTime.Today;
        }*/

        public NewPatient(SearchPatient Window = null)
        {
            InitializeComponent();
            Window_Reference = Window;
            createPatientBirthdate.MaxDate = DateTime.Today;
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

                Window_Reference?.loadPatients();

                var Window = new NewPatient_Completion(newCustomerId);
                Window.ShowDialog();
                Close();
            }      
        }

        private void createFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (createFirstNameTextBox.Text == "")
            {
                Label_FirstName.ForeColor = Color.Red;
            } else
            {
                Label_FirstName.ForeColor = Color.Black;
            }
        }

        private void createMiddleInitialTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (createMiddleInitialTextBox.Text == "")
            {
                Label_MiddleInitial.ForeColor = Color.Red;
            }
            else
            {
                Label_MiddleInitial.ForeColor = Color.Black;
            }
        }

        private void createMiddleInitialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (createMiddleInitialTextBox.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent further input
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent invalid characters
            }
        }

        private void createLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (createLastNameTextBox.Text == "")
            {
                Label_LastName.ForeColor = Color.Red;
            }
            else
            {
                Label_LastName.ForeColor = Color.Black;
            }
        }

        private void createContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (createContactNumberTextBox.Text == "")
            {
                Label_ContactNumber.ForeColor = Color.Red;
            }
            else
            {
                Label_ContactNumber.ForeColor = Color.Black;
            }
        }

        private void createGenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (createGenderComboBox.Text == "")
            {
                Label_Gender.ForeColor = Color.Red;
            }
            else
            {
                Label_Gender.ForeColor = Color.Black;
            }
        }

        private void createContactNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (createContactNumberTextBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void evaluateInput()
        {
            string regexPattern_Contact = @"^\d{11}$";
            Regex regex_Contact = new Regex(regexPattern_Contact);

            if (createFirstNameTextBox.Text == "" ||
                createLastNameTextBox.Text == "" ||
                createMiddleInitialTextBox.Text == "" ||
                createContactNumberTextBox.Text == "" ||
                createGenderComboBox.Text == "" ||
                createPatientBirthdate.Text == "")
            {
                Button_Register.Enabled = false;
                Label_ValidationMessage.Text = "Please fill all required fields in red.";
                
            } else
            {
                if (!regex_Contact.IsMatch(createContactNumberTextBox.Text))
                {
                    Button_Register.Enabled = false;
                    Label_ValidationMessage.Text = "Contact number must be 11 numbers long.";
                } else
                {
                    Button_Register.Enabled = true;
                    Label_ValidationMessage.Text = "";
                }
                
            }
        }
    }
}
