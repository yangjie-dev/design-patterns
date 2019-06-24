namespace DesignPatternsDemo.CreationalPattern.FactoryMethodPattern
{
    public class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}