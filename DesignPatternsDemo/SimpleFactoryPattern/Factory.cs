namespace DesignPatternsDemo.SimpleFactoryPattern
{
    public static class Factory
    {
        public static Product CreateInstanceBinderProduct(string productType)
        {
            if (productType.Equals("A"))
            {
                return new ProductA();
            }

            if(productType.Equals("B"))
            {
                return new ProductB();
            }

            return null;
        }
    }
}