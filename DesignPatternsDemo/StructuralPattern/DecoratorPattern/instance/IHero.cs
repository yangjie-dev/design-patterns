namespace DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance
{
    public abstract class IHero
    {

        protected IHero()
        {
        }

        //定义虚函数，因为要实现基础方法 value++
        public virtual string Attack()
        {
            return "base attack +1";
        }
    }
}