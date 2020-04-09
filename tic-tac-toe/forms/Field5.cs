using System.Windows.Forms;
using tic_tac_toe.GameClasses;

namespace tic_tac_toe.forms
{
    public partial class Field5 : Form
    {
        public Game gameFromField5;
        public Field5(Game game)
        {
            InitializeComponent();
            gameFromField5 = game;
        }

        private void Field5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
    }
}
