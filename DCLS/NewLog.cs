using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCLS
{
    public partial class NewLog : Form
    {
        private ViewLog Window_Reference;
        private SearchPatient Window_Reference_List;
        public NewLog(ViewLog Window = null, SearchPatient Window_List = null)
        {
            this.TopMost = true;
            InitializeComponent();
            Window_Reference = Window;
            Window_Reference_List = Window_List;

            this.FormClosing += new FormClosingEventHandler(NewLog_FormClosing);
        }

        private void Button_AddToLog_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(idNumberTextBox.Text);
            string date = logDateTimePicker.Value.ToString("MM-dd-yyyy");
            string procedure = procedureComboBox.Text;

            Window_Reference?.loadLogs();

            AccessDatabase addNewLog = new AccessDatabase(DatabaseQueries.addLog(id, date, procedure));
            addNewLog.executeDatabaseQuery();

            Window_Reference_List.Close();
            this.Close();
        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (idNumberTextBox.Text == "")
            {
                Label_ID.ForeColor = Color.Red;
            }
            else
            {
                Label_ID.ForeColor = Color.Black;
            }
        }

        private void idNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent invalid characters
            }
        }

        public void evaluateInput()
        {
           

            if (idNumberTextBox.Text == "" ||
                procedureComboBox.Text == "")
            {
                Button_AddToLog.Enabled = false;
                Label_ValidationMessage.Text = "Please fill all required fields in red.";

            }
            else
            {
                Button_AddToLog.Enabled = true;
                Label_ValidationMessage.Text = "";
            }
        }

        private void procedureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluateInput();
            if (procedureComboBox.Text == "")
            {
                Label_Procedure.ForeColor = Color.Red;
            }
            else
            {
                Label_Procedure.ForeColor = Color.Black;
            }
        }

        private void Button_ViewPatients_Click(object sender, EventArgs e)
        {
            Window_Reference_List.Close();
            this.Close();
        }

        private void NewLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Window_Reference_List != null && !Window_Reference_List.IsDisposed)
            {
                Window_Reference_List.Close();
            }
        }

        public void idNumberTextBox_SetText(string Text)
        {
            idNumberTextBox.Text = Text;
        }
    }
}
