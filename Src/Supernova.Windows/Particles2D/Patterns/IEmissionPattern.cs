using System;
using Microsoft.Xna.Framework;

namespace Supernova.Particles2D.Patterns
{
    public interface IEmissionPattern
    {
        Vector2 CalculateParticlePosition(Random random, Vector2 emitPosition);
    }
}