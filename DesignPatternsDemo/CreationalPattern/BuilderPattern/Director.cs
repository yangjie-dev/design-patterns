namespace DesignPatternsDemo.CreationalPattern.BuilderPattern
{
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public Product Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
            
            return _builder.GetProduct();
        }
    }
}