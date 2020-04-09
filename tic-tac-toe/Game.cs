using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tic_tac_toe.forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public class Game
    {
        private int fieldSize;
        private Image move;
        private bool isAI;

        public int FieldSize
        {
            get => fieldSize; set
            {
                if (value >= 3 && value <= 5)
                    fieldSize = value;
            }
        }
        public Image Move { get => move; set => move = value; }
        public bool IsAI { get => isAI; set => isAI = value; }

        public Game(int FieldS, Image FirstMove, bool Default)
        {
            FieldSize = FieldS;
            Move = FirstMove;
            IsAI = Default;
        }

        public void Play()
        {
            Form FieldForm;
            if (FieldSize == 3)
            {
                FieldForm = new Field3();
            }
            else if (FieldSize == 4)
            {
                FieldForm = new Field4();
            }
            else
            {
                FieldForm = new Field5();
            }
            FieldForm.Show();
        }
    }
}
