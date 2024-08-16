using Game_Dev.Characters;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects.GameObjects
{
    public class HeroAttack : Character, IAnimate
    {
        public Character Origin;
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public HeroAttack(Vector2 position, Vector2 facing, Character origin)
        {
            Texture = GameStateManager.content.Load<Texture2D>("hero");
            MinPosition = position;
            Origin = origin;
            Facing = facing;
            AudioManager.PlaySlashSound();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // If animation is done delete this object
            if (this.currentFrameIndex == 5) GameStateManager.gameObjects.Remove(this);
        }
    }
}