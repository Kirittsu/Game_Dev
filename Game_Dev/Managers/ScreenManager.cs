using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Managers
{
    public static class ScreenManager
    {
        public static int ScreenWidth { get; set; }
        public static int ScreenHeight { get; set; }

        public static void Draw(SpriteBatch spriteBatch)
        {

        }

        public static void Update(GameTime gameTime)
        {

        }

        internal static void Load()
        {
            if (!GameStateManager.loading)
            {
                GameStateManager.loading = true;
                GameStateManager.gameObjects.Clear();
                GameStateManager.gameElements.Clear();
                GameStateManager.CurrentScene().LoadScene();
                GameStateManager.CurrentScene().LoadMap();
            }
        }
    }
}
