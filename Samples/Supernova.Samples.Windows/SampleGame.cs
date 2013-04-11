using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Supernova.Particles2D;
using Supernova.Particles2D.Modifiers.Alpha;
using Supernova.Samples.Windows.Utilities;

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

            particleEffect = ParticleEffect2DFactory.Initialize(1000, 2000)
                                                    .SetMaxParticleSpeed(2f)
                                                    .SetEmitAmount(75)
                                                    .AddTexture(Texture2DFactory.New(GraphicsDevice, 1, 1))
                                                    .AddTexture(Texture2DFactory.New(GraphicsDevice, 2, 2))
                                                    .AddModifier(new AlphaAgeTransform())
                                                    .Create();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            Vector2 emitPosition = new Vector2(GraphicsDevice.Viewport.Width / 2f, GraphicsDevice.Viewport.Height / 2f);
            
            particleEffect.Emit((float) gameTime.TotalGameTime.TotalMilliseconds, emitPosition);
            particleEffect.Update((float) gameTime.TotalGameTime.TotalMilliseconds, (float) gameTime.ElapsedGameTime.TotalSeconds);

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
