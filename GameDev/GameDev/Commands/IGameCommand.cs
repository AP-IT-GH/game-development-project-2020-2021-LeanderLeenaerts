using GameDev.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Commands
{
    public interface IGameCommand
    {
        void Execute(ITransform transform,Vector2 direction);
    }
}
