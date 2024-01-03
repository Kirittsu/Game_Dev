using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Objects;

namespace Game_Dev.Managers
{
    internal class AnimationManager
    {
        public static List<AnimationFrame> HeroIdle = new();
        public static List<AnimationFrame> HeroWalkLeft = new();
        public static List<AnimationFrame> HeroWalkRight = new();
        public static List<AnimationFrame> HeroWalkUp = new();
        public static List<AnimationFrame> HeroWalkDown = new();

        //public static AnimationFrame GetCurrentFrame(int index, BaseObject requester)
        //{
        //    AnimationFrame frame = null;
        //    List<AnimationFrame> selectedList = null;

        //    return yourmom;
        //}
    }
}
