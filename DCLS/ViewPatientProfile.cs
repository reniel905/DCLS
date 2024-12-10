using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            middleNameTextBox.Text = middleInitial;
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
            FetchToDatabase fetchPatients = new FetchToDatabase(DatabaseQueries.getPatientHistory(patientId));
            patientHistoryDataGridView.DataSource = fetchPatients.fetchData();

        }
    }
}
