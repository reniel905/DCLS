﻿using System;
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
    public partial class NewLog_Type : Form
    {
        public NewLog_Type()
        {
            InitializeComponent();
        }

        private void Button_Patient_New_Click(object sender, EventArgs e)
        {
            Close();
            var Window = new NewPatient();
            Window.ShowDialog();
        }

        private void Button_Patient_Old_Click(object sender, EventArgs e)
        {

            Close();
            var Window = new NewLog();
            Window.ShowDialog();

        }
    }
}
