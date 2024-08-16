using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Dungeon.CaveWalls
{
    public class CaveWall : Tile
    {
        public CaveWall(Vector2 position) : base(position, true, "DungeonTileset") { }
    }
}