namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public class WandEquipmentDecorator : EquipmentDecorator
    {
        public WandEquipmentDecorator(IHero hero) : base(hero)
        {
        }

        public override string Attack()
        {
            return string.Format("{0}, wand attack +2", base.Attack());
        }
    }
}