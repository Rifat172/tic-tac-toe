using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe.GameClasses
{
    public class Settings
    {
        private bool isMoveX;
        private bool isPlayerVsPlayer;
        private int fieldSize;

        public int FieldSize
        {
            get => fieldSize; set
            {
                if (value >= 3 && value <= 5)
                    fieldSize = value;
            }
        }
        public bool IsMoveX { get => isMoveX; set => isMoveX = value; }
        public bool IsPlayerVsPlayer { get => isPlayerVsPlayer; set => isPlayerVsPlayer = value; }

        public Settings()
        {
            //настройки по умолчанию
            FieldSize = 3;
            IsMoveX = true;
            IsPlayerVsPlayer = true;
        }
    }
}
