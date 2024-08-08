using Game_Dev.Characters;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Objects
{
    public class Hitbox
    {
        public Rectangle Box {  get; set; }
        public Vector2 Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        public Texture2D Texture { get; set; }
        private Vector2 offset;
        private Vector2 offsetFlipped;
        private bool flipped;

        public Hitbox(int width, int height, Vector2 offset)
        {
            this.Box = new Rectangle(0, 0, width, height);
            this.Offset = offset;
            Texture = new Texture2D(GameStateManager.graphics, 1,1);
            Texture.SetData(new[] { Color.White });
            flipped = false;
            offsetFlipped = Vector2.Zero;
        }

        public void Flip(Character parent)
        {
            if (parent.Facing.X > 0)
            {
                flipped = true;
                if (offsetFlipped.Y == 0)
                {
                    offsetFlipped = this.offset + new Vector2(parent.Width - this.Box.Width - 2 * (this.offset.X), 1);
                }
            }
            else if (parent.Facing.X < 0) flipped = false;
        }
    }
}
