namespace DeJong.VisualAStar
{
    using System;
    using System.Drawing;
    using Utilities;
    using Utilities.Core;

    public struct Vector2 : IEquatable<Vector2>, IEquatable<PointF>
    {
        public float X;
        public float Y;

        private static readonly Vector2 zero = new Vector2();
        private static readonly Vector2 invOne = new Vector2(-1);
        private static readonly Vector2 one = new Vector2(1);
        private static readonly Vector2 two = new Vector2(2);
        private static readonly Vector2 unitX = new Vector2(1, 0);
        private static readonly Vector2 unitY = new Vector2(0, 1);

        public float Length { get { return (float)Math.Sqrt(LengthSquared); } }
        public float LengthSquared { get { return Dot(this, this); } }

        public static Vector2 Zero { get { return Zero; } }
        public static Vector2 InvOne { get { return invOne; } }
        public static Vector2 One { get { return one; } }
        public static Vector2 UnitX { get { return unitX; } }
        public static Vector2 UnitY { get { return unitY; } }

        public static Vector2 operator -(Vector2 v) { return new Vector2(-v.X, -v.Y); }
        public static Vector2 operator -(Vector2 v1, Vector2 v2) { return new Vector2(v1.X - v2.X, v1.Y - v2.Y); }
        public static Vector2 operator +(Vector2 v1, Vector2 v2) { return new Vector2(v1.X + v2.X, v1.Y + v2.Y); }
        public static Vector2 operator /(Vector2 v1, Vector2 v2) { return new Vector2(v1.X / v2.X, v1.Y / v2.Y); }
        public static Vector2 operator /(Vector2 v, float a) { return new Vector2(v.X / a, v.Y / a); }
        public static Vector2 operator *(Vector2 v1, Vector2 v2) { return new Vector2(v1.X * v2.X, v1.Y * v2.Y); }
        public static Vector2 operator *(Vector2 v, float a) { return new Vector2(v.X * a, v.Y * a); }
        public static bool operator ==(Vector2 v1, Vector2 v2) { return v1.X == v2.X && v1.Y == v2.Y; }
        public static bool operator !=(Vector2 v1, Vector2 v2) { return v1.X != v2.X || v1.Y != v2.Y; }
        public static implicit operator Vector2(PointF p) { return new Vector2(p.X, p.Y); }
        public static implicit operator PointF(Vector2 v) { return new PointF(v.X, v.Y); }
        public static implicit operator Vector2(Point p) { return new Vector2(p.X, p.Y); }
        public static implicit operator Point(Vector2 v) { return new Point((int)v.X, (int)v.Y); }

        public float this[int index]
        {
            get
            {
                if (index == 0) return X;
                if (index == 1) return Y;
                throw new IndexOutOfRangeException("Index must be either zero or one!");
            }
        }

        public Vector2(float value)
        {
            X = value;
            Y = value;
        }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void Normalize()
        {
            this /= Length;
        }

        public static Vector2 Abs(Vector2 v)
        {
            return new Vector2(Math.Abs(v.X), Math.Abs(v.Y));
        }

        public static Vector2 Clamp(Vector2 v, Vector2 min, Vector2 max)
        {
            return new Vector2(ExtraMath.Clamp(v.X, min.X, max.X), ExtraMath.Clamp(v.Y, min.Y, max.Y));
        }

        public static float Distance(Vector2 v1, Vector2 v2)
        {
            return (v2 - v1).Length;
        }

        public static float DistanceSquared(Vector2 v1, Vector2 v2)
        {
            return (v2 - v1).LengthSquared;
        }

        public static float DistanceManhattan(Vector2 v1, Vector2 v2)
        {
            Vector2 result = Max(v1, v2) - Min(v1, v2);
            return result.X + result.Y;
        }

        public static float Dot(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public override bool Equals(object obj)
        {
            Vector2? vector = obj as Vector2?;
            if (vector.HasValue) return vector.Value == this;
            return false;
        }

        public bool Equals(Vector2 other)
        {
            return other == this;
        }

        public bool Equals(PointF other)
        {
            return other.X == X && other.Y == Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = Utils.HASH_BASE;
                result += Utils.ComputeHash(result, X);
                result += Utils.ComputeHash(result, Y);
                return result;
            }
        }

        public static Vector2 Lerp(Vector2 min, Vector2 max, float amount)
        {
            return new Vector2(ExtraMath.Lerp(amount, min.X, max.X), ExtraMath.Lerp(amount, min.Y, max.Y));
        }

        public static Vector2 InvLerp(Vector2 min, Vector2 max, Vector2 value)
        {
            return new Vector2(ExtraMath.InvLerp(value.X, min.X, max.X), ExtraMath.InvLerp(value.Y, min.Y, max.Y));
        }

        public static Vector2 Max(Vector2 v1, Vector2 v2)
        {
            return new Vector2(Math.Max(v1.X, v2.Y), Math.Max(v1.Y, v2.Y));
        }

        public static Vector2 Min(Vector2 v1, Vector2 v2)
        {
            return new Vector2(Math.Min(v1.X, v2.Y), Math.Min(v1.Y, v2.Y));
        }

        public static Vector2 Normalize(Vector2 v)
        {
            return v / v.Length;
        }

        public static Vector2 Reflect(Vector2 v, Vector2 n)
        {
            return v - two * Dot(v, n) * n;
        }

        public override string ToString()
        {
            return $"[X={X}, Y={Y}]";
        }
    }
}