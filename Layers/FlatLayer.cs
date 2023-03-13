using System;
using System.Collections.Generic;
using System.Text;
using MLStudy.Libs;

namespace MLStudy.Layers
{
    class FlatLayer
    {
        int N = 0;
        float[] paras;
        float[] bias;
        float[] datas;
        float[] origindata;

        float[] ddata;

        private float learnRate = 1f;
        public float LearnRate { get => learnRate; set => learnRate = value; }

        public FlatLayer(int N)
        {
            this.N = N;
            paras = new float[N * N];
            bias = new float[N];
            ddata = new float[N];
            Initiate();
        }

        public void Initiate()
        {
            paras = new float[] { 0.1f, 0.3f, 0.2f, 0.4f };
            bias = new float[] { 0.7f, 0.8f };
        }
        public float[] Forward(float[] data)
        {
            datas = data;
            origindata = data;
            return Networks.ListAdd(Networks.ListMulti(datas, paras), bias);
        }
        public void BackPropa(float[] x)
        {
            this.bias = Networks.ListDimi(bias, x);
            float[] dparas = new float[N * N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dparas[i * N + j] = origindata[i] * x[j] * LearnRate;
                }
            }
            this.paras = Networks.ListDimi(paras, dparas);
        }

    }
}
