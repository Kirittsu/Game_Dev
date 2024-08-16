using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;
namespace Game_Dev.Objects.GameObjects.Grass
{
    public class ControlDisplay : BaseObject
    {
        public ControlDisplay(Vector2 position)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("controls"); // Load the texture here
            Facing = new Vector2(1, 0);
            DrawOrder = 5;
            scale = 0.35f;
        }
    }
}
