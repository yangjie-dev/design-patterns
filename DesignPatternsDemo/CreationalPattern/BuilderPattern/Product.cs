namespace DesignPatternsDemo.CreationalPattern.BuilderPattern
{
    public class Product
    {
        public string _partA;

        public string _partB;

        public string _partC;

        public void SetPartA(string partA)
        {
            _partA = partA;
        }
        
        public void SetPartB(string partB)
        {
            _partB = partB;
        }
        
        public void SetPartC(string partC)
        {
            _partC = partC;
        }
    }
}