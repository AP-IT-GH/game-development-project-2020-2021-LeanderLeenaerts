using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Input
{
    class KeyboardReader : IInputReader
    {
        public Vector2 ReadInput()
        {
            var direction = Vector2.Zero;

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Left) || state.IsKeyDown(Keys.Q))
            {
                direction = new Vector2(-1, 0);
            }
            if (state.IsKeyDown(Keys.Right) || state.IsKeyDown(Keys.D))
            {
                direction = new Vector2(1, 0);
            }
            return direction;
        }
    }
}
