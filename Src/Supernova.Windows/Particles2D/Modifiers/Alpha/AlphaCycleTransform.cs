using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Modifiers.Alpha
{
    /// <summary>
    /// Modifier which fades a particle in and out over time
    /// </summary>
    public class AlphaCycleTransform : IModifier
    {
        private float cycleInception;

        public void Update(float particleAge, double totalMilliseconds, double elapsedSeconds, Particle2D particle)
        {
            if (cycleInception == 0f)
                cycleInception = (float)totalMilliseconds;

            float age = (float)(totalMilliseconds - cycleInception);
            if (age >= CycleLength)
            {
                FadeIn = !FadeIn;
                cycleInception = (float)totalMilliseconds;
            }

            float cycleAge = age / CycleLength;

            particle.Alpha = FadeIn ? MathHelper.Lerp(0f, 1f, cycleAge) : MathHelper.Lerp(1f, 0f, cycleAge);
        }

        /// <summary>
        /// Gets or sets the length of each cycle in milliseconds
        /// </summary>
        public float CycleLength { get; set; }

        /// <summary>
        /// Gets or sets whether the modifier should fade in or out
        /// </summary>
        public bool FadeIn { get; set; }
    }
}
