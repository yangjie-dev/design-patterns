namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    //抽象类，不能被创建, 又可以定义基本实现
    public abstract class Painter
    {
        private readonly IColor _color;

        protected Painter(IColor color)
        {
            _color = color;
        }

        public virtual string Draw()
        {
            return "a paper with " + _color.DrawColor();
        }
    }
}