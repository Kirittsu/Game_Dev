using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Game_Dev.Managers
{
    public class UIManager
    {
        private static int Cooldown;
        public static void Update(GameTime gameTime)
        {
                KeyboardState state = Keyboard.GetState();
                if (state.IsKeyDown(Keys.Space)) GameStateManager.NextLevel();

            Cooldown--;
        }
    }
}
