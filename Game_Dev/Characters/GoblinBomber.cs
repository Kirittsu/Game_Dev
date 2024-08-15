using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Characters
{
    public class GoblinBomber : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public float AttackCooldown { get; set; }

        private float attackRange = 200f;

        public GoblinBomber(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("goblinBomber");
            Facing = new Vector2(1, 0);
            DrawOrder = 2;
            isUnwalkable = false;
        }

        public void Update(GameTime gameTime, Hero hero, List<BaseObject> gameObjects)
        {
            base.Update(gameTime);

            float distanceToHero = Vector2.Distance(hero.MinPosition, this.MinPosition);

            // Adjust the Facing direction based on the Hero's position relative to the GoblinBomber
            if (hero.MinPosition.X > this.MinPosition.X)
            {
                Facing = new Vector2(1, 0); // Face right
            }
            else if (hero.MinPosition.X < this.MinPosition.X)
            {
                Facing = new Vector2(-1, 0); // Face left
            }

            if (distanceToHero <= attackRange)
            {
                if (Status != Status.Attacking) Status = Status.Attacking;

                AttackCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (Status == Status.Attacking && AttackCooldown <= 0 && currentFrameIndex == 3)
                {
                    if (this.Facing.X > 0) GameStateManager.gameObjects.Add(new Bomb(this.MinPosition + new Vector2(0, 0), this, hero, gameObjects));
                    else GameStateManager.gameObjects.Add(new Bomb(this.MinPosition + new Vector2(Width / 2, 0), this, hero, gameObjects));


                    AttackCooldown = 0.525f;
                }
            }
            else
            {
                if (this.Status != Status.Idle)
                {
                    this.Status = Status.Idle;
                }
            }
        }
    }
}
