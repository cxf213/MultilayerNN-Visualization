using System;
using System.Collections.Generic;
using System.Text;

namespace MLStudy.Libs
{
    class ActiveFunc
    {
        public static float Sigmoid(float x) => 1 / (1 + MathF.Exp(-x));
        public static float[] Sigmoid(float[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Sigmoid(x[i]);
            }
            return x;
        }

        public static float Dsigmoid(float x) => x * (1 - x);
        public static float[] Dsigmoid(float[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Dsigmoid(x[i]);
            }
            return x;
        }
        public static float ReLu(float x) => x > 0 ? x : 0;
        public static float DReLu(float x) => x > 0 ? 1 : 0;
        public static float[] ReLu(float[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = ReLu(x[i]);
            }
            return x;
        }
        public static float[] DReLu(float[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = DReLu(x[i]);
            }
            return x;
        }
    }
}
