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
    public partial class settings : Form
    {
        public Game GameFromSettings;
        public settings(Game gameFromMenu)
        {
            InitializeComponent();
            GameFromSettings = gameFromMenu;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
            this.Hide();
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameFromSettings.FieldSize = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GameFromSettings.FieldSize = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameFromSettings.FieldSize = 5;
        }
    }
}
