using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev.Interfaces
{
    public interface IMovement
    {
        public IInput Input { get; set; }
        public float TimeRunning { get; set; }
        public float Speed { get; set; }
        public float SpeedCap { get; set; }
        public float Acceleration { get; set; }
        public float CalculateMove();
        public void ResetMovement();
    }
}
