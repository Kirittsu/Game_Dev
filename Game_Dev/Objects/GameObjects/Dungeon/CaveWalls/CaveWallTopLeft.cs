using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveWallTopLeft : Tile
    {
        public CaveWallTopLeft(Vector2 position) : base(position, true, "DungeonTileset")
        {
            DrawOrder = 3;
        }
    }
}