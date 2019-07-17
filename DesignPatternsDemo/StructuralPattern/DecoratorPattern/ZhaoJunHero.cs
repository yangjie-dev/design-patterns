namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public class ZhaoJunHero : Hero
    {
        public ZhaoJunHero()
        {
            AttackDescription += " by snow";
        }

        public override double Attack()
        {
            return 1;
        }
    }
}