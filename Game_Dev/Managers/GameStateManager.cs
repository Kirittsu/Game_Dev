using Game_Dev.Objects;
using Game_Dev.Screens;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Managers
{
    public class GameStateManager
    {
        public static bool UIToggle = false;
        public static List<BaseObject> gameObjects;
        public static List<GameElement> gameElements;
        public static GraphicsDevice graphics;
        public static ContentManager content;
        public static SpriteFont Font;
        public static bool loading;
        private static List<BaseScene> LevelList = new()
        {
            new StartScreen(),
            new Level1(),
            new Level2(),
            new Level3(),
            new Level4(),
            new Level5(),
            new Level6(),
            new EndScreen(),
            new YouWin()
        };
        public static int LevelIndex = 0;
        private static int currentLevel;
        public static BaseScene CurrentScene()
        {
            return LevelList[LevelIndex];
        }
        public static void NextLevel(int index = -1, int entrance = 0)
        {
            if (index < 0)
            {
                if (LevelIndex == 8)
                {
                    LevelIndex = 0;
                }
                else if (LevelIndex == 7)
                {
                    LevelIndex = currentLevel;
                }
                else
                {
                    LevelIndex++;
                }
            }
            else if (index == 7)
            {
                currentLevel = LevelIndex;
                LevelIndex = index;
            }
            else
            {
                LevelIndex = index;
            }

            ScreenManager.Load(entrance);
        }

        public static void Remove(GameElement removable)
        {
            gameElements.Remove(removable);
            if (removable is BaseObject removable2)
            {
                gameObjects.Remove(removable2);
            }
        }
    }
}
