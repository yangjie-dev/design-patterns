namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public abstract class EquipmentDecorator : Hero
    {
        protected readonly Hero Hero;

        protected EquipmentDecorator(Hero hero)
        {
            Hero = hero;
        }


        public abstract override string GetAttackDescription();
    }
}