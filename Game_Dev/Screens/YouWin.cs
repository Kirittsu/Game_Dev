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
