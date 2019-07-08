namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class ColorA : IColor
    {
        public string DrawColor()
        {
            return "red";
        }
    }
}