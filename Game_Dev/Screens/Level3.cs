using Game_Dev.Characters;
using Game_Dev.Managers;
using Game_Dev.Objects.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Screens
{
    public class Level3 : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Map = new string[,]
{
        {"WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","W4","W5","W5"},

        {"WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WC","WW","WW","WW","WW","WW","W4","W5","WD"},

        {"WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","G2","G2","G2","G2","G2","  ","G2","G2","G2","WW","WW","W4","WD","W5"},

        {"WW","WW","WW","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","  ","  ","  ","  ","  ","  ","  ","  ","  ","G2","G2","W4","G1","G2"},

        {"G2","G2","G2","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","W4","G4","G5"},

        {"  ","  ","  ","G5","  ","  ","  ","G5","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","G4","  "},

        {"  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","W4","G7","G8"},

        {"W2","W2","W2","W2","W2","W3","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","G5","  ","W4","WW","WW"},

        {"W5","WD","W5","W5","W5","W6","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","W5","W5"},

        {"W5","W5","W5","W5","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","W5","WD"},

        {"W5","G1","G2","G3","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","W4","W5","W5"},

        {"W5","G4","G5","G6","W5","W5","W2","W2","W2","W3","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","WD","W5"},

        {"W5","G4","  ","  ","G2","G2","G3","W5","W5","W6","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","W1","W2","W5","W5","W5"},

        {"W5","G4","G5","  ","G5","  ","G6","W5","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","W5","W5","W5","W5"},

        {"W5","G7","G8","G8","G8","G8","G9","G3","W5","W6","  ","  ","  ","G5","  ","  ","  ","  ","  ","G5","  ","  ","W4","W5","W5","WD","W5"},

        {"W5","WW","WW","WW","WW","WW","WW","G9","W5","W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","W4","WD","W5","W5","G1"}
};


            if (entrance == 3) new Hero(new Vector2(450, 470));
            else new Hero(new Vector2(10, 150));

            if (!Key.keyObtained)
            {
                new CaveDoor(new Vector2(576, 32));
            }

            new Goblin(new Vector2(380, 150));
            
            new Goblin(new Vector2(550, 380));

            new Goblin(new Vector2(500, 250));

            GameStateManager.UIToggle = false;
        }
    }
}
