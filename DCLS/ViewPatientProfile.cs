using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCLS
{
    public partial class ViewPatientProfile : Form
    {

        int patientId;
        int age;

        private SearchPatient Window_Reference;
        public ViewPatientProfile(string id, string firstName, string middleInitial, string lastName, string contactNumber, string gender, string birthday, SearchPatient Window = null)
        {
            InitializeComponent();

            
            patientId = Convert.ToInt32(id);
            firstNameTextBox.Text = firstName;
            middleInitialTextBox.Text = middleInitial;
            lastNameTextBox.Text = lastName;
            contactNumberTextBox.Text = contactNumber;
            genderComboBox.Text = gender;
            patientIdNumber.Text = id;
            

            patientBirthday.Format = DateTimePickerFormat.Short; // Only display date
            processBirthDay(birthday);

            Window_Reference = Window;
            
        }

        private void processBirthDay(string birthday)
        {

            // Parse and set the birthday
            if (DateTime.TryParse(birthday, out DateTime parsedDate))
            {
                patientBirthday.Value = parsedDate;
                age = DateTime.Now.Year - parsedDate.Year;
                ageLabel.Text = age.ToString();
            }
            else
            {
                MessageBox.Show("Invalid birthday format.", "Error");
            }

        }


        private void loadPatientHistory()
        {

            AccessDatabase fetchPatients = new AccessDatabase(DatabaseQueries.getPatientHistory(patientId));
            patientHistoryDataGridView.DataSource = fetchPatients.executeDatabaseQuery();

        }

        private void ViewPatientProfile_Load(object sender, EventArgs e)
        {
            loadPatientHistory();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            firstNameTextBox.Enabled = true;
            middleInitialTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            contactNumberTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            patientBirthday.Enabled = true;
            button3.Enabled = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string middleName = middleInitialTextBox.Text;
            string contactNumber = contactNumberTextBox.Text;
            string gender = genderComboBox.Text;
            string birthday = patientBirthday.Text;

            AccessDatabase updatePatients = new AccessDatabase(DatabaseQueries.updatePatient(patientId, firstName, lastName, middleName, gender, birthday, contactNumber));
            updatePatients.executeDatabaseQuery();

            processBirthDay(patientBirthday.Text);

            firstNameTextBox.Enabled = false;
            middleInitialTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            contactNumberTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            patientBirthday.Enabled = false;
            button3 .Enabled = false;

            Window_Reference?.loadPatients();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            var Window = new NewLog(patientIdNumber.Text);
            Window.ShowDialog();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (patientHistoryDataGridView.CurrentRow != null) // Ensure a row is selected
            {
                // Retrieve data from each column
                string logId = patientHistoryDataGridView.CurrentRow.Cells["log_id"].Value.ToString();

                var Window = new ViewPatientProfile_Delete_Confirmation(Convert.ToInt32(logId));
                Window.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row.", "Error");
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            loadPatientHistory();

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (firstNameTextBox.Text == "")
            {
                Label_FirstName.ForeColor = Color.Red;
            }
            else
            {
                Label_FirstName.ForeColor = Color.Black;
            }
        }

        private void middleInitialTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (middleInitialTextBox.Text == "")
            {
                Label_MiddleInitial.ForeColor = Color.Red;
            }
            else
            {
                Label_MiddleInitial.ForeColor = Color.Black;
            }
        }

        private void middleInitialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (middleInitialTextBox.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent further input
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent invalid characters
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (lastNameTextBox.Text == "")
            {
                Label_LastName.ForeColor = Color.Red;
            }
            else
            {
                Label_LastName.ForeColor = Color.Black;
            }
        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (contactNumberTextBox.Text == "")
            {
                Label_ContactNumber.ForeColor = Color.Red;
            }
            else
            {
                Label_ContactNumber.ForeColor = Color.Black;
            }
        }

        private void contactNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (contactNumberTextBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (genderComboBox.Text == "")
            {
                Label_Gender.ForeColor = Color.Red;
            }
            else
            {
                Label_Gender.ForeColor = Color.Black;
            }
        }

        public void evaluateInput()
        {
            string regexPattern_Contact = @"^\d{11}$";
            Regex regex_Contact = new Regex(regexPattern_Contact);

            if (firstNameTextBox.Text == "" ||
                middleInitialTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                contactNumberTextBox.Text == "" ||
                genderComboBox.Text == "")
            {
                button3.Enabled = false;
                Label_ValidationMessage.Text = "Please fill all required fields in red.";

            }
            else
            {
                if (!regex_Contact.IsMatch(contactNumberTextBox.Text))
                {
                    button3.Enabled = false;
                    Label_ValidationMessage.Text = "Contact number must be 11 numbers long.";
                }
                else
                {
                    button3.Enabled = true;
                    Label_ValidationMessage.Text = "";
                }

            }
        }

        private void patientIdNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
