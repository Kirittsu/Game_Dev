using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Xna.Framework;
using static Game_Dev.Game1;
using Game_Dev.Characters;
using Game_Dev.Interfaces;

namespace Game_Dev.Objects
{
    public abstract class BaseObject : GameElement
    {
        public Texture2D Texture { get; set; }
        public float scale = 1;
        private Status status;

        public Status Status
        {
            get { return status; } 
            set {
                if (status != value)
                {
                    if (this is IAnimate animatable) { animatable.currentFrameIndex = 0; }
                    status = value;
                }

            }
        }
        public new int Width { get { return (int)(CurrentFrame.frame.Width * scale); } }
        public new int Height { get { return (int)(CurrentFrame.frame.Height * scale); } }
        public Vector2 Facing { get; set; }
        public AnimationFrame CurrentFrame { get; set; }
        public BaseObject()
        {
            GameStateManager.gameObjects.Add(this);

            switch (this)
            {
                case Hero:
                    scale = 2f;
                    break;
            }

            Status = Status.Idle;
            Facing = new Vector2(1, 0);
            CurrentFrame = AnimationManager.GetCurrentFrame(0, this);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (Facing.X < 0)
                spriteBatch.Draw(Texture, new Rectangle((int)MinPosition.X, (int)MinPosition.Y, Width, Height), CurrentFrame.frame, Color.White);
            
            else
                spriteBatch.Draw(Texture, new Rectangle((int)MinPosition.X, (int)MinPosition.Y, Width, Height), CurrentFrame.frame, Color.White, 0f, new Vector2(), SpriteEffects.FlipHorizontally, 0f);
            
        }
    }
}
