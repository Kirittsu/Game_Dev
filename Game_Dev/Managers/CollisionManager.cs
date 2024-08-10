using Game_Dev.Interfaces;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Managers
{
    public class CollisionManager
    {
        public static Vector2 MovementCollisionChecks(BaseObject character, Vector2 direction, List<BaseObject> gameObjects)
        {
            Vector2 newDirection = Vector2.Zero;
            foreach (var gameObject in gameObjects.ToList())
            {
                if (character != gameObject)
                {
                    if (gameObject.isUnwalkable)
                    {
                        Hitbox ch = character.CurrentFrame.Hitbox;
                        Hitbox gh = gameObject.CurrentFrame.Hitbox;
                        //make direction x or y 0 depending on which way the character collides with gameObject
                        float x1 = character.MinPosition.X + ch.Offset.X + direction.X;
                        float y1 = character.MinPosition.Y + ch.Offset.Y + direction.Y;

                        float x2 = character.MinPosition.X + gh.Offset.X;
                        float y2 = character.MinPosition.Y + gh.Offset.Y;

                        Rectangle h1 = new Rectangle((int)x1, (int)y1, ch.Box.Width, ch.Box.Height);
                        Rectangle h2 = new Rectangle((int)x2, (int)y2, gh.Box.Width, gh.Box.Height);

                        if (h1.Intersects(h2))
                        {
                            if (direction.X != 0)
                            {
                                if (x1 - direction.X + ch.Box.Width <= x2)
                                {
                                    newDirection.X = x2 - (x1 + ch.Box.Width);
                                }
                            }

                            if (direction.X != 0)
                            {
                                if (x2 + gh.Box.Width <= x1 - newDirection.X)
                                {
                                    newDirection.X = x2 + gh.Box.Width - x1;
                                }
                            }

                            if (direction.Y != 0)
                            {
                                if (y1 - direction.Y + ch.Box.Width <= y2)
                                {
                                    newDirection.Y = y2 - (y1 + ch.Box.Width);
                                }
                            }

                            if (direction.Y != 0)
                            {
                                if (y2 + gh.Box.Width <= y1 - newDirection.Y)
                                {
                                    newDirection.Y = y2 + gh.Box.Width - y1;
                                }
                            }


                        }
                        else
                        {
                            newDirection.X = direction.X;
                            newDirection.Y = direction.Y;
                        }

                    }
                    else
                    {
                        newDirection.X = direction.X;
                        newDirection.Y = direction.Y;
                    }

                }
            }
            return newDirection;
        }
    }
}
