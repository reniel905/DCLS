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
    public partial class NewLog : Form
    {
        public NewLog()
        {
            InitializeComponent();
        }

        private void Button_AddToLog_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(idNumberTextBox.Text);
            string date = logDateTimePicker.Value.ToString("MM-dd-yyyy");
            string procedure = procedureComboBox.Text;


            AccessDatabase addNewLog = new AccessDatabase(DatabaseQueries.addLog(id, date, procedure));
            addNewLog.executeDatabaseQuery();
            this.Close();
        }

     
    }
}
