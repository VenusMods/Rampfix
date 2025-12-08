using Sharp.Shared.Types;

namespace RampFix;

internal static class VectorExtension
{
    extension(Vector vec)
    {
        public Vector Normalized()
        {
            var result = vec;
            var length = MathF.Sqrt((result.X * result.X) + (result.Y * result.Y) + (result.Z * result.Z));

            result.X /= length;
            result.Y /= length;
            result.Z /= length;

            return result;
        }
    }
}
