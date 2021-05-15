using SFML;
using SFML.Graphics;
using System.Collections.Generic;
using System.IO;
using Retrodactyl.Extensions.SFML;

namespace Retrodactyl.Extensions.SFML
{
    public static class FileSystem
    {
        public static Font LoadFont(string fontPath)
        {
            Font font;
            try
            {
                font = new Font(fontPath);
            }
            catch
            {
                font = new Font(Path.Combine("../../../", fontPath));
            }
            return font;
        }
        public static Sprite LoadSprite(string imagePath)
        {
            Texture tex;
            try
            {
                tex = new Texture(imagePath);
            }
            catch (LoadingFailedException)
            {
                tex = new Texture(Path.Combine("../../../", imagePath));
            }

            // if the image contains no transparent pixels
            // try to infer transparency from the mask color (255,0,255)
            var img = tex.CopyToImage();
            if (!img.HasTransparency())
            {
                img.Map(p =>
                {
                    if (p.R == 255 && p.G == 0 && p.B == 255)
                    {
                        return new Color(0, 0, 0, 0);
                    }
                    else
                    {
                        return p;
                    }
                });
                tex = new Texture(img);
            }

            return new Sprite(tex);
        }

        public static Sprite[] LoadTiles(string imagePath, uint tileWidth, uint tileHeight)
        {
            var sprites = new List<Sprite>();
            Texture tex;
            try
            {
                tex = new Texture(imagePath);
            }
            catch (LoadingFailedException)
            {
                tex = new Texture(Path.Combine("../../../", imagePath));
            }
            tex.Smooth = false;

            // if the image contains no transparent pixels
            // try to infer transparency from the mask color (255,0,255)
            var img = tex.CopyToImage();
            if (!img.HasTransparency())
            {
                img.Map(p =>
                {
                    if (p.R == 255 && p.G == 0 && p.B == 255)
                    {
                        return new Color(0, 0, 0, 0);
                    }
                    else
                    {
                        return p;
                    }
                });
                tex = new Texture(img);
            }

            // load the tiles into sprites that have atleast 1 non transparent pixel
            for (uint y = 0; y < tex.Size.Y; y += tileHeight)
            {
                for (uint x = 0; x < tex.Size.X; x += tileWidth)
                {
                    var rect = new IntRect((int)x, (int)y, (int)tileWidth, (int)tileHeight);
                    if (img.HasPixels(rect))
                    {
                        var spr = new Sprite(tex, rect);
                        sprites.Add(spr);
                    }
                }
            }
            return sprites.ToArray();
        }

    }
}
