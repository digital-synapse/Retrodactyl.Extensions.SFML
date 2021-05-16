using SFML.System;
using System;

namespace Retrodactyl.Extensions.SFML
{
    public static class Vector2Extensions
    {
        public static Vector2f ToVector2f(this Vector2u v)
        {
            return new Vector2f(v.X, v.Y);
        }
        public static Vector2f ToVector2f(this Vector2i v)
        {
            return new Vector2f(v.X, v.Y);
        }
        public static Vector2i ToVector2i(this Vector2f v)
        {
            return new Vector2i((int)v.X, (int)v.Y);
        }
        public static Vector2f Add(this Vector2f a, Vector2f b)
        {
            return new Vector2f(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2f Add(this Vector2f a, float b)
        {
            return new Vector2f(a.X + b, a.Y + b);
        }
        public static Vector2f Sub(this Vector2f a, Vector2f b)
        {
            return new Vector2f(a.X - b.X, a.Y - b.Y);
        }
        public static Vector2f Sub(this Vector2f a, float b)
        {
            return new Vector2f(a.X - b, a.Y - b);
        }
        public static Vector2f Mul(this Vector2f a, Vector2f b)
        {
            return new Vector2f(a.X * b.X, a.Y * b.Y);
        }
        public static Vector2f Mul(this Vector2f a, float b)
        {
            return new Vector2f(a.X * b, a.Y * b);
        }

        public static float Mul(this Vector2f a)
        {
            return a.X * a.Y;
        }
        public static Vector2f Div(this Vector2f a, Vector2f b)
        {
            return new Vector2f(a.X / b.X, a.Y / b.Y);
        }
        public static Vector2f Div(this Vector2f a, float b)
        {
            return new Vector2f(a.X / b, a.Y / b);
        }

        public static Vector2f Floor(this Vector2f v)
        {
            return new Vector2f(MathF.Floor(v.X), MathF.Floor(v.Y));
        }
        public static Vector2f Ceiling(this Vector2f v)
        {
            return new Vector2f(MathF.Ceiling(v.X), MathF.Ceiling(v.Y));
        }
        public static Vector2f Under(this Vector2f v, float numerator)
        {
            return new Vector2f(numerator / v.X, numerator / v.Y);
        }
        public static Vector2f Abs(this Vector2f v)
        {
            return new Vector2f(MathF.Abs(v.X), MathF.Abs(v.Y));
        }
        public static float Dot(this Vector2f a, Vector2f b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public static float Dist(this Vector2f a, Vector2f b)
        {
            var x = b.X - a.X;
            var y = b.Y - a.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
    }
}
