using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects.UIElements
{
    public class Text : GameElement
    {
        public string Content { get; set; }

        private Color textColor = Color.Black;

        public Text(Vector2 position, string content, Color textColor)
        {
            MinPosition = position;
            Content = content;
            DrawOrder = 4;
            this.textColor = textColor;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(GameStateManager.Font, Content, MinPosition, textColor);
        }
    }
}
