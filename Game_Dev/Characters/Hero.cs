using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1.Effects;

namespace Game_Dev.Characters
{
    public class Hero : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public Hero(Vector2 position)
        {
            scale = 2;
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("hero");
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
        }

        public override bool Interaction(BaseObject gameObject)
        {
            return false;
        }
    }
}
