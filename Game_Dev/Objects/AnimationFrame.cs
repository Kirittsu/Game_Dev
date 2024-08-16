using Microsoft.Xna.Framework;

namespace Game_Dev.Objects
{
    public class AnimationFrame
    {
        public Hitbox Hitbox { get; set; }
        public Rectangle Frame { get; set; }

        public AnimationFrame( Hitbox hitbox, int spriteX, int spriteY, int width, int height)
        {
            Hitbox = hitbox;
            Frame = new Rectangle(spriteX, spriteY, width, height);
        }
    }
}
