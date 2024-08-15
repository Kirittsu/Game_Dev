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
    public class Level6 : BaseScene
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

            new HeroDarkness(new Vector2(0, 0), new Hero(new Vector2(400, 460)));

            var spikeRegions = new (int startX, int startY, int width, int height)[]
            {
                (320, 160, 1, 1),
                (480, 160, 1, 1),
                (544, 160, 1, 1),
                (608, 160, 1, 1),
                (640, 256, 3, 2),
                (768, 96, 2, 9),
                (224, 32, 4, 2),
                (512, 32, 3, 2)
            };

            foreach (var region in spikeRegions)
            {
                for (int i = 0; i < region.width; i++)
                {
                    for (int j = 0; j < region.height; j++)
                    {
                        if (region == spikeRegions[5] &&
                           ((i == 0 && (j == 2 || j == 3)) || (i == 1 && (j == 5 || j == 6))))
                        {
                            continue;
                        }
                        float x = region.startX + (i * 32);
                        float y = region.startY + (j * 32);
                        new Spikes(new Vector2(x, y));
                    }
                }
            }
            GameStateManager.UIToggle = false;
        }
    }
}
