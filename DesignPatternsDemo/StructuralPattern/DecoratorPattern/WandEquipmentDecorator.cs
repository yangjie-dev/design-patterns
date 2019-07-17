namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public class WandEquipmentDecorator : EquipmentDecorator
    {
        public WandEquipmentDecorator(Hero hero) : base(hero)
        {
        }

        public override string GetAttackDescription()
        {
            return Hero.GetAttackDescription() + ", wand";
        }

        public override double Attack()
        {
            return Hero.Attack() + 5;
        }
    }
}