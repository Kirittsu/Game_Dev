﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Managers
{
    public static class ScreenManager
    {
        public static int ScreenWidth { get; set; }
        public static int ScreenHeight { get; set; }

        public static void Draw(SpriteBatch spriteBatch)
        {
            GameStateManager.CurrentScene().Draw(spriteBatch);
            foreach (GameElement gElement in GameStateManager.gameElements.OrderBy(o => o.DrawOrder))
            {
                //handled by BaseObject/Movable
                gElement.Draw(spriteBatch);
            }
            GameStateManager.loading = false;
        }

        public static void Update(GameTime gameTime)
        {
            if (GameStateManager.UIToggle)
            {
                UIManager.Update(gameTime);
            }
            else
            {
                var hero = GameStateManager.gameObjects.OfType<Hero>().FirstOrDefault();

                foreach (BaseObject gObject in GameStateManager.gameObjects.ToList())
                {
                    if (gObject is Character character)
                    {
                        character.Update(gameTime);

                        if (character is Goblin goblin && hero != null)
                        {
                            goblin.Update(gameTime, hero, GameStateManager.gameObjects);
                        }

                        if (character is GoblinBomber goblinBomber && hero != null)
                        {
                            goblinBomber.Update(gameTime, hero, GameStateManager.gameObjects);
                        }
                    }

                    if (gObject is IAnimate animatable)
                    {
                        if (animatable.holdFrame <= 0)
                        {
                            gObject.CurrentFrame = AnimationManager.GetCurrentFrame(animatable.currentFrameIndex, gObject);
                        }
                        else
                        {
                            animatable.holdFrame--;
                        }
                    }
                }
            }
        }


        public static void Load(int entrance)
        {
            if (!GameStateManager.loading)
            {
                GameStateManager.loading = true;
                GameStateManager.gameObjects.Clear();
                GameStateManager.gameElements.Clear();
                GameStateManager.CurrentScene().LoadScene(entrance);
                GameStateManager.CurrentScene().LoadMap();
            }
        }
    }
}