using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Characters;
using Microsoft.Xna.Framework;
using Game_Dev.Objects.GameObjects;
using Game_Dev.Objects.UIElements;

namespace Game_Dev.Screens
{
    public class Level1 : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Map = new string[,]
            {
            { "W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5" },

            { "W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","WD","W5","W5","W5","W5","W5","W5","W5" },

            { "W5","W5","W5","W5","W5","W5","W5","W5","WD","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5" },

            { "W5","W5","W5","WD","WD","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8" },

            { "W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW" },

            { "W5","W5","W5","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W9","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW" },

            { "W5","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW" },

            { "W5","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2" },

            { "W5","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  " },

            { "W5","W5","W6","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  " },

            { "W5","W5","W6","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","G5","  ","  " },

            { "W5","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  " },

            { "W5","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  " },

            { "W5","W5","W5","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W3","  ","  ","  ","  ","  ","  ","G5","  ","  ","  " },

            { "W5","W5","W5","W5","WD","W5","W5","W5","W5","W5","W5","WD","W5","W5","W5","W5","W5","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2" },

            { "W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","WD","W5","W5","W5","W5" }
            };

            if (entrance == 4) new Hero(new Vector2(800, 300));
            else new Hero(new Vector2(150, 300));

            GameStateManager.UIToggle = false;

            new ControlDisplay(new Vector2(20, 20));

            new Text(new Vector2(170, 37), "Move", Color.White);
            new Text(new Vector2(150, 114), "Attack", Color.White);
        }
    }
}
