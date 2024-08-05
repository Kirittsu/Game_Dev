using Game_Dev.Managers;
using Game_Dev.Objects.GameObjects;
using Game_Dev.Objects.GameObjects.Grass;
using Game_Dev.Objects.GameObjects.Walls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Screens
{
    public delegate void del(Vector2 position);
    public abstract class BaseScene
    {
        public Dictionary<string, del> objAbbreviation = new()
        {
            {"0", null },
            {"W", delegate(Vector2 position){ new Wall(position); } },
            {"L", delegate(Vector2 position){ new WallLeft(position); } },
            {"R", delegate(Vector2 position){ new WallRight(position); } },
            {"G", delegate(Vector2 position){ new Grass(position); } },
            {"V", delegate(Vector2 position){ new GrassLeaves(position); } }
        };

        public abstract void LoadScene();
        public string[,] Map { get; set; }
        public Texture2D Background { get; set; }

        public void LoadMap()
        {
            if (Map != null)
            {
                for (int x = 0; x < Map.GetLength(1); x++)
                {
                    for (int y = 0; y < Map.GetLength(0); y++)
                    {
                        if (objAbbreviation[Map[y, x]] != null)
                        {
                            var newObject = objAbbreviation[Map[y, x]].DynamicInvoke(new Vector2(30 * x, 30 * y));
                            if (y != 0 && newObject is Wall newBlock && Map[y - 1, x] != "0")
                            {
                            }
                        }
                    }
                }
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (Background != null)
            {
                spriteBatch.Draw(Background, new Rectangle(0, 0, ScreenManager.ScreenWidth, ScreenManager.ScreenHeight), new Rectangle(0, 0, Background.Width, Background.Height), Color.White);
            }
        }
    }
}
