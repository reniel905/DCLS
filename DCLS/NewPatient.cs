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
            var Window = new NewPatient_Completion();
            Window.ShowDialog();
        }
    }
}
