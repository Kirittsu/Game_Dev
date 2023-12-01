using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Charaters
{
    public abstract class Character
    {
        public Texture2D Texture { get; set; }
        public Rectangle _spriteRectangle;

        public int scale = 1;
    }
}
