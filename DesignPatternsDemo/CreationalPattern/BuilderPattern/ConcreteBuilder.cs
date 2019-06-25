namespace DesignPatternsDemo.CreationalPattern.BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.SetPartA("A style");
        }

        public void BuildPartB()
        {
            _product.SetPartB("B style");
        }

        public void BuildPartC()
        {
            _product.SetPartC("C style");
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}