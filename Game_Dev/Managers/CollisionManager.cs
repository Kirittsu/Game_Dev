using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Game_Dev.Managers
{
    public class CollisionManager
    {
        public static Vector2 MovementCollisionChecks(Character character, Vector2 direction, List<BaseObject> gameObjects)
        {
            // First, resolve horizontal movement
            Vector2 newPosition = character.MinPosition + new Vector2(direction.X, 0);
            if (CheckCollision(character, newPosition, gameObjects))
            {
                direction.X = 0; // Stop horizontal movement
            }

            // Then, resolve vertical movement
            newPosition = character.MinPosition + new Vector2(0, direction.Y);
            if (CheckCollision(character, newPosition, gameObjects))
            {
                direction.Y = 0; // Stop vertical movement
            }

            return direction;
        }

        private static bool CheckCollision(Character character, Vector2 newPosition, List<BaseObject> gameObjects)
        {
            var gameObjectsCopy = new List<BaseObject>(gameObjects);
            foreach (var gameObject in gameObjectsCopy)
            {
                Hitbox ch = character.CurrentFrame.Hitbox;
                Hitbox gh = gameObject.CurrentFrame.Hitbox;

                float x1 = newPosition.X + ch.Offset.X;
                float y1 = newPosition.Y + ch.Offset.Y;

                float x2 = gameObject.MinPosition.X + gh.Offset.X;
                float y2 = gameObject.MinPosition.Y + gh.Offset.Y;

                Rectangle h1 = new Rectangle((int)x1, (int)y1, ch.Box.Width, ch.Box.Height);
                Rectangle h2 = new Rectangle((int)x2, (int)y2, gh.Box.Width, gh.Box.Height);

                if (character != gameObject && gameObject.isUnwalkable && !GameStateManager.loading)
                {
                    if (h1.Intersects(h2))
                    {
                        if (character is Hero && gameObject is Cave) GameStateManager.NextLevel(5);

                        return true; // Collision detected
                    }

                    if (character is Hero)
                    {
                        if (x1 + ch.Box.Width >= ScreenManager.ScreenWidth)
                        {
                            if (GameStateManager.LevelIndex == 5) return true;
                            else GameStateManager.NextLevel(-1, 1);
                        }
                        else if(y1 + ch.Box.Height >= ScreenManager.ScreenHeight)
                        {
                            if (GameStateManager.LevelIndex == 5) return true;
                            else GameStateManager.NextLevel(-1, 2);
                        }
                        else if (y1 <= 0) GameStateManager.NextLevel(GameStateManager.LevelIndex - 1, 3);
                        else if (x1 <= 0) GameStateManager.NextLevel(GameStateManager.LevelIndex - 1, 4);
                    }
                }
                if (character is Hero && h1.Intersects(h2)) 
                {
                    if (gameObject is Spikes spikes && spikes.isExtended == true)
                    {
                        throw new NotImplementedException();
                    }
                }

            }
            return false; // No collision
        }

    }
}
