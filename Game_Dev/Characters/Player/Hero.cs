using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Characters.Player
{
    public class Hero : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public float AttackCooldown { get; set; }

        public Hero(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("hero");
            Facing = new Vector2(1, 0);
            DrawOrder = 2;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            AttackCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Status == Status.Attacking && AttackCooldown <= 0)
            {
                if (Facing.X > 0) GameStateManager.gameObjects.Add(new HeroAttack(MinPosition + new Vector2(Width * 1.4f, Height / 2), Facing, this));

                else GameStateManager.gameObjects.Add(new HeroAttack(MinPosition + new Vector2(-Width, Height / 2), Facing, this));
                AttackCooldown = 0.525f;
            }
        }

        public void Respawn()
        {
            AudioManager.PlayDyingSound();
            GameStateManager.NextLevel(7);
        }
    }
}
