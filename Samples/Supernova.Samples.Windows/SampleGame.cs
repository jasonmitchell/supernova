using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Supernova.Samples.Windows.Utilities;
using Supernova.Windows.Particles2D;

namespace Supernova.Samples.Windows
{
    public class SampleGame : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private ParticleEffect2D particleEffect;

        public SampleGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            particleEffect = new ParticleEffect2D(1000, 2000);
            particleEffect.Textures.Add(Texture2DFactory.New(GraphicsDevice, 1, 1));
            particleEffect.Textures.Add(Texture2DFactory.New(GraphicsDevice, 2, 2));
            particleEffect.EmissionAmount = 75;
            particleEffect.EmissionSpeed = 2f;
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            Vector2 emitPosition = new Vector2(GraphicsDevice.Viewport.Width / 2f, GraphicsDevice.Viewport.Height / 2f);
            
            particleEffect.Emit((float) gameTime.TotalGameTime.TotalMilliseconds, emitPosition);
            particleEffect.Update((float) gameTime.TotalGameTime.TotalMilliseconds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            particleEffect.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
