﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Interfaces
{
    public interface IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }
    }
}