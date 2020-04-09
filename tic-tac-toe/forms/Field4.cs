using System.Windows.Forms;
using tic_tac_toe.GameClasses;

namespace tic_tac_toe.forms
{
    public partial class Field4 : Form
    {
        public Game gameFromField4;
        public Field4(Game game)
        {
            InitializeComponent();
            gameFromField4 = game;
        }

        private void Field4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
    }
}
