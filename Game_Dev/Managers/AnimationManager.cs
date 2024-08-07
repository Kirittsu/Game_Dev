using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Game_Dev.Objects.GameObjects.Grass;
using Game_Dev.Objects.GameObjects.Walls;
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

        #region wall
        public static List<AnimationFrame> WallIdle = new();
        public static List<AnimationFrame> WallTopLeftIdle = new();
        public static List<AnimationFrame> WallTopIdle = new();
        public static List<AnimationFrame> WallTopRightIdle = new();
        public static List<AnimationFrame> WallLeftIdle = new();
        public static List<AnimationFrame> WallFieldIdle = new();
        public static List<AnimationFrame> WallRightIdle = new();
        public static List<AnimationFrame> WallBottomLeftIdle = new();
        public static List<AnimationFrame> WallBottomIdle = new();
        public static List<AnimationFrame> WallBottomRightIdle = new();
        public static List<AnimationFrame> WallDirtIdle = new();
        #endregion

        #region grass
        public static List<AnimationFrame> GrassIdle = new();
        public static List<AnimationFrame> GrassTopLeftIdle = new();
        public static List<AnimationFrame> GrassTopIdle = new();
        public static List<AnimationFrame> GrassTopRightIdle = new();
        public static List<AnimationFrame> GrassLeftIdle = new();
        public static List<AnimationFrame> GrassLeavesIdle = new();
        public static List<AnimationFrame> GrassRightIdle = new();
        public static List<AnimationFrame> GrassBottomLeftIdle = new();
        public static List<AnimationFrame> GrassBottomIdle = new();
        public static List<AnimationFrame> GrassBottomRightIdle = new();
        #endregion
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
                #region Wall
                case Wall:
                    selectedList = WallIdle;
                    break;
                case WallTopLeft:
                    selectedList = WallTopLeftIdle;
                    break;
                case WallTop:
                    selectedList = WallTopIdle;
                    break;
                case WallTopRight:
                    selectedList = WallTopRightIdle;
                    break;
                case WallLeft:
                    selectedList = WallLeftIdle;
                    break;
                case WallField:
                    selectedList = WallFieldIdle;
                    break;
                case WallRight:
                    selectedList = WallRightIdle;
                    break;
                case WallBottomLeft:
                    selectedList = WallBottomLeftIdle;
                    break;
                case WallBottom:
                    selectedList = WallBottomIdle;
                    break;
                case WallBottomRight:
                    selectedList = WallBottomRightIdle;
                    break;
                case WallDirt:
                    selectedList = WallDirtIdle;
                    break;
                #endregion

                #region Grass
                case Grass:
                    selectedList = GrassIdle;
                    break;
                case GrassTopLeft:
                    selectedList = GrassTopLeftIdle;
                    break;
                case GrassTop:
                    selectedList = GrassTopIdle;
                    break;
                case GrassTopRight:
                    selectedList = GrassTopRightIdle;
                    break;
                case GrassLeft:
                    selectedList = GrassLeftIdle;
                    break;
                case GrassLeaves:
                    selectedList = GrassLeavesIdle;
                    break;
                case GrassRight:
                    selectedList = GrassRightIdle;
                    break;
                case GrassBottomLeft:
                    selectedList = GrassBottomLeftIdle;
                    break;
                case GrassBottom:
                    selectedList = GrassBottomIdle;
                    break;
                case GrassBottomRight:
                    selectedList = GrassBottomRightIdle;
                    break;
                #endregion

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
            }, 16, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 48, 32, 16, 16));
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

            #region Walls
            WallIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 144, 448, 32, 32));
            WallTopLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 0, 32, 32));
            WallTopIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 0, 32, 32));
            WallTopRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 0, 32, 32));
            WallLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 32, 32, 32));
            WallFieldIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 32, 32, 32));
            WallRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 32, 32, 32));
            WallBottomLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 64, 32, 32));
            WallBottomIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 64, 32, 32));
            WallBottomRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 64, 32, 32));
            WallDirtIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 32, 32, 32));
            #endregion

            #region Grass
            GrassIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 32, 160, 32, 32));
            GrassTopLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 128, 32, 32));
            GrassTopIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 128, 32, 32));
            GrassTopRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 128, 32, 32));
            GrassLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 160, 32, 32));
            GrassLeavesIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 160, 32, 32));
            GrassRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 160, 32, 32));
            GrassBottomLeftIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 128, 192, 32, 32));
            GrassBottomIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 160, 192, 32, 32));
            GrassBottomRightIdle.Add(new AnimationFrame(new List<Hitbox>
            {
                new Hitbox(2, 3, new Vector2(1, 2)),
                new Hitbox(6, 5, new Vector2(3, 0)),
                new Hitbox(2, 3, new Vector2(9, 2)),
                new Hitbox(12, 19, new Vector2(0, 5)),
            }, 195, 192, 32, 32));








            #endregion
        }
    }
}
