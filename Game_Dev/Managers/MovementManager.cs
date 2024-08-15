﻿using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Game_Dev.Characters;
using Game_Dev.Interfaces;

namespace Game_Dev.Managers
{
    public static class MovementManager
    {
        private static Vector2 snelheid = new Vector2(1, 1);

        public static void Move(Character character, GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();

            var direction = Vector2.Zero;


            if (character is Hero)
            {
                if (state.IsKeyDown(Keys.Left)) direction.X -= 3.5f;

                if (state.IsKeyDown(Keys.Right)) direction.X += 3.5f;

                if (state.IsKeyDown(Keys.Up)) direction.Y -= 3.5f;

                if (state.IsKeyDown(Keys.Down)) direction.Y += 3.5f;
            }

            snelheid.Normalize();
            direction *= snelheid;

            if (character is IAnimate)
            {
                if (direction.X == 0 && direction.Y == 0)
                {
                    if (state.IsKeyDown(Keys.C) && character is Hero) character.Status = Status.Attacking;

                    else character.Status = Status.Idle;
                }

                else
                {
                    if (state.IsKeyDown(Keys.C)) character.Status = Status.Attacking;

                    else character.Status = Status.Walking;
                }
            }

            Vector2 facing = character.Facing;

            if (character is Hero) {
                if (direction.X != 0) facing.X = direction.X;

                character.Facing = facing;

                direction = CollisionManager.MovementCollisionChecks(character, direction, GameStateManager.gameObjects);

                //apply everything
                character.MinPosition += direction;
            }

            if (character is HeroDarkness darkness)
            {
                darkness.MinPosition = darkness.hero.MinPosition - new Vector2(840, 510);
            }
        }
    }
}
