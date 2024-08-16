using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects
{
    public abstract class GameElement
    {
        public Vector2 MinPosition { get; set; }
        public Vector2 MaxPosition
        {
            get { return MinPosition + new Vector2(Width, Height); }
            set { MinPosition = value - new Vector2(Width, Height); }
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public int DrawOrder = 0;
        public abstract void Draw(SpriteBatch spriteBatch);

        public GameElement()
        {
            GameStateManager.gameElements.Add(this);
        }
    }
}
