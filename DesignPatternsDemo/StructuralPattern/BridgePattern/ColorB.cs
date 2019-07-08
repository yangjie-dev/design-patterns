namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class ColorB : IColor
    {
        public string DrawColor()
        {
            return "green";
        }
    }
}