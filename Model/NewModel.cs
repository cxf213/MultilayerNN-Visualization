using System;
using System.Collections.Generic;
using System.Text;
using MLStudy.Libs;
using MLStudy.Layers;

namespace MLStudy.Model
{
    class NewModel:Models
    {
        float[]  data2;
        float cost = 0f;
        float ans;
        LinearLayer layer1;
        LinearLayer layer2;
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

        public NewModel()
        {
            layer1 = new LinearLayer(2, 3);
            layer2 = new LinearLayer(3, 1);
        }
        public float Calculate(float[] data)
        {
            data = layer1.Forward(data);
            data = ActiveFunc.Sigmoid(data);
            data2 = data;
            data = layer2.Forward(data);
            data = ActiveFunc.Sigmoid(data);
            ans = data[0];
            return ans;
        }

        public void Callback(float exceptAns)
        {
            cost = Networks.Cost(ans, exceptAns);
            float[] d = (new float[] { Networks.Dcost(ans, exceptAns) * ActiveFunc.Dsigmoid(ans) });
            //System.Windows.MessageBox.Show(Networks.tostring(d));
            d = Networks.ListMulAdds(layer2.BackPropa(d), ActiveFunc.Dsigmoid(data2));
            layer1.BackPropa(d);
        }
    }
}
