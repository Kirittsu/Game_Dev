using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            if (Cooldown < 0)
            {
                KeyboardState state = Keyboard.GetState();
                if (state.IsKeyDown(Keys.Space)) GameStateManager.NextLevel();

                Cooldown = 15;
            }

            Cooldown--;
        }
    }
}
