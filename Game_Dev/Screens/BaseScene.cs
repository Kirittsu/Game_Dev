﻿using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Screens
{
    delegate void del(Vector2 position);
    internal abstract class BaseScene
    {
        public Dictionary<string, del> objAbbreviation = new()
        {
            {"0", null },
            {"1", delegate(Vector2 position){ new Wall(position); } },
            {"C", delegate(Vector2 position){ new Cave(position); } },
            {"S", delegate(Vector2 position){ new Spikes(position); } }
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
    }
}
