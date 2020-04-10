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
        private Settings settings;
        private Unit[,] units;
        private bool isNowStepX;

        public Unit[,] Units { get => units; set => units = value; }
        public Settings Settings { get => settings; set => settings = value; }
        public bool IsNowStepX { get => isNowStepX; set => isNowStepX = value; }

        public Game(Settings setting)
        {
            Settings = setting;
        }

        public void Start()
        {
            Form FieldForm;
            Init();
            IsNowStepX = Settings.IsMoveX;
            if (Settings.FieldSize == 3)
            {
                FieldForm = new Field3(this);
            }
            else if (Settings.FieldSize == 4)
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
            IsNowStepX = Settings.IsMoveX;
            foreach(Unit item in Units)
            {
                item.State = State.background;
            }
        }

        public void Process(PictureBox sender)
        {
            PictureBox thisImage = sender;
            int x = thisImage.Name[1] - '0';
            int y = thisImage.Name[2] - '0';

            if (Units[x, y].State == State.background)
            {
                if(IsNowStepX)
                {
                    Units[x, y].State = State.cross;
                    Units[x, y].Image = Properties.Resources.cross_gray;
                    IsNowStepX = false;
                }
                else
                {
                    Units[x, y].State = State.toe;
                    Units[x, y].Image = Properties.Resources.toe_gray;
                    IsNowStepX = true;
                }

                thisImage.Image = this.Units[x, y].Image;
            }
        }

        private void Init()
        {
            Units = new Unit[Settings.FieldSize, Settings.FieldSize];
            for (int i = 0; i < Settings.FieldSize; i++)
            {
                for (int j = 0; j < Settings.FieldSize; j++)
                {
                    Units[i, j] = new Unit(i, j, Properties.Resources.background_gray);
                }
            }
        }
    }
}
