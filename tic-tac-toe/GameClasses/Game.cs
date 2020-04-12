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
        private int countX;
        private int countO;

        public Unit[,] Units { get => units; set => units = value; }
        public Settings Settings { get => settings; set => settings = value; }
        public bool IsNowStepX { get => isNowStepX; set => isNowStepX = value; }
        public int CountX { get => countX; set => countX = value; }
        public int CountO { get => countO; set => countO = value; }

        public Game(Settings setting)
        {
            Settings = setting;
        }

        public void Start()
        {
            Form FieldForm;
            Init();
            IsNowStepX = Settings.IsMoveX;
            CountO = 0;
            CountX = 0;
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
            CountO = 0;
            CountX = 0;
            foreach (Unit item in Units)
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
                if (IsNowStepX)
                {
                    Units[x, y].State = State.cross;
                    Units[x, y].Image = Properties.Resources.cross_gray;
                    CountX++;
                    IsNowStepX = false;
                }
                else
                {
                    Units[x, y].State = State.toe;
                    Units[x, y].Image = Properties.Resources.toe_gray;
                    CountO++;
                    IsNowStepX = true;
                }

                thisImage.Image = this.Units[x, y].Image;
            }

            if (CountX >= Settings.FieldSize || CountO >= Settings.FieldSize)
            {
                int KeyWinner = CheckWinner();
                if (KeyWinner == 1)
                {
                    MessageBox.Show("Победитель X");
                    FillUnitsWithState(State.finish);
                }
                else if (KeyWinner == 0)
                {
                    MessageBox.Show("Победитель O");
                    FillUnitsWithState(State.finish);
                }
            }
            if(CountX + CountO == Settings.FieldSize*Settings.FieldSize)
            {
                MessageBox.Show("Ничья");
                FillUnitsWithState(State.finish);
            }
        }

        private void FillUnitsWithState(State _state)
        {
            foreach(var Unit in Units)
            {
                Unit.State = _state;
            }
        }

        /// <summary>
        /// Возвращает 1 если выйграл X
        /// 0 если выйграл O
        /// </summary>
        /// <returns></returns>
        private int CheckWinner()
        {
            int size = Settings.FieldSize;
            int x = 0, y = 0;

            int HorX = 0;
            int HorO = 0;
            int VerX = 0;
            int VerO = 0;
            int diaX = 0;
            int diaO = 0;
            int revX = 0;
            int revO = 0;

            for (y = 0; y < size; y++)
            {
                for (x = 0; x < size; x++)
                {
                    if (Units[y, x].State == State.cross)
                        HorX++;
                    else if (Units[y, x].State == State.toe)
                        HorO++;

                    if (Units[x, y].State == State.cross)
                        VerX++;
                    else if (Units[x, y].State == State.toe)
                        VerO++;

                    if (Units[x, x].State == State.cross)
                        diaX++;
                    else if (Units[x, x].State == State.toe)
                        diaO++;

                    if (Units[size - 1 - x, x].State == State.cross)
                        revX++;
                    else if (Units[size - 1 - x, x].State == State.toe)
                        revO++;
                }

                if (HorX == size)
                    return 1;
                else if (HorO == size)
                    return 0;
                HorO = HorX = 0;

                if (VerX == size)
                    return 1;
                else if (VerO == size)
                    return 0;
                VerX = VerO = 0;

                if (diaX == size)
                    return 1;
                else if (diaO == size)
                    return 0;
                diaX = diaO = 0;

                if (revX == size)
                    return 1;
                else if (revO == size)
                    return 0;
                revX = revO = 0;
            }
            return -1;
        }

        private void Init()
        {
            Units = new Unit[Settings.FieldSize, Settings.FieldSize];
            for (int i = 0; i < Settings.FieldSize; i++)
            {
                for (int j = 0; j < Settings.FieldSize; j++)
                {
                    Units[i, j] = new Unit(Properties.Resources.background_gray);
                }
            }
        }
    }
}
