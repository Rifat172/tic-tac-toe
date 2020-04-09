using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.forms;

namespace tic_tac_toe.forms
{
    public partial class Field5 : Form
    {
        public Field5()
        {
            InitializeComponent();
        }

        private void Field5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
    }
}
