using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Interfaces;
using Game_Dev.Managers;

namespace Game_Dev.Characters.Enemy
{
    public class Spikes : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        private double timeSinceLastFrame;
        private double spikeTimer;
        private double holdLoweredDuration = 1.2;
        private double holdExtendedDuration = 1.0;
        public bool isExtended;

        public Spikes(Vector2 position)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("DungeonTileset");
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
            isUnwalkable = false;
            isExtended = false;
            spikeTimer = holdLoweredDuration;
            currentFrameIndex = 0;
        }

        public override void Update(GameTime gameTime)
        {
            double elapsedTime = gameTime.ElapsedGameTime.TotalSeconds;

            spikeTimer -= elapsedTime;

            if (spikeTimer <= 0)
            {
                if (isExtended)
                {
                    isExtended = false;
                    spikeTimer = holdLoweredDuration;
                    currentFrameIndex = 0;
                }
                else
                {
                    isExtended = true;
                    spikeTimer = holdExtendedDuration;
                }
            }

            if (isExtended)
            {
                // Animate the spikes extending
                Animate(gameTime);
            }
            else
            {
                // Spikes lowered
                currentFrameIndex = 0;
            }

            base.Update(gameTime);
        }

        private void Animate(GameTime gameTime)
        {
            timeSinceLastFrame += gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timeSinceLastFrame >= holdFrame)
            {
                currentFrameIndex++;

                if (currentFrameIndex >= AnimationManager.SpikesIdle.Count)
                {
                    currentFrameIndex = AnimationManager.SpikesIdle.Count - 1;
                }

                timeSinceLastFrame = 0;
            }
        }
    }
}
