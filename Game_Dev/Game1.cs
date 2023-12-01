using Game_Dev.Charaters;
using Game_Dev.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;

namespace Game_Dev
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Rectangle _deelRectangle;
        private int schuifOp_X = 0;

        private Vector2 snelheid = new Vector2(1, 1);
        private Vector2 positie = new Vector2(10, 10);

        private Hero hero = new Hero();
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            hero.Texture = Content.Load<Texture2D>("hero");

            _deelRectangle = new Rectangle(schuifOp_X,80, 16, 16);

            ScreenManager.ScreenHeight = Window.ClientBounds.Height;
            ScreenManager.ScreenWidth = Window.ClientBounds.Width;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Move();

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
            _spriteBatch.Draw(hero.Texture,positie, _deelRectangle, Color.White, 0, new Vector2(1,1), hero.scale, SpriteEffects.None, 1);

            _spriteBatch.End();

            //Schuift op welk stukje uit 
            schuifOp_X += 16;
            if (schuifOp_X > 48)
            {
                schuifOp_X = 0;
            }

            _deelRectangle.X = schuifOp_X;

            base.Draw(gameTime);
        }

        private void Move()
        {
            positie += snelheid;
            if (positie.X > Window.ClientBounds.Width - 16 || positie.X < 0)
                snelheid.X *= -1;
            if (positie.Y < 0 || positie.Y > Window.ClientBounds.Height - 16)
                snelheid.Y *= -1;
        }
    }
}