using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game_Dev.Characters
{
    public class Goblin : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        private float detectionRange = 200f;

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
            float distanceToHero = Vector2.Distance(hero.MinPosition, this.MinPosition);

            if (distanceToHero <= detectionRange)
            {
                Vector2 direction = hero.MinPosition - this.MinPosition;
                direction.Normalize();
                direction *= 2f;
                direction = CollisionManager.MovementCollisionChecks(this, direction, gameObjects);

                this.MinPosition += direction;

                if (direction.X != 0) this.Facing = new Vector2(direction.X, 0);
            }

            base.Update(gameTime);
        }
    }
}