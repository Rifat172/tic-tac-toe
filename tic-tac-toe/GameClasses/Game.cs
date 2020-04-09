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
        private Image move;
        private int step;
        private bool isFirstX;
        private int countOfX;
        private int countOfO;

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
        public Image Move { get => move; set => move = value; }
        public int Step { get => step; set => step = value; }
        public bool IsFirstX { get => isFirstX; set => isFirstX = value; }
        public int CountOfX { get => countOfX; set => countOfX = value; }
        public int CountOfO { get => countOfO; set => countOfO = value; }

        public Game(int FieldS, bool Default, Image DefaultImageMove)
        {
            FieldSize = FieldS;
            IsAI = Default;
            Move = DefaultImageMove;
            IsFirstX = true;
        }

        public void Start()
        {
            step = 0;
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

        public void ReStart()
        {
            step = 0;
        }

        public void Process(PictureBox sender)
        {
            PictureBox thisImage = sender;
            int x = thisImage.Name[1] - '0';
            int y = thisImage.Name[2] - '0';
            if (Units[x, y].State == State.background)
            {
                if (step == 0)
                {
                    if (IsFirstX)
                    {
                        Units[x, y].State = State.cross;
                        CountOfX++;
                    }
                    else
                    {
                        Units[x, y].State = State.toe;
                        countOfO++;
                    }
                    Units[x, y].Image = Move;
                }
                else if (CountOfX > CountOfO)
                {
                    Units[x, y].State = State.toe;
                    Units[x, y].Image = Properties.Resources.toe_gray;
                }
                else if (CountOfX < CountOfO)
                {
                    Units[x, y].State = State.cross;
                    Units[x, y].Image = Properties.Resources.cross_gray;
                }
                step++;
                thisImage.Image = this.Units[x, y].Image;
            }
        }

        private void Init()
        {
            Units = new Unit[FieldSize, FieldSize];
            for (int i = 0; i < FieldSize; i++)
            {
                for (int j = 0; j < FieldSize; j++)
                {
                    Units[i, j] = new Unit(i, j, Properties.Resources.background_gray);
                }
            }
        }
    }
}
