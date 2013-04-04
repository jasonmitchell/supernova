using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Supernova.Samples.Windows.Utilities
{
    public static class Texture2DFactory
    {
        public static Texture2D New(GraphicsDevice graphicsDevice, int width, int height)
        {
            Texture2D texture = new Texture2D(graphicsDevice, width, height, false, SurfaceFormat.Color);

            Color[] colorData = new Color[width * height];
            for (int i = 0; i < colorData.Length; i++)
            {
                colorData[i] = Color.White;
            }
            texture.SetData(colorData);

            return texture;
        }
    }
}
