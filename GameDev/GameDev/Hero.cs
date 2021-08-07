using GameDev.Animations;
using GameDev.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class Hero:IGameObject 
    {
        Texture2D heroTexture;
        Animation animation;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animation = new Animation();
            animation.AddFrame(new AnimationFrame(new Rectangle(0,0,567,556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(567, 0, 1134, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1134, 0, 1701, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1701, 0, 2268, 556)));
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 556, 567, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(567, 556, 1134, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1134, 556, 1701, 1112)));
            animation.AddFrame(new AnimationFrame(new Rectangle(1701, 556, 2268, 1112)));
        }

        public void Update()
        {
            animation.Update();
        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            spriteBatch.Draw(heroTexture, new Vector2(10, 10), animation.CurrentFrame.SourceRectangle, Color.White);                                           //Texture, Position, rectangle, Color (not used)
        }
    }
}
