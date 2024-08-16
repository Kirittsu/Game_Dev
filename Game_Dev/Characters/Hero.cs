using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1.Effects;

namespace Game_Dev.Characters
{
    public class Hero : Character, IAnimate, IMovement
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }
        public float AttackCooldown { get; set; }
        public float TimeRunning { get; set; }
        public float Speed { get; set; }
        public float SpeedCap { get; set; } = 3f;
        public float Acceleration { get; set; } = 0.5f;
        public float Deceleration { get; set; } = 0.3f;
        public Character heroDarkness { get; set; }
        public Vector2 LastDirection { get; set; } = Vector2.Zero;

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

            if (Status == Status.Attacking && AttackCooldown <= 0)
            {
                Vector2 attackOffset = Facing.X > 0 ? new Vector2(Width * 1.4f, Height / 2) : new Vector2(-Width, Height / 2);
                GameStateManager.gameObjects.Add(new HeroAttack(MinPosition + attackOffset, Facing, this));
                AttackCooldown = 0.525f;
            }

            AttackCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void Respawn()
        {
            AudioManager.PlayDyingSound();
            GameStateManager.NextLevel(7);
        }

        public float CalculateMove(Vector2 direction)
        {
            if (direction != Vector2.Zero)
            {
                LastDirection = direction;
                Speed = MathHelper.Clamp(Speed + Acceleration, 0, SpeedCap);
            }
            else
            {
                Speed = MathHelper.Clamp(Speed - Deceleration, 0, SpeedCap);
                if (Speed == 0) LastDirection = Vector2.Zero;
            }
            return Speed;
        }

        public void ResetMovement()
        {
            Speed = 0;
            TimeRunning = 0;
            LastDirection = Vector2.Zero;
        }
    }
}
