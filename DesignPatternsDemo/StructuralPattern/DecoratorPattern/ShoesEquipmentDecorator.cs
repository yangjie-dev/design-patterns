namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public class ShoesEquipmentDecorator : EquipmentDecorator
    {
        public ShoesEquipmentDecorator(Hero hero) : base(hero)
        {
        }
        
        public override string GetAttackDescription()
        {
            return Hero.GetAttackDescription() + ", shoes";
        }

        public override double Attack()
        {
            return Hero.Attack() + 2;
        }
    }
}