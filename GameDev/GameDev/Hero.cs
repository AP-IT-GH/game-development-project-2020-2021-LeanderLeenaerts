using GameDev.Animations;
using GameDev.Commands;
using GameDev.Input;
using GameDev.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    public class Hero : IGameObject, ITransform
    {
        private Texture2D heroTexture;
        private Animation animation;
        private IInputReader inputReader;                                                                                           //DIP => Hero is niet afhankelijk van een specifieke klasse maar van een abstractie (classe bij aanmaken hero in Game1)

        public Vector2 Position { get; set; }

        private IGameCommand moveCommand;

        //Constructor
        //texture = sprite 
        //reader = way of control
        //command = To implement MoveCommand
        public Hero(Texture2D texture, IInputReader reader, IGameCommand command)                                                   //DIP
        {
            heroTexture = texture;
            animation = new Animation();
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 567, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(567, 0, 1134, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1134, 0, 1701, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1701, 0, 2268, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 556, 567, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(567, 556, 1134, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1134, 556, 1701, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1701, 556, 2268, 1112)));
            //speed = new Vector2(1, 1);

            this.inputReader = reader;
            this.moveCommand = command;
        }

        public void Update(GameTime gameTime)
        {
            var direction = inputReader.ReadInput();                                                                                            //Read input from chosen device (chosen when initiated by Game1)
            Move(direction);                                                                                                                    //Calls Move method 
            animation.Update(gameTime);                                                                                                         // Update animations through animation class
        }

        private void Move(Vector2 _direction)
        {           
            moveCommand.Execute(this, _direction);                                                                                              //SR => Moving the character is done through command classes
        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            spriteBatch.Draw(heroTexture, Position, animation.CurrentFrame.SourceRectangle, Color.White);                                           //Texture, Position, rectangle, Color (not used)
        }
    }
}
