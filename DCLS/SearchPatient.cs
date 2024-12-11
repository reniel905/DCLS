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
        public SearchPatient()
        {
            InitializeComponent();
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
                
                var Window = new ViewPatientProfile(patientId, firstName, middleInitial, lastName, contactNo, gender, birthday);
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


        void loadPatients()
        {

            AccessDatabase fetchPatients = new AccessDatabase(DatabaseQueries.GetAllPatients);
            searchPatientDataGridView.DataSource = fetchPatients.executeDatabaseQuery();


        }

        private void Add_Click(object sender, EventArgs e)
        {

            var Window = new NewPatient();
            Window.ShowDialog();


        }
    }
}
