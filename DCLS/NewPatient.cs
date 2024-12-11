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
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {


            string firstName = createFirstNameTextBox.Text;
            string lastName = createLastNameTextBox.Text;
            string middleInitial = createMiddleInitialTextBox.Text;
            long contact = long.Parse(createContactNumberTextBox.Text);
            string gender = createGenderComboBox.Text;
            string birthday = createPatientBirthdate.Text;

            AccessDatabase addNewPatient = new AccessDatabase(DatabaseQueries.addPatient(firstName, lastName, middleInitial, gender, birthday, contact));
            addNewPatient.executeDatabaseQuery();

            // should return the current id has been created.

            var Window = new NewPatient_Completion();
            Window.ShowDialog();
        }
    }
}
