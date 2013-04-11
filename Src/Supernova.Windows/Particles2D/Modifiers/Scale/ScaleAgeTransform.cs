using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Modifiers.Scale
{
    /// <summary>
    /// Modifier to scale particles based on age
    /// </summary>
    public class ScaleAgeTransform : IModifier
    {
        private Vector2 currentScale;

        public void Update(float particleAge, double totalMilliseconds, double elapsedSeconds, Particle2D particle)
        {
            float age = (float)(totalMilliseconds - particle.InceptionTime);

            if (age < particle.Lifespan)
            {
                currentScale.X = MathHelper.Lerp(StartScale.X, EndScale.X, age / particle.Lifespan);
                currentScale.Y = MathHelper.Lerp(StartScale.Y, EndScale.Y, age / particle.Lifespan);
            }
            else
                currentScale = EndScale;

            particle.Scale = currentScale;
        }

        /// <summary>
        /// Gets or sets the particle starting scale
        /// </summary>
        public Vector2 StartScale { get; set; }

        /// <summary>
        /// Gets or sets the particle end scale
        /// </summary>
        public Vector2 EndScale { get; set; }
    }
}
