using Game_Dev.Characters;
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
    public class Bomb : Character
    {
        public Character Origin;

        public Bomb(Vector2 position, Vector2 facing, Character origin)
        {
            Texture = GameStateManager.content.Load<Texture2D>("bomb");
            MinPosition = position;
            Origin = origin;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
