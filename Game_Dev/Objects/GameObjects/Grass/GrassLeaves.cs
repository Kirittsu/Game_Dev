using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;

namespace Game_Dev.Objects.GameObjects.Grass
{
    public class GrassLeaves : Tile
    {
        public GrassLeaves(Vector2 position) : base(position, false, "grassTiles") { }
    }
}