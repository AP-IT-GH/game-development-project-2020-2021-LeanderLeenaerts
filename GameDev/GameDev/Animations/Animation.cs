using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev.Animations
{
    public class Animation
    {
        public AnimationFrame CurrentFrame { get; set; }

        private List<AnimationFrame> frames;

        private int counter;
        private double frameMovement = 0;

        //Constructor
        //frames = list to store all frames to cycle through
        public Animation()
        {
            frames = new List<AnimationFrame>();
        }

        //Add frames to the List
        public void AddFrame(AnimationFrame animationframe)
        {
            frames.Add(animationframe);
            CurrentFrame = frames[0];
        }

        //Update the screen every frame
        public void Update(GameTime gameTime)
        {
            CurrentFrame = frames[counter];

            frameMovement += CurrentFrame.SourceRectangle.Width * gameTime.ElapsedGameTime.TotalSeconds;                            //Frame independed movement
            if (frameMovement >= CurrentFrame.SourceRectangle.Width/10)                                                             // Change the "devided by" number to change draw speed (bigger = slower)
            {
                counter++;
                frameMovement = 0;
            }

            if (counter >= frames.Count)                                                                                            //Reset counter
            {
                counter = 0;
            }
        }
    }
}
