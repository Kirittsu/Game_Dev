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

namespace Game_Dev.Objects.GameObjects
{
    public class Bomb : Character, IAnimate
    {
        public Character Origin;
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public Bomb(Vector2 position, Character origin)
        {
            Texture = GameStateManager.content.Load<Texture2D>("bomb");
            MinPosition = position;
            Origin = origin;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // If animation is done delete this object
            if (this.currentFrameIndex == 2) GameStateManager.gameObjects.Remove(this);
        }
    }
}
