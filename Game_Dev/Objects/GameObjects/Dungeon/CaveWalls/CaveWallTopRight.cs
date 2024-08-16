using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveWallTopRight : Tile
    {
        public CaveWallTopRight(Vector2 position) : base(position, true, "DungeonTileset")
        {
            DrawOrder = 3;
        }
    }
}