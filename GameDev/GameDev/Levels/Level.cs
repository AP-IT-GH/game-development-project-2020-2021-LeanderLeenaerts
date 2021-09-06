using GameDev.Levels;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Levels.Level
{
    public class Level
    {

        public Texture2D texture;                                                                                           //Texture For the blocks


        public byte[,] tileArray = new Byte[,]                                                                             //Array for positions
        {
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {0,0,0,0,0,0 },
            {1,1,1,1,1,1 },
        };

        private Blok[,] blokArray = new Blok[9, 6];                                                                       //For use of different blocks

        private ContentManager content;

        public Level(ContentManager content)
        {
            this.content = content;

            InitializeContent();
        }

        private void InitializeContent()                                                                                  //Add texture
        {
            texture = content.Load<Texture2D>("blok");
        }


        public void CreateWorld()                                                                                        //Create the world (loop through all tiles)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (tileArray[x, y] == 1)
                    {
                        blokArray[x, y] = new Blok(texture, new Vector2(y * 256, x * 64));
                    }
                }
            }
        }

        public void DrawWorld(SpriteBatch spritebatch)                                                                      //Draw the world (loop through all tiles)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (blokArray[x, y] != null)
                    {
                        blokArray[x, y].Draw(spritebatch);
                    }
                }
            }

        }
    }
}
