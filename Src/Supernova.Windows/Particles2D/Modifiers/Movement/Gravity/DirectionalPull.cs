using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Modifiers.Movement.Gravity
{
    /// <summary>
    /// Modifier to gradually pull particles in a particular direction
    /// </summary>
    public class DirectionalPull : IModifier
    {
        public void Update(float particleAge, double totalMilliseconds, double elapsedSeconds, Particle2D particle)
        {
            Vector2 deltaGrav = Vector2.Multiply(Gravity, (float) elapsedSeconds);
            particle.Affect(ref deltaGrav);
        }

        /// <summary>
        /// Gets or sets the gravitational pull on particles
        /// </summary>
        public Vector2 Gravity { get; set; }
    }
}
