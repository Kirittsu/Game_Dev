using Game_Dev.Characters;
using Game_Dev.Characters.Enemy;
using Game_Dev.Characters.Player;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects.Dungeon;
using Game_Dev.Objects.GameObjects.Grass;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

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

                if (character != gameObject && !GameStateManager.loading)
                {
                    if (h1.Intersects(h2) && gameObject.isUnwalkable)
                    {
                        if (character is Hero)
                        {
                            if (gameObject is Cave) GameStateManager.NextLevel(6);
                            if (gameObject is Chest) GameStateManager.NextLevel(8);
                            if (gameObject is Key) 
                            { 
                                GameStateManager.Remove(gameObject);
                                AudioManager.PlayKeySound();
                                Key.keyObtained = true;
                            }
                        }

                        if (character is Bomb) return false;

                        if ((character is Hero && gameObject is Bomb) || (character is Bomb && gameObject is Hero) || (character is Hero && gameObject is HeroAttack))
                        {
                            return false;
                        }

                        if (character is Goblin && gameObject is Hero attackedHero && character.Status == Status.Attacking)
                        {
                            attackedHero.Respawn();
                        }

                        if ((character is Goblin) && gameObject is HeroAttack)
                        {
                            GameStateManager.Remove(character);
                            AudioManager.PlayDyingSound();
                        }
                      
                        return true; // Collision detected
                    }

                    if (h1.Intersects(h2) && character is Goblin && gameObject is Spikes spikes && spikes.isExtended)
                    {
                        return true;
                    }

                    if (character is Hero)
                    {
                        if (x1 + ch.Box.Width >= ScreenManager.ScreenWidth)
                        {
                            if (GameStateManager.LevelIndex == 5)
                            {
                                GameStateManager.NextLevel(GameStateManager.LevelIndex - 1, 3);
                            }
                            else
                            {
                                GameStateManager.NextLevel(-1, 1);
                            }
                        }
                        else if (y1 + ch.Box.Height >= ScreenManager.ScreenHeight)
                        {
                            if (GameStateManager.LevelIndex == 6)
                            {
                                return true;
                            }
                            else
                            {
                                GameStateManager.NextLevel(-1, 2);
                            }
                        }
                        else if (y1 <= 0)
                        {
                            GameStateManager.NextLevel(GameStateManager.LevelIndex - 1, 3);
                        }
                        else if (x1 <= 0)
                        {
                            if (GameStateManager.LevelIndex == 4)
                            {
                                GameStateManager.NextLevel(-1, 2);
                            }
                            else
                            {
                                GameStateManager.NextLevel(GameStateManager.LevelIndex - 1, 4);
                            }
                        }
                    }
                }

                if (character is Hero hero && h1.Intersects(h2) && !GameStateManager.loading)
                {
                    if (gameObject is Spikes spikes && spikes.isExtended)
                    {
                        hero.Respawn();
                    }

                    if (gameObject is Bomb bomb && bomb.isExploded)
                    {
                        hero.Respawn();
                    }
                }
            }
            return false; // No collision
        }
    }
}