using System;
using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Patterns
{
    public class CircleEmissionPattern : IEmissionPattern
    {
        private readonly float radius;

        public CircleEmissionPattern(float radius)
        {
            this.radius = radius;
        }

        public Vector2 CalculateParticlePosition(Random random, Vector2 emitPosition)
        {
            float rads = (float)(random.NextDouble() * MathHelper.TwoPi);
            Vector2 offset = new Vector2((float)Math.Cos(rads) * radius, (float)Math.Sin(rads) * radius);
            
            return Vector2.Add(emitPosition, offset);
        }
    }
}