using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;

namespace Game_Dev.Managers
{
    public class AnimationManager
    {
        public static List<AnimationFrame> HeroIdle = new();
        public static List<AnimationFrame> HeroWalking = new();
        public static List<AnimationFrame> HeroAttacking = new();
        public static List<AnimationFrame> GoblinIdle = new();
        public static List<AnimationFrame> GoblinWalking = new();
        public static List<AnimationFrame> GoblinStabbing = new();
        public static List<AnimationFrame> GoblinBomberIdle = new();
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
                        case Status.Attacking:
                            selectedList = HeroAttacking;
                            break;
                    }
                    break;
                case Goblin:
                    switch (animationType)
                    {
                        case Status.Idle:
                            selectedList = GoblinIdle;
                            break;
                        case Status.Walking:
                            selectedList = GoblinWalking;
                            break;
                        case Status.Attacking:
                            selectedList = GoblinStabbing;
                            break;
                    }
                    break;
                case GoblinBomber:
                    switch (animationType)
                    {
                        case Status.Idle:
                            selectedList = GoblinBomberIdle;
                            break;
                        case Status.Walking:
                            selectedList = GoblinBomberIdle;
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
            #region Hero
            HeroIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 80, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 64, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 80, 16, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 48, 16, 16));
            #endregion

            #region Goblin
            GoblinIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 48, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 64, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 80, 0, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 24, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 62, 32, 16, 16));
            #endregion

            #region GoblinBomber
            GoblinBomberIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 0, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 16, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 32, 16, 16));
            #endregion
        }
    }
}
