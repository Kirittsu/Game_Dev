using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using Game_Dev.Objects.UIElements;
using Microsoft.Xna.Framework;

namespace Game_Dev.Screens
{
    public class EndScreen : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Background = GameStateManager.content.Load<Texture2D>("gameover");
            GameStateManager.UIToggle = true;
            new Text(new Vector2(240, 425), "Press Spacebar to Continue", Color.Black);
        }
    }
}
