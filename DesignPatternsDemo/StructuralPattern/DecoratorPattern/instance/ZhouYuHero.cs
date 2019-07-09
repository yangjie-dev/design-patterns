namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public class ZhouYuHero : IHero
    {
        public override string Attack()
        {
            return string.Join(" ", base.Attack(), "by fire");
        }
    }
}