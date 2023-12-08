using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SharpDX.Direct2D1.Effects;

namespace Game_Dev.Charaters
{
    public class Hero : Character
    {
        public Hero(Vector2 pos)
        {
            scale = 2;
            position = pos;
        }
    }
}
