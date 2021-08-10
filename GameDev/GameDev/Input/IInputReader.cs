using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Input
{
    public interface IInputReader
    {
        Vector2 ReadInput();
    }
}
