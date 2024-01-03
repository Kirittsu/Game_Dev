using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects.UIElements
{
    internal class Text : GameElement
    {
        public string Content { get; set; }

        public Text(Vector2 position, string content)
        {
            MinPosition = position;
            Content = content;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(GameStateManager.Font, Content, MinPosition, Color.Black);
        }
    }
}
