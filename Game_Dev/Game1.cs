using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_Dev
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _texture;
        private Rectangle _deelRectangle;
        private int schuifOp_X = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _deelRectangle = new Rectangle(schuifOp_X,80, 16, 16);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _texture = Content.Load<Texture2D>("hero");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //_spriteBatch.Begin en .End moeten altijd staan als je sprites tekent, PointClamp MOET BLIJVEN! (zorgt dat het niet blurry is)
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //.Draw -> _texture = texture, Vector2 is positie, _deelRectangle pakt stuk uit spritesheet, Color.White MOET!
            _spriteBatch.Draw(_texture,new Vector2(10,10), _deelRectangle, Color.White, 0, new Vector2(1,1), new Vector2(8,8), SpriteEffects.None, 1);
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
    }
}