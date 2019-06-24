namespace DesignPatternsDemo.CreationalPattern.FactoryMethodPattern
{
    public class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}