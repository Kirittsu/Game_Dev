using Game_Dev.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Screens
{
    internal class Level1 : BaseScene
    {
        public override void LoadScene()
        {
            Map = new string[,]
            {

            };
            Background = GameStateManager.content.Load<Texture2D>("grassTiles");
        }
    }
}
