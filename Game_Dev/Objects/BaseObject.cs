using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Xna.Framework;
using static Game_Dev.Game1;
using Game_Dev.Charaters;

namespace Game_Dev.Objects
{
    internal abstract class BaseObject : GameElement
    {
        public Texture2D Texture { get; set; }
        public float scale = 1;

        public Vector2 Facing { get; set; }
        public BaseObject()
        {
            GameStateManager.gameObjects.Add(this);
        }
    }
}
