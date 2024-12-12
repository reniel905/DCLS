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
    public partial class SearchPatient : Form
    {
        public Boolean Cell_Passing_isLocked = true;
        public NewLog Window_Reference_NewLog;
        public SearchPatient()
        {
            InitializeComponent();
            Cell_Passing_isLocked = true;
        }

        public SearchPatient(string Setting)
        {
            InitializeComponent();
            Cell_Passing_isLocked = false;
            this.StartPosition = FormStartPosition.Manual;
            this.ControlBox = false;
            if (Setting == "Remove_Control_Bar")
            {
                Control_Bar.Visible = false;
                foreach (Button button in Control_Bar.Controls)
                {
                    button.Enabled = false;
                }
            }
        }

        private void Button_Entry_Delete_Click(object sender, EventArgs e)
        {

            if (searchPatientDataGridView.CurrentRow != null) // Ensure a row is selected
            {
                // Retrieve data from each column
                string patientId = searchPatientDataGridView.CurrentRow.Cells["patient_id"].Value.ToString();

                var Window = new SearchPatient_Delete_Confirmation(Convert.ToInt32(patientId));
                Window.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row.", "Error");
            }

           
        }

        private void Button_Entry_Load_Click(object sender, EventArgs e)
        {

            if (searchPatientDataGridView.CurrentRow != null) // Ensure a row is selected
            {
                // Retrieve data from each column
                string patientId = searchPatientDataGridView.CurrentRow.Cells["patient_id"].Value.ToString();
                string firstName = searchPatientDataGridView.CurrentRow.Cells["first_name"].Value.ToString();
                string lastName = searchPatientDataGridView.CurrentRow.Cells["last_name"].Value.ToString();
                string middleInitial = searchPatientDataGridView.CurrentRow.Cells["middle_initial"].Value.ToString();
                string gender = searchPatientDataGridView.CurrentRow.Cells["gender"].Value.ToString();
                string birthday = searchPatientDataGridView.CurrentRow.Cells["birthday"].Value.ToString();
                string contactNo = searchPatientDataGridView.CurrentRow.Cells["contact_no"].Value.ToString();
                
                var Window = new ViewPatientProfile(patientId, firstName, middleInitial, lastName, contactNo, gender, birthday, this);
                Window.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row.", "Error");
            }
           
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            loadPatients();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadPatients();
        }


        public void loadPatients()
        {

            AccessDatabase fetchPatients = new AccessDatabase(DatabaseQueries.GetAllPatients);
            searchPatientDataGridView.DataSource = fetchPatients.executeDatabaseQuery();


        }

        private void Add_Click(object sender, EventArgs e)
        {

            var Window = new NewPatient(this);
            Window.ShowDialog();


        }

        private void Button_Entry_Search_Click(object sender, EventArgs e)
        {


            int comboBoxIndex = filterSearchComboBox.SelectedIndex;

            switch (comboBoxIndex) { 
            
                case 0:
                    // First Name
                    AccessDatabase findFirstName = new AccessDatabase(DatabaseQueries.searchByFirstName(patientSearchTextBox.Text));
                    searchPatientDataGridView.DataSource = findFirstName.executeDatabaseQuery();
                    break;
                case 1:
                    // Last Name
                    AccessDatabase findLastName = new AccessDatabase(DatabaseQueries.searchByLastName(patientSearchTextBox.Text));
                    searchPatientDataGridView.DataSource = findLastName.executeDatabaseQuery();
                    break;
                case 2:
                    // Id
                    AccessDatabase findId = new AccessDatabase(DatabaseQueries.searchById(patientSearchTextBox.Text));
                    searchPatientDataGridView.DataSource = findId.executeDatabaseQuery();
                    break;
                case 3:
                    // Gender
                    AccessDatabase findGender = new AccessDatabase(DatabaseQueries.searchByGender(patientSearchTextBox.Text));
                    searchPatientDataGridView.DataSource = findGender.executeDatabaseQuery();
                    break;

            }


        }

        private void searchPatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Cell_Passing_isLocked == false && searchPatientDataGridView.CurrentRow != null) // Ensure a row is selected
            {
                // Retrieve data from each column
                string patientId = searchPatientDataGridView.CurrentRow.Cells["patient_id"].Value.ToString();

                if (Window_Reference_NewLog != null)
                {
                    Window_Reference_NewLog.idNumberTextBox_SetText(retrievePatientId());
                }
            }
        }

        public string retrievePatientId()
        {
            string patientId = searchPatientDataGridView.CurrentRow.Cells["patient_id"].Value.ToString();
            return patientId;
        }

        public void setReference_NewLog(NewLog Window)
        {
            Window_Reference_NewLog = Window;
        }
    }
}
