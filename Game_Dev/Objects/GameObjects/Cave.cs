using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;

namespace Game_Dev.Objects.GameObjects
{
    public class Cave : BaseObject
    {
        public Cave(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("grassTiles"); // Load the texture here
            Facing = new Vector2(1, 0);
        }
    }
}
