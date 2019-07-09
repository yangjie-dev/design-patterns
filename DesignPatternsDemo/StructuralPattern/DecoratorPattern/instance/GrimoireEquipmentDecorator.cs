namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public class GrimoireEquipmentDecorator : EquipmentDecorator
    {
        public GrimoireEquipmentDecorator(IHero hero) : base(hero)
        {
        }

        public override string Attack()
        {
            return string.Format("{0}, grimoire attack +10", base.Attack());
        }
    }
}