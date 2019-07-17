namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern
{
    public abstract class Hero
    {
        protected string AttackDescription = "base attack";

        public virtual string GetAttackDescription()
        {
            return AttackDescription;
        }

        public abstract double Attack();
    }
}