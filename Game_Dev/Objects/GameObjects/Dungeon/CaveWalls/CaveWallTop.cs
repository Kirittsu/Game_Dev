using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveWallTop : Tile
    {
        public CaveWallTop(Vector2 position) : base(position, true, "DungeonTileset")
        {
            DrawOrder = 3;
        }
    }
}