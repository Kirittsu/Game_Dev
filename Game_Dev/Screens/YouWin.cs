using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Screens
{
    public class YouWin : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Background = GameStateManager.content.Load<Texture2D>("youwin");
        }
    }
}
