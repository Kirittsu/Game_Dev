using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;

namespace Game_Dev.Objects.GameObjects.Dungeon.CaveFloor
{
    public class CaveFloor : BaseObject
    {
        public CaveFloor(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("DungeonTileset"); // Load the texture here
            Facing = new Vector2(1, 0);
            isUnwalkable = false;
        }
    }
}