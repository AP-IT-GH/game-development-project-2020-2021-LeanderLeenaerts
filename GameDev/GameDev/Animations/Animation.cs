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

        public Animation()
        {
            frames = new List<AnimationFrame>();
        }

        public void AddFrame(AnimationFrame animationframe)
        {
            frames.Add(animationframe);
            CurrentFrame = frames[0];
        }

        public void Update()
        {
            CurrentFrame = frames[counter];
            counter++;

            if (counter >= frames.Count) 
            {
                counter = 0;
            }
        }
    }
}
