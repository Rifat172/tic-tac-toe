using System;
using System.Windows.Forms;
using tic_tac_toe.GameClasses;

namespace tic_tac_toe.forms
{
    public partial class settingsForm : Form
    {
        public Settings Setting;
        public settingsForm(Settings setting)
        {
            InitializeComponent();
            Setting = setting;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
            this.Hide();
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting.FieldSize = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Setting.FieldSize = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setting.FieldSize = 5;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Setting.IsMoveX = true;
        }

        private void O_Click(object sender, EventArgs e)
        {
            Setting.IsMoveX = false;
        }
    }
}
