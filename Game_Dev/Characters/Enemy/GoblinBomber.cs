using Game_Dev.Characters.Player;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game_Dev.Characters.Enemy
{
    public class GoblinBomber : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public float AttackCooldown { get; set; }

        private float attackRange = 400f;

        public GoblinBomber(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("goblinBomber");
            Facing = new Vector2(1, 0);
            DrawOrder = 4;
            isUnwalkable = false;
        }

        public void Update(GameTime gameTime, Hero hero, List<BaseObject> gameObjects)
        {
            base.Update(gameTime);

            float distanceToHero = Vector2.Distance(hero.MinPosition, MinPosition);

            // Adjust the Facing direction based on the Hero's position relative to the GoblinBomber
            if (hero.MinPosition.X > MinPosition.X)
            {
                Facing = new Vector2(1, 0); // Face right
            }
            else if (hero.MinPosition.X < MinPosition.X)
            {
                Facing = new Vector2(-1, 0); // Face left
            }

            if (distanceToHero <= attackRange)
            {
                if (Status != Status.Attacking) Status = Status.Attacking;

                AttackCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (Status == Status.Attacking && AttackCooldown <= 0 && currentFrameIndex == 3)
                {
                    if (Facing.X > 0) GameStateManager.gameObjects.Add(new Bomb(MinPosition + new Vector2(0, 0), this, hero, gameObjects));
                    else GameStateManager.gameObjects.Add(new Bomb(MinPosition + new Vector2(Width / 2, 0), this, hero, gameObjects));


                    AttackCooldown = 0.525f;
                }
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
