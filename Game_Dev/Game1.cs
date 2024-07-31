using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;
using System.Collections.Generic;

namespace Game_Dev
{
    public enum Status { Idle, Walking };

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
            base.Initialize();

            GameStateManager.gameObjects = new List<BaseObject>();
            GameStateManager.gameElements = new List<GameElement>();
            GameStateManager.graphics = GraphicsDevice;
            GameStateManager.content = this.Content;
            GameStateManager.LevelIndex = 1;
            GameStateManager.Font = Content.Load<SpriteFont>("Text");

            //_deelRectangle = new Rectangle(schuifOp_X,80, 16, 16);

            ScreenManager.ScreenHeight = Window.ClientBounds.Height;
            ScreenManager.ScreenWidth = Window.ClientBounds.Width;
            ScreenManager.Load();
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
            GraphicsDevice.Clear(Color.Peru);
            //_spriteBatch.Begin en .End moeten altijd staan als je sprites tekent, PointClamp MOET BLIJVEN! (zorgt dat het niet blurry is)
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            ScreenManager.Draw(_spriteBatch);

            //.Draw -> _texture = texture, Vector2 is positie, _deelRectangle pakt stuk uit spritesheet, Color.White MOET!
            //_spriteBatch.Draw(hero.Texture,hero.position, _deelRectangle, Color.White, 0, new Vector2(1,1), hero.scale, SpriteEffects.None, 1);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}