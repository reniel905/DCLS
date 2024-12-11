using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCLS
{
    public partial class ViewPatientProfile : Form
    {

        int patientId;
        int age;

        public ViewPatientProfile(string id, string firstName, string middleInitial, string lastName, string contactNumber, string gender, string birthday)
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

        }

        private void Add_Click(object sender, EventArgs e)
        {

            var Window = new NewLog();
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
    }
}
