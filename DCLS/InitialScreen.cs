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
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            var Window = new SearchPatient();
            Window.ShowDialog();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            var Window = new NewPatient();
            Window.ShowDialog();
        }

        private void Button_Logs_Click(object sender, EventArgs e)
        {
            var Window = new ViewLog();
            Window.ShowDialog();
        }
    }
}
