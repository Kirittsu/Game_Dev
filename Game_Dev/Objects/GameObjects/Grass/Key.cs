using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;
using Game_Dev.Interfaces;
namespace Game_Dev.Objects.GameObjects.Grass
{
    public class Key : BaseObject, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public static bool keyObtained = false;

        public Key(Vector2 position)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("key"); // Load the texture here
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
        }
    }
}
