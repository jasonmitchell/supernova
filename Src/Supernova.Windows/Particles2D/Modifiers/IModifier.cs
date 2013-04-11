namespace Supernova.Particles2D.Modifiers
{
    public interface IModifier
    {
        void Update(float particleAge, double totalMilliseconds, double elapsedSeconds, Particle2D particle);
    }
}