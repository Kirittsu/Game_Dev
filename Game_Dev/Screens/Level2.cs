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
    public class Level2 : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Map = new string[,]
{
            {"W5","W5","W5","W5","W5","W5","W7","W8","W9","W3","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW"},

            {"W5","W5","WD","W5","W5","W5","WW","WW","WW","W9","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW"},

            {"W5","W5","W5","W5","W5","W5","WW","WW","WW","WW","W5","W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW"},

            {"W8","W8","W8","W8","W8","W5","WW","WW","WW","W5","W8","W9","G2","G2","G2","G2","G2","G2","G2","G2","WW","WW","WW","WW","WW","WW","WW"},

            {"WW","WW","WW","WW","WW","W4","W5","W5","W5","W9","WW","WW","  ","  ","G5","  ","  ","  ","  ","  ","G2","G2","G2","G2","G2","G2","G2"},

            {"WW","WW","WW","WW","WW","W7","W8","W8","W9","WW","WW","WW","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  "},

            {"WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  "},

            {"G2","G2","G2","G2","G2","WW","WW","WW","WW","WW","G2","G2","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W1","W2","W2","W2"},

            {"  ","G5","  ","  ","  ","WW","WW","WW","WW","G2","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","W1","W5","W5","WD","W5"},

            {"  ","  ","  ","  ","  ","G2","G2","G2","G2","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","W4","W5","W5","W5","W5"},

            {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W1","W5","W5","W5","W5","W5"},

            {"  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","W5","W5","W5","W5","W5"},

            {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","W1","W5","W5","W5","W5","W5","W5"},

            {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","W1","W5","W5","W5","W5","W5","W5","W5"},

            {"W2","W2","W2","W3","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W1","W2","W2","W5","W5","WD","W5","W5","W5","W5","W5"},

            {"W5","W5","W5","W5","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5","W5"}
};

                

            if (entrance == 4) new Hero(new Vector2(750, 150));
            else new Hero(new Vector2(10, 330));

            new Goblin(new Vector2(400, 350));

            new Goblin(new Vector2(500, 250));

            GameStateManager.UIToggle = false;
        }
    }
}
