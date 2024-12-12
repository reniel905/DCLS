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
    public partial class ViewPatientProfile_Delete_Confirmation : Form
    {

        int logId;
        private ViewPatientProfile Window_Reference;

        public ViewPatientProfile_Delete_Confirmation(int id, ViewPatientProfile Window = null)
        {
            this.logId = id;
            InitializeComponent();
            Window_Reference = Window;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void Button_ConfirmDeletion_Click(object sender, EventArgs e)
        {
            AccessDatabase deleteLog = new AccessDatabase(DatabaseQueries.deleteLog(logId));
            deleteLog.executeDatabaseQuery();
            Window_Reference?.loadPatientHistory();
            Close();
        }
    }
}
