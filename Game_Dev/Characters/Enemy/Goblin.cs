﻿using Game_Dev.Characters.Player;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game_Dev.Characters.Enemy
{
    public class Goblin : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        private float detectionRange = 200f;

        private float attackRange = 50f;

        public Goblin(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("goblin");
            Facing = new Vector2(1, 0);
            DrawOrder = 2;
        }

        public void Update(GameTime gameTime, Hero hero, List<BaseObject> gameObjects)
        {
            base.Update(gameTime);

            float distanceToHero = Vector2.Distance(hero.MinPosition, MinPosition);

            if (distanceToHero <= detectionRange)
            {
                if (distanceToHero < attackRange)
                {
                    if (Status != Status.Attacking) Status = Status.Attacking;
                }
                else
                {
                    if (Status != Status.Walking) Status = Status.Walking;
                }

                Vector2 direction = hero.MinPosition - MinPosition;
                direction.Normalize();
                direction *= 2f;
                direction = CollisionManager.MovementCollisionChecks(this, direction, gameObjects);

                MinPosition += direction;

                if (direction.X != 0) Facing = new Vector2(direction.X, 0);
            }
            else
            {
                if (Status != Status.Idle)
                {
                    Status = Status.Idle;
                }
            }
        }
    }
}