using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1.Effects;

namespace Game_Dev.Characters
{
    public class HeroDarkness : Character, IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }

        public int Health { get { return health; } set { health = value; } }

        public Hero hero;

        private int health = 3;

        public HeroDarkness(Vector2 position, Hero hero)
        {
            MinPosition = position;
            Texture = GameStateManager.content.Load<Texture2D>("darkness");
            Facing = new Vector2(1, 0);
            isUnwalkable = false;
            DrawOrder = 5;
            this.hero = hero;

        }
    }
}
