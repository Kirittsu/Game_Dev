using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Managers;
using Game_Dev.Interfaces;
namespace Game_Dev.Objects.GameObjects
{
    public class Key : BaseObject, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public static bool keyObtained = false;

        public Key(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("key"); // Load the texture here
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
        }
    }
}
