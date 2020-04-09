using System;
using System.Linq;
using System.Windows.Forms;
using tic_tac_toe.GameClasses;

namespace tic_tac_toe.forms
{
    public partial class Field3 : Form
    {
        public Game _Game;
        public Field3(Game game)
        {
            InitializeComponent();
            _Game = game;
            startWithGrayBG();
        }

        private void Field3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            startWithGrayBG();
        }

        private void startWithGrayBG()
        {
            var pb = Controls.OfType<PictureBox>().Reverse();
            foreach (var p in pb)
            {
                MessageBox.Show(p.Location.X.ToString() + "    " + p.Name + "    " + p.Location.Y.ToString());
            }
            PictureBox[,] pictureBoxes = new PictureBox[_Game.FieldSize, _Game.FieldSize];
            for (int i = 0; i < _Game.FieldSize; i++)
            {
                for (int j = 0; j < _Game.FieldSize; j++)
                {
                    pictureBoxes[i,j] = new PictureBox();
                }
            }
        }
    }
}
