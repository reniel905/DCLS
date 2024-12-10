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
            var Window = new NewLog_Type();
            Window.ShowDialog();
        }
    }
}
