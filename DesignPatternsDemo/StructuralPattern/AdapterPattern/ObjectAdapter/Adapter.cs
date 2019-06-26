using System.Net.Cache;

namespace DesignPatternsDemo.StructuralPattern.AdapterPattern.ObjectAdapter
{
    public class Adapter : Target
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override string Request()
        {
            return _adaptee.SpecificRequest();
        }
    }
}