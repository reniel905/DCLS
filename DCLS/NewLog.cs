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
            this.Close();
        }
    }
}
