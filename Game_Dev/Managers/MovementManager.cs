using Game_Dev.Charaters;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Game_Dev.Managers
{
    public static class MovementManager
    {
        private static Vector2 snelheid = new Vector2(1, 1);

        public static void Move(Hero hero)
        {
            KeyboardState state = Keyboard.GetState();
            var direction = Vector2.Zero;
            if (state.IsKeyDown(Keys.Left))
                direction.X -= 2;
            if (state.IsKeyDown(Keys.Right))
                direction.X += 2;
            if (state.IsKeyDown(Keys.Up))
                direction.Y -= 2;
            if (state.IsKeyDown(Keys.Down))
                direction.Y += 2;
            direction *= snelheid;
            hero.position += direction;
            snelheid.Normalize();
        }
    }
}
