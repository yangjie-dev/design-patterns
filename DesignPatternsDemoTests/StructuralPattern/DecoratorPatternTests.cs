using System.Threading.Tasks.Dataflow;
using DesignPatternsDemo.StructuralPattern.DecoratorPattern.instance;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class DecoratorPatternTests
    {
        [Fact]
        public void ShouldGetZhouYuHeroBaseAttack()
        {
            var zhouYuHero = new ZhouYuHero();

            Assert.Equal("base attack +1 by fire", zhouYuHero.Attack());
        }

        [Fact]
        public void ShouldGetZhouYuHeroWithWandAttack()
        {
            var zhouYuHero = new WandEquipmentDecorator(new ZhouYuHero());

            Assert.Equal("base attack +1 by fire, wand attack +2", zhouYuHero.Attack());
        }
        
        [Fact]
        public void ShouldGetZhaoJunHeroWithWandAttackAndGrimoireAttack()
        {
            var zhaoJunHero = new GrimoireEquipmentDecorator(new WandEquipmentDecorator(new ZhaoJunHero()));

            Assert.Equal("base attack +1 by snow, wand attack +2, grimoire attack +10", zhaoJunHero.Attack());
        }
    }
}