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

        public GoblinBomber(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("goblinBomber");
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            AttackCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Status == Status.Attacking && AttackCooldown <= 0)
            {
                GameStateManager.gameObjects.Add(new Bomb(this.MinPosition + new Vector2(0, Height / 2), this));

                AttackCooldown = 0.525f;
            }
        }
    }
}
