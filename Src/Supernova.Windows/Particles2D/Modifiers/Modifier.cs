namespace Supernova.Particles2D.Modifiers
{
    /// <summary>
    /// Base class for all modifiers
    /// </summary>
    public abstract class Modifier
    {
        internal Modifier()
        {
            Identity = "No Identity";    
        }

        internal abstract void Update(float particleAge, double totalMilliseconds, double elapsedSeconds, Particle2D particle);

        /// <summary>
        /// Gets or sets the identity of the modifier
        /// </summary>
        public string Identity { get; set; }
    }
}