using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Objects.GameObjects
{
    public abstract class Tile : BaseObject
    {
        public Tile(Vector2 position, bool isUnwalkable, string Texture)
        {
            this.Texture = GameStateManager.content.Load<Texture2D>(Texture);
            this.MinPosition = position;
            this.Facing = new Vector2(1, 0);
            this.isUnwalkable = isUnwalkable;
        }
    }
}
