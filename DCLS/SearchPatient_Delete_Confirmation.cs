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
    public partial class SearchPatient_Delete_Confirmation : Form
    {

        int patientId;

        private SearchPatient Window_Reference;
        public SearchPatient_Delete_Confirmation(int id, SearchPatient Window = null)
        {

            this.patientId = id;
            InitializeComponent();
            Window_Reference = Window;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ConfirmDeletion_Click(object sender, EventArgs e)
        {
            AccessDatabase deletePatient = new AccessDatabase(DatabaseQueries.deletePatient(patientId));
            deletePatient.executeDatabaseQuery();
            Window_Reference?.loadPatients();
            this.Close();
        }
    }
}
