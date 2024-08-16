using Microsoft.Xna.Framework;

namespace Game_Dev.Interfaces
{
    public interface IMovement
    {
        float TimeRunning { get; set; }
        float Speed { get; set; }
        float SpeedCap { get; set; }
        float Acceleration { get; set; }
        float Deceleration { get; set; }
        float CalculateMove(Vector2 direction);
        void ResetMovement();
    }
}
