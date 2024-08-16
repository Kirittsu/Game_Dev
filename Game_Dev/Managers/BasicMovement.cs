using Microsoft.Xna.Framework;
using Game_Dev.Interfaces;

namespace Game_Dev.Managers
{
    public class BasicMovement
    {
        public float TimeRunning { get; set; }
        public float Speed { get; set; }
        public float SpeedCap { get; set; }
        public float Acceleration { get; set; }
        public float Deceleration { get; set; } // New property for deceleration
        public Vector2 Velocity { get; set; }

        public BasicMovement(float speed, float speedCap, float acceleration, float deceleration)
        {
            Speed = speed;
            SpeedCap = speedCap;
            Acceleration = acceleration;
            Deceleration = deceleration; // Initialize deceleration
            Velocity = Vector2.Zero;
        }

        public Vector2 CalculateMove(Vector2 direction)
        {
            if (direction != Vector2.Zero)
            {
                // Accelerate when there is input
                Velocity += direction * Acceleration;
                if (Velocity.Length() > SpeedCap)
                {
                    Velocity.Normalize();
                    Velocity *= SpeedCap;
                }
            }
            else
            {
                // Apply deceleration when no input
                if (Velocity.Length() > 0)
                {
                    Velocity -= Velocity * Deceleration;
                    if (Velocity.Length() < 0.1f)
                    {
                        Velocity = Vector2.Zero;
                    }
                }
            }

            return Velocity;
        }

        public void ResetMovement()
        {
            Velocity = Vector2.Zero;
            TimeRunning = 0;
        }
    }
}