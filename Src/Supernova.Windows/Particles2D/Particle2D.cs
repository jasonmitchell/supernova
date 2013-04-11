using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Supernova.Particles2D
{
    public class Particle2D
    {
        private Vector2 origin;
        private Vector2 position = Vector2.Zero;
        private Vector2 scale = Vector2.One;
        private Vector2 velocity = Vector2.Zero;
        private Vector2 projectedPosition = Vector2.Zero;
        private float rotation;

        private Texture2D texture;
        private Color color = Color.White;
        private float alpha = 1f;

        private float lifespan;
        private float inceptionTime;
        private bool isAlive;

        public void Initialize(Texture2D particleTexture, Vector2 emitPosition, Vector2 initialVelocity, Color particleColor, float particleLifespan, float totalMilliseconds)
        {
            this.texture = particleTexture;
            origin = new Vector2(particleTexture.Width / 2f, particleTexture.Height / 2f);

            isAlive = true;
            alpha = 1f;
            inceptionTime = totalMilliseconds;
            position = emitPosition;
            color = particleColor;
            lifespan = particleLifespan;
            velocity = initialVelocity;
        }

        internal void Update(double totalMilliseconds)
        {
            if (lifespan < (totalMilliseconds - inceptionTime))
            {
                isAlive = false;
            }
            else
            {
                position += velocity;
                projectedPosition = position + velocity;
            }
        }

        internal void Affect(ref Vector2 attraction)
        {
            velocity = Vector2.Add(velocity, attraction);
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, color * alpha, rotation, origin, scale, SpriteEffects.None, 0);
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 ProjectedPosition
        {
            get { return projectedPosition; }
        }

        public Vector2 Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public float Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public float Lifespan
        {
            get { return lifespan; }
            set { lifespan = value; }
        }

        public float InceptionTime
        {
            get { return inceptionTime; }
            set { inceptionTime = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
    }
}
