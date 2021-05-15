using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrodactyl.Extensions.SFML
{
    public static class FloatRectExtensions
    {
        public static Vector2f GetCenter(this FloatRect r)
        {
            return new Vector2f(r.Left + (r.Width / 2), r.Top + (r.Height / 2));
        }
        public static Vector2f GetSize(this FloatRect r)
        {
            return new Vector2f(r.Width, r.Height);
        }
        public static bool Contains(this FloatRect r, Vector2i v)
        {
            return r.Contains(v.X, v.Y);
        }
    }
}
