using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Objects;
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
            GameStateManager.CurrentScene().Draw(spriteBatch);
            foreach (GameElement gElement in GameStateManager.gameElements)
            {
                //handeld by BaseObject/Movable
                gElement.Draw(spriteBatch);
            }
            GameStateManager.loading = false;
        }

        public static void Update(GameTime gameTime)
        {

        }

        public static void Load()
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
