using DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Product;

namespace DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Factory
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}