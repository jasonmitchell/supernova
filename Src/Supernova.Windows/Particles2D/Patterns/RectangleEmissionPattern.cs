using System;
using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Patterns
{
    public class RectangleEmissionPattern : IEmissionPattern
    {
        private readonly int width;
        private readonly int height;

        public RectangleEmissionPattern(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Vector2 CalculateParticlePosition(Random random, Vector2 emitPosition)
        {
            float halfWidth = width / 2f;
            float halfHeight = height / 2f;

            Vector2 offset = Vector2.Zero;
            offset.X = (float)((halfWidth - (-halfWidth)) * random.NextDouble() + (-halfWidth));
            offset.Y = (float)((halfHeight - (-halfHeight)) * random.NextDouble() + (-halfHeight));

            return Vector2.Add(emitPosition, offset);
        }
    }
}