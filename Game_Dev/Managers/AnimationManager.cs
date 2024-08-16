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
        public static List<AnimationFrame> HeroAttackIdle = new();
        public static List<AnimationFrame> HeroDarknessIdle = new();
        public static List<AnimationFrame> GoblinIdle = new();
        public static List<AnimationFrame> GoblinWalking = new();
        public static List<AnimationFrame> GoblinStabbing = new();
        public static List<AnimationFrame> GoblinBomberIdle = new();
        public static List<AnimationFrame> GoblinBomberThrow = new();
        public static List<AnimationFrame> SpikesIdle = new();
        public static List<AnimationFrame> BombIdle = new();
        public static List<AnimationFrame> ControlDisplayIdle = new();
        public static List<AnimationFrame> KeyIdle = new();
        public static List<AnimationFrame> ChestIdle = new();

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

        #region Cave
        public static List<AnimationFrame> CaveIdle = new();
        public static List<AnimationFrame> CaveDoorIdle = new();
        public static List<AnimationFrame> CaveWallTopLeftIdle = new();
        public static List<AnimationFrame> CaveWallHorizontalIdle = new();
        public static List<AnimationFrame> CaveWallTopRightIdle = new();
        public static List<AnimationFrame> CaveWallVerticalIdle = new();
        public static List<AnimationFrame> CaveWallIdle = new();
        public static List<AnimationFrame> CaveWallTopIdle = new();
        public static List<AnimationFrame> CaveWallDarkIdle = new();
        public static List<AnimationFrame> CaveWallDarkerIdle = new();
        public static List<AnimationFrame> CaveVoidIdle = new();

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
                case HeroAttack:
                    selectedList = HeroAttackIdle;
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
                        case Status.Attacking:
                            selectedList = GoblinBomberThrow;
                            break;
                    }
                    break;
                case Bomb:
                    selectedList = BombIdle;
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
                case Cave:
                    selectedList = CaveIdle;
                    break;
                case CaveDoor:
                    selectedList = CaveDoorIdle;
                    break;
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
                case CaveVoid:
                    selectedList = CaveVoidIdle;
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

                case HeroDarkness:
                    selectedList = HeroDarknessIdle;
                    break;

                case ControlDisplay:
                    selectedList = ControlDisplayIdle;
                    break;

                case Key:
                    selectedList = KeyIdle;
                    break;

                case Chest:
                    selectedList = ChestIdle;
                    break;
            }

            frame = selectedList[index];

            if (requester is IAnimate animatable)
            {
                if (animatable.currentFrameIndex == selectedList.Count - 1)
                    animatable.currentFrameIndex = 0;
                else
                    animatable.currentFrameIndex++;

                if (requester is HeroAttack) animatable.holdFrame = 60 / selectedList.Count;

                else if (requester is Bomb) animatable.holdFrame = 150 / selectedList.Count;

                    else animatable.holdFrame = 30 / selectedList.Count;
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

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 0, 230, 16, 16));

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 16, 230, 16, 16));

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 32, 230, 16, 16));

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 48, 230, 16, 16));

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 64, 230, 16, 16));

            HeroAttackIdle.Add(new AnimationFrame(new Hitbox(16, 12, new Vector2(-8, -9)), 80, 230, 16, 16));

            HeroDarknessIdle.Add(new AnimationFrame(new Hitbox(0, 0, new Vector2(0, 0)), 0, 0, 1728, 1024));
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

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 0, 0, 16, 16));

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 16, 0, 16, 16));

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 32, 0, 16, 16));

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 48, 0, 16, 16));

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 64, 0, 16, 16));

            GoblinBomberThrow.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(0, 0)), 80, 0, 16, 16));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 0, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 8, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 16, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 24, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 32, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 40, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 48, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 56, 0, 8, 8));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 39, 0, 1, 1));

            BombIdle.Add(new AnimationFrame(new Hitbox(16, 16, new Vector2(-8, -8)), 39, 0, 1, 1));
            #endregion

            #region Spikes
            SpikesIdle.Add(new AnimationFrame(new Hitbox(20, 20, new Vector2(-6, -6)), 481, 65, 32, 32));

            SpikesIdle.Add(new AnimationFrame(new Hitbox(20, 20, new Vector2(-6, -6)), 449, 65, 32, 32));

            SpikesIdle.Add(new AnimationFrame(new Hitbox(20, 20, new Vector2(-6, -6)), 417, 65, 32, 32));

            SpikesIdle.Add(new AnimationFrame(new Hitbox(20, 20, new Vector2(-6, -6)), 385, 65, 32, 32));
            #endregion

            #region Key
            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 0, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 32, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 64, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 96, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 128, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 160, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 192, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 224, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 256, 0, 32, 32));

            KeyIdle.Add(new AnimationFrame(new Hitbox(8, 8, new Vector2(0, 0)), 288, 0, 32, 32));
            #endregion

            #region Chest
            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 0, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 16, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 32, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 48, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 64, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 80, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 96, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 112, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 128, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 144, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 160, 0, 16, 8));

            ChestIdle.Add(new AnimationFrame(new Hitbox(32, 8, new Vector2(0, 0)), 176, 0, 16, 8));
            #endregion
            #region Walls
            WallIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-8, -20)), 144, 448, 32, 32));

            WallTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 128, 0, 32, 32));
            
            WallTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 160, 0, 32, 32));
            
            WallTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 192, 0, 32, 32));
            
            WallLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 128, 32, 32, 32));
            
            WallFieldIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 32, 32, 32, 32));
            
            WallRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 192, 32, 32, 32));
            
            WallBottomLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 128, 64, 32, 32));
            
            WallBottomIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 160, 64, 32, 32));
            
            WallBottomRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 192, 64, 32, 32));
            
            WallDirtIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 160, 32, 32, 32));
            #endregion

            #region Grass
            GrassIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 32, 160, 32, 32));
            
            GrassTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 128, 32, 32));
            
            GrassTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 128, 32, 32));
            
            GrassTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 192, 128, 32, 32));
            
            GrassLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 160, 32, 32));
            
            GrassLeavesIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 160, 32, 32));
            
            GrassRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 192, 160, 32, 32));
            
            GrassBottomLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 128, 192, 32, 32));
            
            GrassBottomIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 160, 192, 32, 32));
            
            GrassBottomRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, 0)), 192, 192, 32, 32));
            #endregion

            #region Cave
            CaveIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(0, -30)), 32, 352, 32, 32));

            CaveDoorIdle.Add(new AnimationFrame(new Hitbox(32, 42, new Vector2(0, -30)), 32, 384, 32, 32));

            CaveWallTopLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 64, 0, 32, 32));

            CaveWallHorizontalIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 96, 0, 32, 32));

            CaveWallTopRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 128, 0, 32, 32));

            CaveWallVerticalIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 64, 32, 32, 32));

            CaveWallIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -20)), 96, 32, 32, 32));

            CaveWallTopIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -3)), 128, 64, 32, 32));

            CaveWallDarkIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 320, 128, 32, 32));

            CaveWallDarkerIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 192, 160, 32, 32));

            CaveFloorLeftIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 128, 320, 32, 32));

            CaveFloorIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 160, 320, 32, 32));

            CaveFloorRightIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 192, 320, 32, 32));

            CaveVoidIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 0, 0, 32, 32));
            #endregion

            #region UI
            ControlDisplayIdle.Add(new AnimationFrame(new Hitbox(32, 32, new Vector2(-10, -15)), 0, 0, 388, 385));
            #endregion
        }
    }
}
