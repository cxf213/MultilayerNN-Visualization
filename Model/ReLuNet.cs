using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLStudy.Libs;
using MLStudy.Layers;


namespace MLStudy.Model
{
    class ReLuNet : Models
    {
        float[] data2,data3;
        float cost = 0f;
        float ans;
        LinearLayer layer1;
        LinearLayer layer2, layer3;
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

        public ReLuNet()
        {
            layer1 = new LinearLayer(2, 10);
            layer2 = new LinearLayer(10, 5);
            layer3 = new LinearLayer(5, 1);
        }
        public float Calculate(float[] data)
        {
            data = layer1.Forward(data);
            data = ActiveFunc.ReLu(data);
            data2 = data;
            data = layer2.Forward(data);
            data = ActiveFunc.ReLu(data);
            data3 = data;
            data = layer3.Forward(data);
            data = ActiveFunc.Sigmoid(data);
            ans = data[0];
            return ans;
        }

        public void Callback(float exceptAns)
        {
            cost = Networks.Cost(ans, exceptAns);
            float[] d = (new float[] { Networks.Dcost(ans, exceptAns) * ActiveFunc.Dsigmoid(ans) });
            d = Networks.ListMulAdds(layer3.BackPropa(d), ActiveFunc.DReLu(data3));
            d = Networks.ListMulAdds(layer2.BackPropa(d), ActiveFunc.DReLu(data2));
            layer1.BackPropa(d);
        }

    }
}
