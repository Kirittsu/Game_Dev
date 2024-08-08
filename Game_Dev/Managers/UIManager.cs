using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Managers
{
    public class UIManager
    {
        private static UIReader UIControls = new();
        private static int Cooldown;
        public static void Update(GameTime gameTime)
        {
            if (Cooldown < 0) Cooldown = 15;

            Cooldown--;
        }
    }
}
