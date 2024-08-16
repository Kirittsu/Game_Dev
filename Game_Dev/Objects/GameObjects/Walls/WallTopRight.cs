using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Walls
{
    public class WallTopRight : Tile
    {
        public WallTopRight(Vector2 position) : base(position, true, "grassTiles") 
        {
            DrawOrder = 3;
        }
    }
}