namespace DesignPatternsDemo.CreationalPattern.BuilderPattern
{
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();
        
        void BuildPartC();

        Product GetProduct();
    }
}