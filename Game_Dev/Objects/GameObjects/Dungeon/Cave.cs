using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;

namespace Game_Dev.Objects.GameObjects.Dungeon
{
    public class Cave : BaseObject
    {
        public Cave(Vector2 position)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("grassTiles"); // Load the texture here
            Facing = new Vector2(1, 0);
        }
    }
}
