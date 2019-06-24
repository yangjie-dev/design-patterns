using DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Product;

namespace DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Factory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}