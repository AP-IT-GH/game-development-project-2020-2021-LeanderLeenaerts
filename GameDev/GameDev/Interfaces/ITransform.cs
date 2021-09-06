using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Interfaces
{
    public interface ITransform                     //Used in moving a object
    {
        Vector2 Position { get; set; }
        
    }
}
