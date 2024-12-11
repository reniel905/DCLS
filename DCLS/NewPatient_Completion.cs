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
    public partial class NewPatient_Completion : Form
    {

        string newPatientId;

        public NewPatient_Completion(string id)
        {
            this.newPatientId = id;
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NewPatient_Completion_Load(object sender, EventArgs e)
        {

            message.Text = "Patient is successfully registered under id number " + newPatientId;

        }

        private void Button_Credits_Click(object sender, EventArgs e)
        {
            Close();
            var Window = new NewLog();
            Window.ShowDialog();
        }
    }
}
