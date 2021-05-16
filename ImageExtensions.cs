
using SFML.Graphics;
using System;

namespace Retrodactyl.Extensions.SFML
{
    public static class ImageExtensions
    {
        
        public static Image Map(this Image img, Func<Color, Color> mapFn)
        {
            for (uint yy = 0; yy < img.Size.Y; yy++)
            {
                for (uint xx = 0; xx < img.Size.X; xx++)
                {
                    var p = img.GetPixel(xx, yy);
                    var n = mapFn(p);

                    if (p != n)
                    {
                        img.SetPixel(xx, yy, n);
                    }
                }
            }

            return img;
        }

        public static bool All(this Image img, Func<Color, bool> allFn)
        {
            for (uint yy = 0; yy < img.Size.Y; yy++)
            {
                for (uint xx = 0; xx < img.Size.X; xx++)
                {
                    var p = img.GetPixel(xx, yy);
                    if (!allFn(p)) return false;
                }
            }
            return true;
        }

        public static bool All(this Image img, IntRect rect, Func<Color, bool> allFn)
        {
            for (uint yy = (uint)rect.Top; yy < rect.Top + rect.Height; yy++)
            {
                for (uint xx = (uint)rect.Left; xx < rect.Left + rect.Width; xx++)
                {
                    var p = img.GetPixel(xx, yy);
                    if (!allFn(p)) return false;
                }
            }
            return true;
        }

        public static bool Any(this Image img, Func<Color, bool> anyFn)
        {
            for (uint yy = 0; yy < img.Size.Y; yy++)
            {
                for (uint xx = 0; xx < img.Size.X; xx++)
                {
                    var p = img.GetPixel(xx, yy);
                    if (anyFn(p)) return true;
                }
            }
            return false;
        }

        public static bool Any(this Image img, IntRect rect, Func<Color, bool> anyFn)
        {
            for (uint yy = (uint)rect.Top; yy < rect.Top + rect.Height; yy++)
            {
                for (uint xx = (uint)rect.Left; xx < rect.Left + rect.Width; xx++)
                {
                    var p = img.GetPixel(xx, yy);
                    if (anyFn(p)) return true;
                }
            }
            return false;
        }

        public static bool HasTransparency(this Image img)
        {
            return img.Any(p => p.A < 255);
        }

        public static bool HasTransparency(this Image img, IntRect rect)
        {
            return img.Any(rect, p => p.A < 255);
        }

        public static bool HasPixels(this Image img)
        {
            return !img.All(p => p.A == 0);
        }

        public static bool HasPixels(this Image img, IntRect rect)
        {
            return !img.All(rect, p => p.A == 0);
        }
    }
}