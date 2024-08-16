using Microsoft.Xna.Framework;
namespace Game_Dev.Objects.GameObjects.Grass
{
    public class GrassField : Tile
    {
        public GrassField(Vector2 position) : base(position, false, "grassTiles") { }
    }
}