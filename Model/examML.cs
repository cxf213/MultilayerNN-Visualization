using System;
using MLStudy.Layers;
using MLStudy.Libs;

namespace MLStudy.Model
{
    public class examML:Models
    {
        NodeLayer layer2;
        FlatLayer layer1;
        float[] datas;
        float cost = 0f;
        float ans;
        public examML()
        {
            layer1 = new FlatLayer(2);
            layer2 = new NodeLayer(2);
        }

        private float learnRate = 1f;
        public float LearnRate
        {
            get
            {
                return learnRate;
            }
            set
            {
                learnRate = value;
                layer1.LearnRate = learnRate;
                layer2.LearnRate = learnRate;
            }
        }
        public float Cost { get => cost; set => cost = value; }
        public float Calculate(float[] data)
        {
            datas = data;
            datas = layer1.Forward(datas);
            datas = ActiveFunc.Sigmoid(datas);

            ans = layer2.Forward(datas);
            ans = ActiveFunc.Sigmoid(ans);
            return ans;
        }

        public void Callback(float exceptAns)
        {
            cost = (ans - exceptAns) * (ans - exceptAns) / 2;
            float dSig = Networks.Dcost(ans,exceptAns)* ActiveFunc.Dsigmoid(ans);
            float[] dlayer1 = Networks.ListMulAdds(layer2.BackPropa(dSig) , ActiveFunc.Dsigmoid(datas)); //第二层的反向传播
            layer1.BackPropa(dlayer1);
        }
    }
}
