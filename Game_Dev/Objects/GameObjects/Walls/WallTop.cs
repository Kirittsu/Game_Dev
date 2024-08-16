using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Walls
{
    public class WallTop : Tile
    {
        public WallTop(Vector2 position) : base(position, true, "grassTiles") 
        {
            DrawOrder = 3;
        }
    }
}