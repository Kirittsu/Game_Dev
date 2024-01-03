using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;

namespace Game_Dev.Managers
{
    internal class AnimationManager
    {
        public static List<AnimationFrame> HeroIdle = new();
        public static List<AnimationFrame> HeroWalking = new();
        public static List<AnimationFrame> SpikesIdle = new();
        public static List<AnimationFrame> WallIdle = new();
        public static List<AnimationFrame> CaveIdle = new();

        public static AnimationFrame GetCurrentFrame(int index, BaseObject requester)
        {
            Status animationType = requester.Status;
            float scale = requester.scale;
            AnimationFrame frame = null;
            List<AnimationFrame> selectedList = null;

            switch (requester)
            {
                case Hero:
                    switch (animationType)
                    {
                        case Status.Idle:
                            selectedList = HeroIdle;
                            break;
                        case Status.Walking:
                            selectedList = HeroWalking;
                            break;
                    }
                    break;
                case Wall:
                    selectedList = WallIdle;
                    break;
                case Spikes:
                    selectedList = SpikesIdle;
                    break;
                case Cave:
                    selectedList = CaveIdle;
                    break;

            }

            frame = selectedList[index];

            if (requester is IAnimate animatable)
            {
                if (animatable.currentFrameIndex == selectedList.Count - 1)
                    animatable.currentFrameIndex = 0;
                else
                    animatable.currentFrameIndex++;

                animatable.holdFrame = 30 / selectedList.Count;
            }

            return frame;
        }

        public static void Load()
        {

        }
    }
}
