using System;
using System.Windows.Forms;

namespace DCLS
{
    public partial class ViewPatientProfile : Form
    {

        int patientId;

        public ViewPatientProfile(string id, string firstName, string middleInitial, string lastName, string contactNumber, string gender, string birthday)
        {
            InitializeComponent();

            int age = 0;
            this.patientId = Convert.ToInt32(id);

            firstNameTextBox.Text = firstName;
            middleInitialTextBox.Text = middleInitial;
            lastNameTextBox.Text = lastName;
            contactNumberTextBox.Text = contactNumber;
            genderComboBox.Text = gender;
            

            patientBirthday.Format = DateTimePickerFormat.Short; // Only display date

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

        private void ViewPatientProfile_Load(object sender, EventArgs e)
        {
            AccessDatabase fetchPatients = new AccessDatabase(DatabaseQueries.getPatientHistory(patientId));
            patientHistoryDataGridView.DataSource = fetchPatients.executeDatabaseQuery();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            firstNameTextBox.Enabled = true;
            middleInitialTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            contactNumberTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            patientBirthday.Enabled = true;
           
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

            firstNameTextBox.Enabled = false;
            middleInitialTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            contactNumberTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            patientBirthday.Enabled = false;

        }
    }
}
