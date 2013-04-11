using Microsoft.Xna.Framework.Graphics;
using Supernova.Particles2D.Modifiers;
using Supernova.Particles2D.Patterns;

namespace Supernova.Particles2D
{
    public class ParticleEffect2DFactory
    {
        private readonly ParticleEffect2D particleEffect;

        public static ParticleEffect2DFactory Initialize(int maxParticles, int particleLifespan)
        {
            ParticleEffect2D particleEffect = new ParticleEffect2D(maxParticles, particleLifespan);
            return new ParticleEffect2DFactory(particleEffect);
        }

        private ParticleEffect2DFactory(ParticleEffect2D particleEffect)
        {
            this.particleEffect = particleEffect;
        }

        public ParticleEffect2DFactory SetEmitAmount(int emitAmount)
        {
            particleEffect.EmissionAmount = emitAmount;
            return this;
        }

        public ParticleEffect2DFactory SetMaxParticleSpeed(float maxSpeed)
        {
            particleEffect.EmissionSpeed = maxSpeed;
            return this;
        }

        public ParticleEffect2DFactory SetEmissionPattern(IEmissionPattern emissionPattern)
        {
            particleEffect.EmissionPattern = emissionPattern;
            return this;
        }

        public ParticleEffect2DFactory AddTexture(Texture2D texture)
        {
            particleEffect.Textures.Add(texture);
            return this;
        }

        public ParticleEffect2DFactory AddModifier(IModifier modifier)
        {
            particleEffect.Modifiers.Add(modifier);
            return this;
        }

        public ParticleEffect2D Create()
        {
            return particleEffect;
        }
    }
}