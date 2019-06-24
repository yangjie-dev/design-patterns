using DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Product;

namespace DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Factory
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}