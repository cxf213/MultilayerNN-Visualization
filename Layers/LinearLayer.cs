using System;
using System.Collections.Generic;
using System.Text;
using MLStudy.Libs;

namespace MLStudy.Layers
{
    class LinearLayer
    {
        private int inCount = 1, outCount = 1;
        MatrixF paras;
        float[] bias;
        float[] Inputs;

        private float learnRate = 1f;
        public float LearnRate { get => learnRate; set => learnRate = value; }

        public LinearLayer(int M, int N)
        {
            inCount = M;
            outCount = N;
            paras = new MatrixF(inCount, outCount, 1);
            bias = new float[outCount];
            Initiatize();
            //if (N == 1) Initiatize2();
            //if (N == 2) Initiatize1();
        }
        

        private void Initiatize()
        {
            Random rd = new Random();
            for (int i = 0; i < outCount; i++)
            {
                for (int j = 0; j < inCount; j++)
                {
                    paras[j, i] = (float)(rd.NextDouble()+0.1f);
                }
                bias[i] = 0;
            }
        }

        /// <summary>
        /// 仅供测试
        /// </summary>
        private void Initiatize1()
        {
            //  | 0.1   0.2 |   | 1 |   | 0.7   |
            //  |           | . |   | + |       |   运算
            //  | 0.3   0.4 |   | 0 |   | 0.8   |

            paras = new MatrixF(new float[2, 2] { { 0.1f, 0.3f }, { 0.2f, 0.4f } });
            bias = new float[2] { 0.7f, 0.8f };
        }
        /// <summary>
        /// 仅供测试
        /// </summary>
        private void Initiatize2()
        {
            paras = new MatrixF(new float[2, 1] { { 0.5f }, { 0.6f } });
            bias = new float[1] { 0.9f };
        }

        public float[] Forward(float[] data)
        {
            Inputs = (float[])data.Clone();
            data = Networks.ListAdd(paras.dot(data),bias);
            return data;
        }
        public float[] BackPropa(float[] ForwardDiff)
        {
            if (ForwardDiff.Length != outCount) return null;
            bias = Networks.ListDimi(bias, ForwardDiff);   //偏移参数的调整
            for (int i = 0; i < outCount; i++)  //矩阵调整
            {
                for(int j = 0; j < inCount; j++)
                {
                    paras[j, i] = paras[j, i] - Inputs[j] * ForwardDiff[i] * learnRate;
                }
            }

            float[] BackDiff = new float[inCount];
            for (int i = 0; i < inCount; i++)  
            {
                for (int j = 0; j < outCount; j++)
                {
                    BackDiff[i] = paras[i, j] * ForwardDiff[j];
                }
            }

            return BackDiff;
        }
    }
}
