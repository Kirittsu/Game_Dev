using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;
using System.Collections.Generic;

namespace Game_Dev
{
    public enum Status { Idle, Walking, Attacking };

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 27 * 32;
            _graphics.PreferredBackBufferHeight = 16 * 32;
            _graphics.ApplyChanges();

            base.Initialize();

            GameStateManager.gameObjects = new List<BaseObject>();
            GameStateManager.gameElements = new List<GameElement>();
            GameStateManager.graphics = GraphicsDevice;
            GameStateManager.content = this.Content;
            GameStateManager.LevelIndex = 6;
            GameStateManager.Font = Content.Load<SpriteFont>("Text");

            AnimationManager.Load();

            ScreenManager.ScreenHeight = Window.ClientBounds.Height;
            ScreenManager.ScreenWidth = Window.ClientBounds.Width;
            ScreenManager.Load(0);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            ScreenManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            //_spriteBatch.Begin en .End moeten altijd staan als je sprites tekent, PointClamp MOET BLIJVEN! (zorgt dat het niet blurry is)
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            ScreenManager.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}