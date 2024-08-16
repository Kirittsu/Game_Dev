using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Walls
{
    public class Wall : Tile
    {
        public Wall(Vector2 position) : base(position, true, "grassTiles") {}
    }
}