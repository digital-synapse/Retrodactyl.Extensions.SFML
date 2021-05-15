using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrodactyl.Extensions.SFML
{
    public static class IntRectExtensions
    {
        public static Vector2u GetSize(this IntRect rect)
        {
            return new Vector2u((uint)rect.Width, (uint)rect.Height);
        }
    }
}
