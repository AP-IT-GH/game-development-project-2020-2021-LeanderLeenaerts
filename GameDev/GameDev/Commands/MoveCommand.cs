using GameDev.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Commands
{
    public class MoveCommand : IGameCommand
    {
        public Vector2 speed;

        public MoveCommand()
        {
            this.speed = new Vector2(2, 0);                                                                         //Multiplier for the speed of the character
        }
        public void Execute(ITransform transform, Vector2 direction)
        {
            direction *= speed;
            transform.Position += direction;
        }
    }
}
