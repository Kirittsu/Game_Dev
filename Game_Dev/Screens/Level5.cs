using Game_Dev.Characters;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Screens
{
    public class Level5 : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Map = new string[,]
            {
            {"C4","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C4"},

            {"C4","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C1","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C2","C3","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C5","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","T2","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","T2","T2","T2","C6","T2","T2","T2","T2","C1","C2","C2","C2","C3","T2","T2","T2","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","T2","T2","T2","C4","T2","T2","T2","T2","C4","C7","C7","C7","C4","T2","T2","T2","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","T2","T2","T2","C4","T2","T2","T2","T2","C4","C8","C8","C8","C4","T2","T2","T2","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","C2","C2","C2","C2","T2","T2","T2","T2","C2","CV","CV","CV","C4","T2","T2","T2","C4","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","C7","C7","C7","C7","T1","T2","T2","T3","C7","CV","CV","CV","C4","T2","T2","T2","C2","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","C8","C8","C8","C8","T1","T2","T2","T3","C8","CV","CV","CV","C4","T2","T2","T2","C5","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","CV","CV","CV","CV","T1","T2","T2","T3","CV","CV","CV","CV","C4","T2","T2","T2","T2","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","CV","CV","CV","CV","T1","T2","T2","T3","CV","CV","CV","CV","C4","T2","T2","T2","T2","T2","T2","C4"},

            {"C4","T2","T2","T2","T2","T2","C4","CV","CV","CV","CV","T1","T2","T2","T3","CV","CV","CV","CV","C2","C2","C2","C2","C2","C2","C2","C2"},

            {"C2","C2","C2","C2","C2","C2","C2","CV","CV","CV","CV","T1","T2","T2","T3","CV","CV","CV","CV","C5","C5","C5","C5","C5","C5","C5","C5"}
            };

            new Hero(new Vector2(375, 420));

            GameStateManager.UIToggle = false;
        }
    }
}
