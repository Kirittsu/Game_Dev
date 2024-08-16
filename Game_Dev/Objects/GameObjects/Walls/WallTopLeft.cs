using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Walls
{
    public class WallTopLeft : Tile
    {
        public WallTopLeft(Vector2 position) : base(position, true, "grassTiles") 
        {
            DrawOrder = 3;
        }
    }
}