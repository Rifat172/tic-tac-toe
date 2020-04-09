using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tic_tac_toe.forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe.GameClasses
{
    public class Game
    {
        private int fieldSize;
        private bool isAI;
        private Unit[,] units;

        public int FieldSize
        {
            get => fieldSize; set
            {
                if (value >= 3 && value <= 5)
                    fieldSize = value;
            }
        }
        public bool IsAI { get => isAI; set => isAI = value; }
        public Unit[,] Units { get => units; set => units = value; }

        public Game(int FieldS, bool Default)
        {
            FieldSize = FieldS;
            IsAI = Default;
        }

        public void Play()
        {
            Form FieldForm;
            Init();
            if (FieldSize == 3)
            {
                FieldForm = new Field3(this);
            }
            else if (FieldSize == 4)
            {
                FieldForm = new Field4(this);
            }
            else
            {
                FieldForm = new Field5(this);
            }
            FieldForm.Show();
        }

        private void Init()
        {
            Units = new Unit[FieldSize, FieldSize];
            for(int i = 0; i < FieldSize; i++)
            {
                for(int j = 0; j < FieldSize; j++)
                {
                    Units[i, j] = new Unit(i,j, Properties.Resources.background_gray);
                }
            }
        }
    }
}
