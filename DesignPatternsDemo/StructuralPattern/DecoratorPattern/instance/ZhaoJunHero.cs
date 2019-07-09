namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public class ZhaoJunHero : IHero
    {
        public override string Attack()
        {
            return string.Join(" ", base.Attack(), "by snow");
        }
    }
}