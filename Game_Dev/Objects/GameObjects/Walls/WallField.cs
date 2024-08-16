using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Walls
{
    public class WallField : Tile
    {
        public WallField(Vector2 position) : base(position, true, "grassTiles") { }
    }
}