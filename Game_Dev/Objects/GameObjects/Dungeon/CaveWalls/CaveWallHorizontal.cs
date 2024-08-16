using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveWallHorizontal : Tile
    {
        public CaveWallHorizontal(Vector2 position) : base(position, true, "DungeonTileset") 
        {
            DrawOrder = 3;
        }
    }
}