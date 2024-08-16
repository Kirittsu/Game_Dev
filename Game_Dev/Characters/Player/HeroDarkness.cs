using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Characters.Player
{
    public class HeroDarkness : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public Hero hero;

        public HeroDarkness(Vector2 position, Hero hero)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("darkness");
            Facing = new Vector2(1, 0);
            isUnwalkable = false;
            DrawOrder = 5;
            this.hero = hero;

        }
    }
}
