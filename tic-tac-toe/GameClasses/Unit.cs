using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe.GameClasses
{
    enum State
    {
        background,
        cross,
        toe
    }

    public class Unit
    {
        int x;
        int y;
        Image image;
        State state;

        public int X
        {
            get => x; set
            {
                if (value >= 0 && value <= 4)
                    x = value;
            }
        }
        public int Y
        {
            get => y; set
            {
                if (value >= 0 && value <= 4)
                    y = value;
            }
        }

        public Image Image { get => image; set => image = value; }
        internal State State { get => state; set => state = value; }

        public Unit(int x, int y, Image image)
        {
            X = x;
            Y = y;
            Image = image;
            State = State.background;
        }
    }
}
