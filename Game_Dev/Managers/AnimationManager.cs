using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Game_Dev.Objects.GameObjects.Dungeon.CaveWalls;
using Game_Dev.Objects.GameObjects.Dungeon.CaveFloor ;
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

        #region Cave
        public static List<AnimationFrame> CaveWallTopLeftIdle = new();
        public static List<AnimationFrame> CaveWallHorizontalIdle = new();
        public static List<AnimationFrame> CaveWallTopRightIdle = new();
        public static List<AnimationFrame> CaveWallVerticalIdle = new();
        public static List<AnimationFrame> CaveWallIdle = new();
        public static List<AnimationFrame> CaveWallTopIdle = new();
        public static List<AnimationFrame> CaveWallDarkIdle = new();
        public static List<AnimationFrame> CaveWallDarkerIdle = new();

        public static List<AnimationFrame> CaveFloorLeftIdle = new();
        public static List<AnimationFrame> CaveFloorIdle = new();
        public static List<AnimationFrame> CaveFloorRightIdle = new();
        #endregion

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

                #region Cave
                case CaveWallTopLeft:
                    selectedList = CaveWallTopLeftIdle;
                    break;
                case CaveWallHorizontal:
                    selectedList = CaveWallHorizontalIdle;
                    break;
                case CaveWallTopRight:
                    selectedList = CaveWallTopRightIdle;
                    break;
                case CaveWallVertical:
                    selectedList = CaveWallVerticalIdle;
                    break;
                case CaveWall:
                    selectedList = CaveWallIdle;
                    break;
                case CaveWallTop:
                    selectedList = CaveWallTopIdle;
                    break;
                case CaveWallDark:
                    selectedList = CaveWallDarkIdle;
                    break;
                case CaveWallDarker:
                    selectedList = CaveWallDarkerIdle;
                    break;


                case CaveFloorLeft:
                    selectedList = CaveFloorLeftIdle;
                    break;
                case CaveFloor:
                    selectedList = CaveFloorIdle;
                    break;
                case CaveFloorRight:
                    selectedList = CaveFloorRightIdle;
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
            HeroIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 80, 16, 16));

            HeroIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 80, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 64, 16, 16, 16));

            HeroWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 80, 16, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 48, 16, 16));

            HeroAttacking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 48, 16, 16));
            #endregion

            #region Goblin
            GoblinIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 48, 16, 16));

            GoblinIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 48, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 64, 0, 16, 16));

            GoblinWalking.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 80, 0, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 32, 16, 16));

            GoblinStabbing.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 32, 16, 16));
            #endregion

            #region GoblinBomber
            GoblinBomberIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 32, 16, 16));

            GoblinBomberIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 32, 16, 16));
            #endregion

            #region Walls
            WallIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 144, 448, 32, 32));

            WallTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 0, 32, 32));
            
            WallTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 0, 32, 32));
            
            WallTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 0, 32, 32));
            
            WallLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 32, 32, 32));
            
            WallFieldIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 32, 32, 32, 32));
            
            WallRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 32, 32, 32));
            
            WallBottomLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 64, 32, 32));
            
            WallBottomIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 64, 32, 32));
            
            WallBottomRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 64, 32, 32));
            
            WallDirtIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 32, 32, 32));
            #endregion

            #region Grass
            GrassIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 32, 160, 32, 32));
            
            GrassTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 128, 32, 32));
            
            GrassTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 128, 32, 32));
            
            GrassTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 128, 32, 32));
            
            GrassLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 160, 32, 32));
            
            GrassLeavesIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 160, 32, 32));
            
            GrassRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 160, 32, 32));
            
            GrassBottomLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 192, 32, 32));
            
            GrassBottomIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 192, 32, 32));
            
            GrassBottomRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 195, 192, 32, 32));
            #endregion

            #region Cave
            CaveIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 32, 355, 32, 32));

            CaveWallTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 64, 0, 32, 32));

            CaveWallHorizontalIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 96, 0, 32, 32));

            CaveWallTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 0, 32, 32));

            CaveWallVerticalIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 64, 32, 32, 32));

            CaveWallIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 96, 32, 32, 32));

            CaveWallTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 64, 32, 32));

            CaveWallDarkIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 320, 128, 32, 32));

            CaveWallDarkerIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 192, 160, 32, 32));

            CaveFloorLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 320, 32, 32));

            CaveFloorIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 320, 32, 32));

            CaveFloorRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 192, 320, 32, 32));
            #endregion
        }
    }
}
