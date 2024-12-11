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

        public SearchPatient_Delete_Confirmation(int id)
        {

            this.patientId = id;
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ConfirmDeletion_Click(object sender, EventArgs e)
        {
            AccessDatabase deletePatient = new AccessDatabase(DatabaseQueries.deletePatient(patientId));
            deletePatient.executeDatabaseQuery();
            this.Close();
        }
    }
}
