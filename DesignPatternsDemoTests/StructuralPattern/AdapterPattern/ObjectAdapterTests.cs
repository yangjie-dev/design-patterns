using System.Collections.Generic;
using DesignPatternsDemo.StructuralPattern.AdapterPattern.ObjectAdapter;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern.AdapterPattern
{
    public class ObjectAdapterTests
    {
        [Fact]
        public void ShouldGetTargetByAdaptee()
        {
            var targets = new List<Target> {new Target()};

            var target = new Adapter(new Adaptee());
            
            targets.Add(target);

            var isRequestAdaptee = targets.Exists(t =>t.Request().Equals("request adaptee"));
            
            Assert.True(isRequestAdaptee);
        }
    }
}