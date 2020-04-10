using System;
using System.Windows.Forms;
using tic_tac_toe.forms;
using tic_tac_toe.GameClasses;

namespace tic_tac_toe
{
    public partial class menu : Form
    {
        public Settings settingsGame;

        public menu()
        {
            InitializeComponent();
            settingsGame = new Settings();
        }

        private void play_Click(object sender, EventArgs e)
        {
            game.Start();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form setting = new settingsForm(game);
            setting.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
