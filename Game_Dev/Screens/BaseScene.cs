using Game_Dev.Managers;
using Game_Dev.Objects.GameObjects;
using Game_Dev.Objects.GameObjects.Dungeon.CaveWalls;
using Game_Dev.Objects.GameObjects.Dungeon.CaveFloor;
using Game_Dev.Objects.GameObjects.Grass;
using Game_Dev.Objects.GameObjects.Walls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Objects;

namespace Game_Dev.Screens
{
    public delegate void del(Vector2 position);
    public abstract class BaseScene
    {
        public Dictionary<string, del> objAbbreviation = new()
        {
            {"00", null },
            #region Wall
            {"WW", delegate(Vector2 position){ new Wall(position); } },
            {"WD", delegate(Vector2 position){ new WallDirt(position); } },
            {"W1", delegate(Vector2 position){ new WallTopLeft(position); } },
            {"W2", delegate(Vector2 position){ new WallTop(position); } },
            {"W3", delegate(Vector2 position){ new WallTopRight(position); } },
            {"W4", delegate(Vector2 position){ new WallLeft(position); } },
            {"W5", delegate(Vector2 position){ new WallField(position); } },
            {"W6", delegate(Vector2 position){ new WallRight(position); } },
            {"W7", delegate(Vector2 position){ new WallBottomLeft(position); } },
            {"W8", delegate(Vector2 position){ new WallBottom(position); } },
            {"W9", delegate(Vector2 position){ new WallBottomRight(position); } },
            {"WC", delegate(Vector2 position){ new Cave(position); } },
            #endregion

            #region Grass
            {"  ", delegate(Vector2 position){ new Grass(position); } },
            {"G1", delegate(Vector2 position){ new GrassTopLeft(position); } },
            {"G2", delegate(Vector2 position){ new GrassTop(position); } },
            {"G3", delegate(Vector2 position){ new GrassTopRight(position); } },
            {"G4", delegate(Vector2 position){ new GrassLeft(position); } },
            {"G5", delegate(Vector2 position){ new GrassLeaves(position); } },
            {"G6", delegate(Vector2 position){ new GrassRight(position); } },
            {"G7", delegate(Vector2 position){ new GrassBottomLeft(position); } },
            {"G8", delegate(Vector2 position){ new GrassBottom(position); } },
            {"G9", delegate(Vector2 position){ new GrassBottomRight(position); } },
            #endregion

            #region Cave
            {"C1", delegate(Vector2 position){ new CaveWallTopLeft(position); } },
            {"C2", delegate(Vector2 position){ new CaveWallHorizontal(position); } },
            {"C3", delegate(Vector2 position){ new CaveWallTopRight(position); } },
            {"C4", delegate(Vector2 position){ new CaveWallVertical(position); } },
            {"C5", delegate(Vector2 position){ new CaveWall(position); } },
            {"C6", delegate(Vector2 position){ new CaveWallTop(position); } },
            {"C7", delegate(Vector2 position){ new CaveWallDark(position); } },
            {"C8", delegate(Vector2 position){ new CaveWallDarker(position); } },

            {"T1", delegate(Vector2 position){ new CaveFloorLeft(position); } },
            {"T2", delegate(Vector2 position){ new CaveFloor(position); } },
            {"T3", delegate(Vector2 position){ new CaveFloorRight(position); } }
            #endregion

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
                            var newObject = objAbbreviation[Map[y, x]].DynamicInvoke(new Vector2(32 * x, 32 * y));
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
