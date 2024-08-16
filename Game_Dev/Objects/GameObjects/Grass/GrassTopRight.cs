﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;
namespace Game_Dev.Objects.GameObjects.Grass
{
    public class GrassTopRight : BaseObject
    {
        public GrassTopRight(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("grassTiles"); // Load the texture here
            Facing = new Vector2(1, 0);
        }
    }
}
