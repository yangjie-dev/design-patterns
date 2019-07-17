namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public class ZhouYuHero : Hero
    {
        public ZhouYuHero()
        {
            AttackDescription += " by fire";
        }

        public override double Attack()
        {
            return 1.2;
        }
    }
}