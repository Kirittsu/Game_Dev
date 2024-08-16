using Game_Dev.Characters.Enemy;
using Game_Dev.Characters.Player;
using Game_Dev.Managers;
using Game_Dev.Objects.GameObjects.Grass;
using Microsoft.Xna.Framework;

namespace Game_Dev.Screens
{
    public class Level5 : BaseScene
    {
        public override void LoadScene(int entrance)
        {
            Map = new string[,]
        {
            {"WD","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W8","W5","W5","W5","W5","W5"},

            {"W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","W4","G1","G2","G3","WD"},

            {"W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","W4","G7","  ","  ","G3"},

            {"W6","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","WW","W4","W2","G4","G5","G6"},

            {"W6","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","G2","W4","W5","G7","G8","G9"},

            {"W6","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","W4","W5","W2","W2","W2"},

            {"W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","WW","WW","W5","W5","W5"},

            {"W6","  ","  ","  ","  ","W1","W3","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","WW","WW","W5","WD","W5"},

            {"W6","  ","  ","  ","  ","W7","W9","  ","  ","  ","  ","  ","  ","  ","G5","  ","W1","W3","  ","  ","  ","  ","WW","WW","W5","W5","W5"},

            {"W6","  ","  ","  ","  ","WW","WW","  ","G5","  ","  ","  ","  ","  ","W1","W2","W7","W9","  ","  ","  ","  ","G2","G2","WW","WW","WW"},

            {"W6","  ","  ","  ","  ","G2","G2","  ","  ","  ","  ","G5","  ","  ","W7","W8","WW","WW","  ","  ","  ","  ","  ","  ","WW","WW","WW"},

            {"W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","WW","WW","WW","WW","  ","  ","  ","  ","  ","  ","WW","WW","WW"},

            {"W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G2","G2","G2","G2","  ","  ","G5","  ","  ","  ","G2","G2","G2"},

            {"W6","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","G5","  ","  "},

            {"W5","W2","W2","W2","W2","W2","W2","W2","W3","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  ","  "},

            {"W5","WD","W5","W5","W5","W5","WD","W5","W5","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2","W2"}
        };

            new Hero(new Vector2(800, 420));

            new GoblinBomber(new Vector2(530, 265));

            new GoblinBomber(new Vector2(465, 290));

            new GoblinBomber(new Vector2(175, 230));

            new Goblin(new Vector2(352, 416));

            new Goblin(new Vector2(176, 366));

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    float x = 576 + (i * 32);
                    float y = 130 + (j * 32);
                    new Spikes(new Vector2(x, y));
                }
            }

            if (Key.keyObtained == false) new Key(new Vector2(32, 130));

            GameStateManager.UIToggle = false;
        }
    }
}
