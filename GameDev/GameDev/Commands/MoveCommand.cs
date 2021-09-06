using GameDev.CollisionDetection;
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
        public Vector2 prevPosition;
        private CollisionManager cManager;
        //private Game1 game;
        

        public MoveCommand()
        {
            this.speed = new Vector2(2, 2);                                                                         //Multiplier for the speed of the character
        }
        public void Execute(ITransform transform, Vector2 direction)
        {
            direction *= speed;
            prevPosition = transform.Position;


            //Simple test for collision logic (uses hardcoded coordinates)
            //if (prevPosition.X > 10)                                                                          
            //{
            //    var temp = prevPosition - new Vector2(-3, prevPosition.Y);
            //    transform.Position -= temp;
            //}
            //else
            //{
            transform.Position += direction;
            //}

            //Basic test with CollisionManager
            //if (cManager.CheckCollision(Hero.CollisionRectangle,Block.CollisionRectangle))                                    
            //{
            //  
            //}


            //Test import game1 instance => Not Implemented implemented exeptions
            /*for (int x = 0; x < 9; x++)                                                                                                           
            {                                                                                                                                     
               for (int y = 0; y < 6; y++)
                {
                    if (game.level.tileArray[x, y] == 1)
                    {
                            if (cManager.CheckCollision(game.hero.CollisionRectangle, game.level.blokArray[x,y].CollisionRectangle))          
                            {
                            var temp = prevPosition;
                                transform.Position -= temp;

                        }
                    }

                }
            }*/


        }
    }
}
