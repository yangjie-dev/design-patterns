namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public abstract class EquipmentDecorator : IHero
    {
        public readonly IHero Hero;
       
        protected EquipmentDecorator(IHero hero)
        {
            Hero = hero;
        }

        //必须要override，要调用hero子类的方法
        public override string Attack()
        {
            return  Hero.Attack();
        }
    }
}