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
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            var item = Controls.OfType<PictureBox>();
            for (int i = 0, j = item.Count(); i < j; i++)
            {
                var rem = item.First();
                rem.Click -= new EventHandler(thisImage_Click);
                Controls.Remove(rem);
                rem.Dispose();
            }
            startWithGrayBG();
            _Game.ReStart();
        }

        private void startWithGrayBG()
        {
            PictureBox[,] pictureBoxes = new PictureBox[_Game.Settings.FieldSize, _Game.Settings.FieldSize];
            for (int i = 0; i < _Game.Settings.FieldSize; i++)
            {
                for (int j = 0; j < _Game.Settings.FieldSize; j++)
                {
                    pictureBoxes[i, j] = new PictureBox();
                    pictureBoxes[i, j].Location = new System.Drawing.Point(11 + (105 * i), 10 + (105 * j));
                    pictureBoxes[i, j].Size = new System.Drawing.Size(100, 100);
                    pictureBoxes[i, j].Name = "p" + j + i;
                    pictureBoxes[i, j].Image = Properties.Resources.background_gray;
                    pictureBoxes[i, j].Click += thisImage_Click;
                    Controls.Add(pictureBoxes[i, j]);
                }
            }
        }

        private void thisImage_Click(object sender, EventArgs e)
        {
            _Game.Process((PictureBox)sender);
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            Form menu = Application.OpenForms[0];
            Hide();
            menu.Show();
        }
    }
}
