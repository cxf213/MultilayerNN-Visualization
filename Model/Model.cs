namespace MLStudy.Model
{
    public interface Models
    {
        public float Calculate(float[] data);
        public void Callback(float exceptAns);
        public float Cost { get; set; }
        public float LearnRate { get; set; }
    }
}
