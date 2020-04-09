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

namespace tic_tac_toe
{
    public partial class menu : Form
    {
        public Game game;
        public menu()
        {
            InitializeComponent();
            game = new Game(3, Properties.Resources.cross_gray, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form setting = new settings(game);
            setting.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Play();
            this.Hide();
        }
    }
}
