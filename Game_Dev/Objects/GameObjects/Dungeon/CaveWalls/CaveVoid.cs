using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveVoid : BaseObject
    {
        public CaveVoid(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("DungeonTileset"); // Load the texture here
            Facing = new Vector2(1, 0);
        }
    }
}
