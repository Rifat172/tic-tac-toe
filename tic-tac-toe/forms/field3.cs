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
    public partial class Field3 : Form
    {
        public Field3()
        {
            InitializeComponent();
        }

        private void Field3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
    }
}
