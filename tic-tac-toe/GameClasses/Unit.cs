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
        toe,
        finish 
    }

    public class Unit
    {
        Image image;
        State state;
        
        public Image Image { get => image; set => image = value; }
        internal State State { get => state; set => state = value; }

        public Unit(Image image)
        {
            Image = image;
            State = State.background;
        }
    }
}
