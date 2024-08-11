using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Game_Dev.Managers
{
    public class CollisionManager
    {
        public static Vector2 MovementCollisionChecks(BaseObject character, Vector2 direction, List<BaseObject> gameObjects)
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

        private static bool CheckCollision(BaseObject character, Vector2 newPosition, List<BaseObject> gameObjects)
        {
            foreach (var gameObject in gameObjects)
            {
                if (character != gameObject && gameObject.isUnwalkable)
                {
                    Hitbox ch = character.CurrentFrame.Hitbox;
                    Hitbox gh = gameObject.CurrentFrame.Hitbox;

                    float x1 = newPosition.X + ch.Offset.X;
                    float y1 = newPosition.Y + ch.Offset.Y;

                    float x2 = gameObject.MinPosition.X + gh.Offset.X;
                    float y2 = gameObject.MinPosition.Y + gh.Offset.Y;

                    Rectangle h1 = new Rectangle((int)x1, (int)y1, ch.Box.Width, ch.Box.Height);
                    Rectangle h2 = new Rectangle((int)x2, (int)y2, gh.Box.Width, gh.Box.Height);

                    if (h1.Intersects(h2))
                    {
                        return true; // Collision detected
                    }
                }
            }
            return false; // No collision
        }
    }
}
