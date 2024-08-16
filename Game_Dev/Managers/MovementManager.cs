using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Game_Dev.Characters;
using Game_Dev.Interfaces;

namespace Game_Dev.Managers
{
    public static class MovementManager
    {
        public static void Move(Character character, GameTime gameTime)
        {
            if (character is not Hero hero) return;

            Vector2 direction = GetMovementDirection();

            // Apply acceleration, deceleration, and movement
            float speed = hero.CalculateMove(direction);
            direction = direction != Vector2.Zero ? direction : hero.LastDirection;
            direction *= speed;

            if (direction.X != 0) character.Facing = new Vector2(direction.X, character.Facing.Y);
            direction = CollisionManager.MovementCollisionChecks(character, direction, GameStateManager.gameObjects);
            character.MinPosition += direction;

            UpdateHeroDarkness(hero);
            UpdateHeroStatus(character, direction);
        }

        private static Vector2 GetMovementDirection()
        {
            var direction = Vector2.Zero;
            var state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Left)) direction.X -= 1f;
            if (state.IsKeyDown(Keys.Right)) direction.X += 1f;
            if (state.IsKeyDown(Keys.Up)) direction.Y -= 1f;
            if (state.IsKeyDown(Keys.Down)) direction.Y += 1f;

            return direction != Vector2.Zero ? Vector2.Normalize(direction) : Vector2.Zero;
        }

        private static void UpdateHeroDarkness(Hero hero)
        {
            if (hero.heroDarkness == null) return;

            var offset = new Vector2(hero.heroDarkness.Texture.Width / 2 - hero.Width / 2, hero.heroDarkness.Texture.Height / 2 - hero.Height / 2);
            hero.heroDarkness.MinPosition = hero.MinPosition - offset;
        }

        private static void UpdateHeroStatus(Character character, Vector2 direction)
        {
            var state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.C))
                character.Status = Status.Attacking;
            else if (direction != Vector2.Zero)
                character.Status = Status.Walking;
            else
                character.Status = Status.Idle;
        }
    }
}