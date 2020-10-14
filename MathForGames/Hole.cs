using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Hole : Actor
    {
        public Hole(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.Cyan)
            : base(x, y, icon, color)
        {

        }

        public override void Update()
        {
            base.Update();
        }
    }
}
