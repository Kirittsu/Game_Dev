using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Dev.Objects.GameObjects
{
    public class Bomb : Character, IAnimate
    {
        public Character Origin;
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }
        public bool isExploded = false;
        private Vector2 initialTargetPosition; // Store the initial position of the target
        private List<BaseObject> gameObjects;

        public Bomb(Vector2 position, Character origin, Character target, List<BaseObject> gameObjects)
        {
            Texture = GameStateManager.content.Load<Texture2D>("bomb");
            MinPosition = position;
            Origin = origin;
            scale = 2;
            isUnwalkable = false;
            DrawOrder = 4;
            this.initialTargetPosition = target.MinPosition + new Vector2(target.Width / 4, target.Height - (target.Height / 4)); // Store the initial target position
            this.gameObjects = gameObjects;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            float distanceToTarget = Vector2.Distance(initialTargetPosition, this.MinPosition);

            if (distanceToTarget > 0)
            {
                Vector2 direction = initialTargetPosition - this.MinPosition;
                direction.Normalize();
                direction *= 2f; // Adjust speed as needed
                direction = CollisionManager.MovementCollisionChecks(this, direction, gameObjects);

                this.MinPosition += direction;
            }

            if (this.currentFrameIndex == 8)
            {
                isExploded = true;
            }

            // If animation is done, delete this object
            if (this.currentFrameIndex == 9)
            {
                GameStateManager.gameObjects.Remove(this);
            }
        }
    }
}
