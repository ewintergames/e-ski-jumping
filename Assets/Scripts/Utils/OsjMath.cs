using System;
using System.Collections.Generic;
using System.Numerics;

namespace OpenSkiJumping.Utils
{
    public static class OsjMath
    {
        public static Func<float, float> Polynom(params float[] coeffs)
        {
            return x =>
            {
                var res = 0f;
                var xx = 1f;
                foreach (var coef in coeffs)
                {
                    res += coef * x;
                    xx *= x;
                }
                return res;
            };
        }

        //value 0-1
        public static Func<float, float, float> LayeredPolynom(List<Func<float, float>> funcs)
        {
            return (x, t) =>
            {
                var n = funcs.Count - 1;
                var tt = t * n;
                var i0 = (int)MathF.Floor(tt);
                var i1 = (int)MathF.Ceiling(tt);
                if (i0 == i1) return funcs[i0](x);
                return (tt - i0) * funcs[i0](x) + (i1 - tt) * funcs[i1](x);
            };
        }
    }
}