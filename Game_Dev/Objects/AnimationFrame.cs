using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Game_Dev.Objects
{
    internal class AnimationFrame
    {
        //public List<Hitbox> Hitboxes { get; set; }
        public Rectangle frame { get; set; }

        public AnimationFrame( /*List<Hitbox> hitboxes, */ int spriteX, int spriteY, int width, int height)
        {
            //Hitboxes = hitboxes
            frame = new Rectangle(spriteX, spriteY, width, height);
        }
    }
}
