using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Game_Dev.Objects.UIElements;
using Microsoft.Xna.Framework;
using Game_Dev.Characters;
using Game_Dev.Objects.GameObjects.Walls;

namespace Game_Dev.Screens
{
    public class StartScreen : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Background = GameStateManager.content.Load<Texture2D>("background");
            GameStateManager.UIToggle = true;
            new Text(new Vector2(210, 380), "Press Spacebar to Continue", Color.Black);
        }
    }
}