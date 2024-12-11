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
    public partial class ViewLog : Form
    {
        public ViewLog()
        {
            InitializeComponent();
        }

        private void Button_AddLog_Click(object sender, EventArgs e)
        {
            var Window = new NewLog_Type(this);
            Window.ShowDialog();
        }

        private void ViewLog_Load(object sender, EventArgs e)
        {
            loadLogs();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadLogs();
        }

        public void loadLogs()
        {

            AccessDatabase displayLogs = new AccessDatabase(DatabaseQueries.GetAllLogsWithName);
            patientLogsDataGridView.DataSource = displayLogs.executeDatabaseQuery();

        }
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {


            if (comboBox1.Text.Equals("All")) {

                loadLogs();

            }
            else
            {

                AccessDatabase viewAllExtraction = new AccessDatabase(DatabaseQueries.filterLogBy(comboBox1.Text));
                patientLogsDataGridView.DataSource = viewAllExtraction.executeDatabaseQuery();

            }
        }
    }
}
