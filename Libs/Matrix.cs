using System;
using System.Collections.Generic;
using System.Text;

namespace MLStudy.Libs
{
    class MatrixF
    {
        //
        //        |1  0  1|
        //<N=2>   |0  1  2|
        //          <M=3>
        //
        //就是{ {1, 0}, {0, 1}, {1, 2} }
        //把一M维向量变换为N维

        int M = 1, N = 1;
        float[,] Mat;
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++)
                    res += Mat[i, j] + ",";
                res += "\n";
            }
            return res;
        }
        public float this[int i,int j]
        {
            get
            {
                return Mat[i, j];
            }
            set
            {
                Mat[i, j] = value;
            }
        }
        public MatrixF(int m, int n){
            M = m;
            N = n;
            Mat = new float[M, N];
        }
        public MatrixF(int m, int n, float value)
        {
            M = m;
            N = n;
            Mat = new float[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    Mat[i, j] = value;
        }
        public MatrixF(float[] input, int m, int n)
        {
            if (input.Length != m * n) throw new ApplicationException();
            M = m;
            N = n;
            Mat = new float[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    Mat[i, j] = input[i*N+j];
        }
        public MatrixF(float[,] input)
        {
            M = input.GetLength(0);
            N = input.GetLength(1);
            Mat = new float[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    Mat[i, j] = input[i, j];
        }
        public void Ramdomize()
        {
            Random rd = new Random();
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    Mat[i, j] = (float)rd.NextDouble();
        }


        public float[] dot(float[] A)
        {
            if (A.Length != M) return null;
            float[] res = new float[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    res[i] += A[j] * Mat[j, i];
                }
            }
            return res;
        }
        public static float[] dot(float[] A,MatrixF B)
        {
            if (A.Length != B.M) return null;
            float[] res = new float[B.N];
            for(int i = 0; i < B.N; i++)
            {
                for(int j = 0; j < B.M; j++)
                {
                    res[i] += A[j] * B[i, j];
                }
            }
            return res;
        }

        private void Subtact(MatrixF Y) 
        {

        }
        private float[] ArrayMultiNum(float[] x,float y)
        {
            float[] res = new float[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                res[i] = x[i] * y;
            }
            return res;
        }
        private float[] ArrayAddArray(float[] x, float[] y)
        {
            float[] res = new float[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                res[i] = x[i] * y[i];
            }
            return res;
        }
    }
}
