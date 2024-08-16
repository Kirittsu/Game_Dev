using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Objects.UIElements;
using Microsoft.Xna.Framework;

namespace Game_Dev.Screens
{
    public class StartScreen : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Background = GameStateManager.content.Load<Texture2D>("background");
            GameStateManager.UIToggle = true;
            new Text(new Vector2(240, 400), "Press Spacebar to Continue", Color.Black);
        }
    }
}