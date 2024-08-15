using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Objects.GameObjects
{
    public class Chest : BaseObject, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public static bool keyObtained = false;

        public Chest(Vector2 position)
        {
            this.MinPosition = position;
            this.Texture = GameStateManager.content.Load<Texture2D>("chest"); // Load the texture here
            Facing = new Vector2(1, 0);
            DrawOrder = 1;
            scale = 3;
        }
    }
}